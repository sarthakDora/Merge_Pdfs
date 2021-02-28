
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merge_Pdfs
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			InitializeOpenFileDialog();
			InitializeSaveFileDialog();
		}
		private void InitializeOpenFileDialog()
		{
			// Set the file dialog to filter for graphics files.
			this.openFileDialog1.Filter =
				"PDF |*.PDF|" +
				//"Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
				"All files (*.*)|*.*";

			// Allow the user to select multiple images.
			this.openFileDialog1.Multiselect = true;
			this.openFileDialog1.Title = "Please select multiple PDFs";
		}
		private void InitializeSaveFileDialog()
		{
			// Set the file dialog to filter for graphics files.
			this.saveFileDialog1.Filter =
				"PDF |*.PDF|" +
				"All files (*.*)|*.*";

			// Allow the user to save new merged pdf.

			this.saveFileDialog1.FileName = "NewFile" + new Guid();
			this.saveFileDialog1.DefaultExt = "pdf";
			this.saveFileDialog1.Title = "Save New PDF";
			this.saveFileDialog1.AddExtension = true;
			this.saveFileDialog1.InitialDirectory = Path.GetTempPath();
		}
		List<FileStructure> _Files = new List<FileStructure>();
		int index = 1;
		private void btnSelectFiles_Click(object sender, EventArgs e)
		{
			lblSuccess.Visible = false;
			changeStepColor(this.btnStep2, true, Color.DarkSeaGreen, Color.White);
			DialogResult dr = this.openFileDialog1.ShowDialog();
			if (dr == System.Windows.Forms.DialogResult.OK)
			{
				// Read the files
				int i = 0;
				foreach (String file in openFileDialog1.FileNames)
				{
					_Files.Add(new FileStructure() { FileName = openFileDialog1.SafeFileNames[i], Filepath = file, Order = index });
					index++;
					i++;
				}
				showFilesOnGrid(_Files);
			}
		}
		private void showFilesOnGrid(List<FileStructure> files)
		{
			if (files != null)
			{
				changeStepColor(this.btnStep2, false, Color.DarkSeaGreen, Color.White);
				btnMerge.Enabled = true;
				changeStepColor(this.btnMerge, false, Color.SteelBlue, Color.White);
				lblStatus.Text = string.Format("Status : {0} files are ready to merge.", files.Count());
				lblInstruction.Text = "(Edit Page Order)";
				this.dataGridView1.DataSource = files.OrderBy(o => o.Order).ToList();
			}
		}
		private void btnMerge_Click(object sender, EventArgs e)
		{
			DialogResult dr = this.saveFileDialog1.ShowDialog();
			if (dr == System.Windows.Forms.DialogResult.OK)
			{
				if (!isValid()) return;

				string path = this.saveFileDialog1.InitialDirectory;
				var newFileName = this.saveFileDialog1.FileName;
				string[] files = _Files.OrderBy(o => o.Order).ThenBy(f => f.FileName).Select(x => x.Filepath).ToArray();

				PdfDocumentBase doc = PdfDocument.MergeFiles(files);
				if (File.Exists(newFileName))
				{
					File.Delete(newFileName);
				}
				doc.Save(newFileName, FileFormat.PDF);
				changeStepColor(this.btnStep3, false, Color.DarkSeaGreen, Color.White);
				lblSuccess.Visible = true;
				lblStatus.Text = "Status : Files merged and saved";
				if (this.chkOpen.Checked) Process.Start(newFileName);
			}
		}
		private bool isValid()
		{
			string status = string.Empty;
			if (_Files.Count <= 1)
			{
				status = "Please select at least two files to merge.";

			}
			if (!this.saveFileDialog1.FileName.Contains(".pdf"))
			{
				status = status + "\n Please select valid file type.";
			}
			if(!string.IsNullOrEmpty(status))
			{
				lblStatus.Text = status;
				return false;
			}
			return true;
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			clear();
		}
		private void clear()
		{
			this.dataGridView1.DataSource = null;
			index = 1;
			_Files = new List<FileStructure>();
			lblStatus.Text = "Status :";
			lblInstruction.Text = string.Empty;
			changeStepColor(this.btnStep2, true, Color.LightGray, Color.DimGray);
			changeStepColor(this.btnStep3, true, Color.LightGray, Color.DimGray);
			changeStepColor(this.btnMerge, true, Color.LightGray, Color.DimGray);
			lblSuccess.Visible = false;
			this.btnMerge.Enabled = false;
		}
		private void changeStepColor(Button btn, bool reset, Color backColor, Color foreColor)
		{
			if(!reset)
			{
				btn.BackColor = Color.DarkSeaGreen;
				btn.ForeColor = Color.White;

			}
			else
			{
				btn.BackColor = backColor;
				btn.ForeColor = foreColor;
			}
		}
	}
	public class FileStructure
	{
		public string FileName { get; set; }
		public string Filepath { get; set; }
		public int Order { get; set; }
	}
}
