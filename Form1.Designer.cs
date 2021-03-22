namespace SudokuTest
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSolve = new System.Windows.Forms.ToolStripButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonSolve});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(323, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonOpen
			// 
			this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
			this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOpen.Name = "toolStripButtonOpen";
			this.toolStripButtonOpen.Size = new System.Drawing.Size(40, 22);
			this.toolStripButtonOpen.Text = "Open";
			this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
			// 
			// toolStripButtonSave
			// 
			this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
			this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSave.Name = "toolStripButtonSave";
			this.toolStripButtonSave.Size = new System.Drawing.Size(35, 22);
			this.toolStripButtonSave.Text = "Save";
			this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
			// 
			// toolStripButtonSolve
			// 
			this.toolStripButtonSolve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonSolve.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSolve.Image")));
			this.toolStripButtonSolve.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSolve.Name = "toolStripButtonSolve";
			this.toolStripButtonSolve.Size = new System.Drawing.Size(42, 22);
			this.toolStripButtonSolve.Text = "Solve!";
			this.toolStripButtonSolve.Click += new System.EventHandler(this.toolStripButtonSolve_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "csv";
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.InitialDirectory = "C:\\Temp";
			this.openFileDialog1.Title = "Open sudoku";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "csv";
			this.saveFileDialog1.InitialDirectory = "C:\\Temp";
			this.saveFileDialog1.Title = "Save sudoku";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ColumnHeadersVisible = false;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
			this.dataGridView1.Location = new System.Drawing.Point(12, 28);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.Format = "N0";
			dataGridViewCellStyle6.NullValue = null;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView1.Size = new System.Drawing.Size(299, 300);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column1.HeaderText = "";
			this.Column1.MaxInputLength = 1;
			this.Column1.Name = "Column1";
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.Width = 5;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column2.HeaderText = "";
			this.Column2.MaxInputLength = 1;
			this.Column2.Name = "Column2";
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column2.Width = 5;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column3.HeaderText = "";
			this.Column3.MaxInputLength = 1;
			this.Column3.Name = "Column3";
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column3.Width = 5;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column4.HeaderText = "";
			this.Column4.MaxInputLength = 1;
			this.Column4.Name = "Column4";
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column4.Width = 5;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column5.HeaderText = "";
			this.Column5.MaxInputLength = 1;
			this.Column5.Name = "Column5";
			this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column5.Width = 5;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column6.HeaderText = "";
			this.Column6.MaxInputLength = 1;
			this.Column6.Name = "Column6";
			this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column6.Width = 5;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column7.HeaderText = "";
			this.Column7.MaxInputLength = 1;
			this.Column7.Name = "Column7";
			this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column7.Width = 5;
			// 
			// Column8
			// 
			this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column8.HeaderText = "";
			this.Column8.MaxInputLength = 1;
			this.Column8.Name = "Column8";
			this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column8.Width = 5;
			// 
			// Column9
			// 
			this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column9.HeaderText = "";
			this.Column9.MaxInputLength = 1;
			this.Column9.Name = "Column9";
			this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column9.Width = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 340);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.ToolStripButton toolStripButtonSolve;
	}
}

