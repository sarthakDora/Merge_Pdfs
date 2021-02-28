
namespace Merge_Pdfs
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chkOpen = new System.Windows.Forms.CheckBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnMerge = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnSelectFiles = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.fileStructureBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filepathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileStructureBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.chkOpen);
			this.panel1.Controls.Add(this.lblStatus);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnMerge);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.btnSelectFiles);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(320, 373);
			this.panel1.TabIndex = 0;
			// 
			// chkOpen
			// 
			this.chkOpen.AutoSize = true;
			this.chkOpen.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkOpen.Location = new System.Drawing.Point(38, 282);
			this.chkOpen.Name = "chkOpen";
			this.chkOpen.Size = new System.Drawing.Size(94, 17);
			this.chkOpen.TabIndex = 5;
			this.chkOpen.Text = "Merge && Open";
			this.chkOpen.UseVisualStyleBackColor = true;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(35, 314);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(43, 13);
			this.lblStatus.TabIndex = 4;
			this.lblStatus.Text = "Status :";
			// 
			// btnClear
			// 
			this.btnClear.ForeColor = System.Drawing.Color.Red;
			this.btnClear.Location = new System.Drawing.Point(249, 54);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(39, 23);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnMerge
			// 
			this.btnMerge.BackColor = System.Drawing.Color.SteelBlue;
			this.btnMerge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnMerge.Location = new System.Drawing.Point(138, 278);
			this.btnMerge.Name = "btnMerge";
			this.btnMerge.Size = new System.Drawing.Size(150, 23);
			this.btnMerge.TabIndex = 2;
			this.btnMerge.Text = "Merge";
			this.btnMerge.UseVisualStyleBackColor = false;
			this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn,
            this.filepathDataGridViewTextBoxColumn,
            this.orderDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.fileStructureBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(38, 83);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(250, 184);
			this.dataGridView1.TabIndex = 1;
			// 
			// btnSelectFiles
			// 
			this.btnSelectFiles.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSelectFiles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSelectFiles.Location = new System.Drawing.Point(38, 54);
			this.btnSelectFiles.Name = "btnSelectFiles";
			this.btnSelectFiles.Size = new System.Drawing.Size(204, 23);
			this.btnSelectFiles.TabIndex = 0;
			this.btnSelectFiles.Text = "Select Files";
			this.btnSelectFiles.UseVisualStyleBackColor = false;
			this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// fileStructureBindingSource
			// 
			this.fileStructureBindingSource.DataSource = typeof(Merge_Pdfs.FileStructure);
			// 
			// fileNameDataGridViewTextBoxColumn
			// 
			this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
			this.fileNameDataGridViewTextBoxColumn.HeaderText = "File Name";
			this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
			this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.fileNameDataGridViewTextBoxColumn.Width = 150;
			// 
			// filepathDataGridViewTextBoxColumn
			// 
			this.filepathDataGridViewTextBoxColumn.DataPropertyName = "Filepath";
			this.filepathDataGridViewTextBoxColumn.HeaderText = "Filepath";
			this.filepathDataGridViewTextBoxColumn.Name = "filepathDataGridViewTextBoxColumn";
			this.filepathDataGridViewTextBoxColumn.Visible = false;
			// 
			// orderDataGridViewTextBoxColumn
			// 
			this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
			this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
			this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
			this.orderDataGridViewTextBoxColumn.Width = 50;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 373);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Merge PDF App";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileStructureBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnMerge;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSelectFiles;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.CheckBox chkOpen;
		private System.Windows.Forms.BindingSource fileStructureBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn filepathDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
	}
}

