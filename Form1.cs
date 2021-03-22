using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuTest
{
	public partial class Form1 : Form
	{
		int[][] board = new int[9][].Select(item => new int[9]).ToArray();
		HashSet<int>[][] candidates;
		bool somethingChanged;

		HashSet<int>[] GetScope(int[] row, int[] column, int scopeType) => scopeType switch
		{
			0 => candidates[row[0]].Where((item, index) => !column.Contains(index)).ToArray(),
			1 => candidates.Where((item, index) => !row.Contains(index)).Select(item => item[column[0]]).ToArray(),
			2 => candidates.Where((item, index) => index >= (row[0] / 3 * 3) && index <= (row[0] / 3 * 3 + 2)).SelectMany((item, index) => item.Where((item1, index1) => index1 >= (column[0] / 3 * 3) && index1 <= (column[0] / 3 * 3 + 2) && !(row.Any(item2 => item2 % 3 == index) && column.Contains(index1))).ToArray()).ToArray()
		};

		public Form1()
		{
			InitializeComponent();
			FillField();
		}

		public void FillField()
		{
			dataGridView1.Rows.Clear();
			for (int i = 0; i < 9; i++)
			{
				dataGridView1.Rows.Add();
				for (int j = 0; j < 9; j++)
				{
					dataGridView1.Rows[i].Cells[j].Value = board[i][j] == 0 ? "" : board[i][j].ToString();
					dataGridView1.Rows[i].Cells[j].Style.BackColor = (i / 3 + j / 3) % 2 == 0 ? Color.LightGray : Color.White;
				}
			}
		}

		public HashSet<int> GetRowValues(int row)
		{
			return board[row].Where(item => item != 0).ToHashSet();
		}

		public HashSet<int> GetColumnValues(int column)
		{
			return board.Select(item => item[column]).Where(item => item != 0).ToHashSet();
		}

		public HashSet<int> GetSquareValues(int row, int column)
		{
			HashSet<int> squareValues = new HashSet<int>();
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					squareValues.Add(board[row / 3 * 3 + i][column / 3 * 3 + j]);
				}
			}
			return squareValues.Where(item => item != 0).ToHashSet();
		}

		public void RemoveFromScope(int[] numbersToRemove, HashSet<int>[] scope)
		{
			for (int i = 0; i < scope.Length; i++)
			{
				for (int j = 0; j < numbersToRemove.Length; j++)
				{
					scope[i].Remove(numbersToRemove[j]);
				}
			}
		}

		public HashSet<int> OnlyElement(HashSet<int> thisCell, HashSet<int>[] scope)
		{
			HashSet<int> copyCell = new HashSet<int>(thisCell);
			for (int i = 0; i < scope.Length; i++)
			{
				copyCell = copyCell.Except(scope[i]).ToHashSet();
			}
			return copyCell.Count == 1 ? copyCell : thisCell;
		}

		public void CheckIntersection(int squareRow, int[] squareColumn)
		{
			if (!squareColumn.Skip(1).Aggregate(candidates[squareRow][squareColumn[0]].SequenceEqual(candidates[squareRow][squareColumn[1]]), (current, next) => current &= candidates[squareRow][squareColumn[0]].SequenceEqual(candidates[squareRow][next])))
			{
				int[] intersection = squareColumn.Skip(1).Aggregate(candidates[squareRow][squareColumn[0]], (current, next) => current.Intersect(candidates[squareRow][next]).ToHashSet()).ToArray();
				if (intersection.Length <= squareColumn.Length)
				{
					somethingChanged = true;
					RemoveFromScope(intersection, GetScope(new int[] { squareRow }, squareColumn, 0));
					RemoveFromScope(intersection, GetScope(new int[] { squareRow }, squareColumn, 2));
				}
			}
		}

		public void CheckIntersection(int[] squareRow, int squareColumn)
		{
			if (!squareRow.Skip(1).Aggregate(candidates[squareRow[0]][squareColumn].SequenceEqual(candidates[squareRow[1]][squareColumn]), (current, next) => current &= candidates[squareRow[0]][squareColumn].SequenceEqual(candidates[next][squareColumn])))
			{
				int[] intersection = squareRow.Skip(1).Aggregate(candidates[squareRow[0]][squareColumn], (current, next) => current.Intersect(candidates[next][squareColumn]).ToHashSet()).ToArray();
				if (intersection.Length <= squareRow.Length)
				{
					somethingChanged = true;
					RemoveFromScope(intersection, GetScope(squareRow, new int[] { squareColumn }, 1));
					RemoveFromScope(intersection, GetScope(squareRow, new int[] { squareColumn }, 2));
				}
			}
		}

		//if 2 or 3 elements are needed on the same line of the same square remove them from the rest of the square, column or row
		public void Intersections(int squareRow, int squareColumn)
		{
			//check combinations in rows
			for (int i = 0; i < 3; i++)
			{
				CheckIntersection(squareRow + i, new int[] { squareColumn, squareColumn + 1, squareColumn + 2 });
				CheckIntersection(squareRow + i, new int[] { squareColumn, squareColumn + 1 });
				CheckIntersection(squareRow + i, new int[] { squareColumn + 1, squareColumn + 2 });
			}
			//check combinations in columns
			for (int i = 0; i < 3; i++)
			{
				CheckIntersection(new int[] { squareRow, squareRow + 1, squareRow + 2 }, squareColumn + i);
				CheckIntersection(new int[] { squareRow, squareRow + 1 }, squareColumn + i);
				CheckIntersection(new int[] { squareRow + 1, squareRow + 2 }, squareColumn + i);
			}
		}

		private void toolStripButtonSolve_Click(object sender, EventArgs e)
		{
			candidates = new HashSet<int>[9][].Select((item, index) => new HashSet<int>[9].Select((item1, index1) => board[index][index1] == 0 ? ((new int[9]).Select((item2, index2) => index2 + 1).Except(GetRowValues(index).Union(GetColumnValues(index1).Union(GetSquareValues(index, index1))).ToHashSet()).ToHashSet()) : new HashSet<int> { board[index][index1] }).ToArray()).ToArray();
			somethingChanged = true;
			while (board.SelectMany(item => item).Any(item => item == 0) && somethingChanged)
			{
				while (somethingChanged)
				{
					somethingChanged = false;
					for (int i = 0; i < 9; i++)
					{
						for (int j = 0; j < 9; j++)
						{
							if (board[i][j] == 0)
							{
								HashSet<int> existingValues = GetRowValues(i).Union(GetColumnValues(j).Union(GetSquareValues(i, j))).ToHashSet();
								candidates[i][j] = candidates[i][j].Where(item => !existingValues.Contains(item)).ToHashSet();
								for (int k = 0; k < 3 && candidates[i][j].Count != 1; k++)
								{
									candidates[i][j] = OnlyElement(candidates[i][j], GetScope(new int[] { i }, new int[] { j }, k));
								}
								if (candidates[i][j].Count == 1)
								{
									int winner = candidates[i][j].ToList()[0];
									for (int k = 0; k < 3 && candidates[i][j].Count != 1; k++)
									{
										RemoveFromScope(new int[] { winner }, GetScope(new int[] { i }, new int[] { j }, k));
									}
									board[i][j] = winner;
									dataGridView1.Rows[i].Cells[j].Value = winner.ToString();
									dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
									somethingChanged = true;
								}
							}
						}
					}
				}
				somethingChanged = true;
				while (somethingChanged)
				{
					somethingChanged = false;
					for (int i = 0; i < 3; i++)
					{
						for (int j = 0; j < 3; j++)
						{
							Intersections(i * 3, j * 3);
						}
					}
				}
			}
		}

		private void toolStripButtonOpen_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				using (var reader = new StreamReader(openFileDialog1.FileName))
				{
					int i = 0;
					while (!reader.EndOfStream)
					{
						var line = reader.ReadLine();
						var values = line.Split(';');
						if (values.All(item => int.TryParse(item, out _)))
						{
							board[i] = values.Select(item => int.Parse(item)).ToArray();
						}
						else
						{
							MessageBox.Show("Wrong file format!");
							break;
						}
						i++;
					}
				}
				FillField();
			}
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			var value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			if (((string)value).Equals("0"))
			{
				dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
			}
			board[e.RowIndex][e.ColumnIndex] = string.IsNullOrEmpty(((string)value).Trim()) ? 0 : int.Parse((string)value);
		}

		private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			dataGridView1.EditingControl.KeyPress -= EditingControl_KeyPress;
			dataGridView1.EditingControl.KeyPress += EditingControl_KeyPress;
		}

		private void EditingControl_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void toolStripButtonSave_Click(object sender, EventArgs e)
		{
			saveFileDialog1.FileName = "sudoku_" + DateTime.Now.ToString("yyMMddHHmmss");
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
				{
					for (int i = 0; i < 9; i++)
					{
						sw.WriteLine(string.Join(";", board[i]));
					}
				}
			}
		}
	}
}
