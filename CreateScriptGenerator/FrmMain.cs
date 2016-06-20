using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateScriptGenerator
{
	public partial class FrmMain : Form
	{
		private TableCollector tableCollecter;

		public FrmMain()
		{
			InitializeComponent();

			tableCollecter = new TableCollector();
			tbPages.Selecting += TbPages_Selecting;
			this.KeyPreview = true;
		}

		private void TbPages_Selecting(object sender, TabControlCancelEventArgs e)
		{
			BindTableEntries();
		}

		private void btnAddTable_Click(object sender, EventArgs e)
		{
			if (txtTableName.Text != null)
			{
				TableControl tableControl = new TableControl(txtTableName.Text);
				tableControl.Location = new Point(0, 0);

				Table table = new Table(txtTableName.Text, new TabPage(txtTableName.Text), tableControl);
				tbPages.TabPages.Add(table.Page);
				TableCollector.tables.Add(table);
				txtTableName.Clear();

				UpdateEntryComs();
			}

			else
				MessageBox.Show("Please fill in a table name!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void UpdateEntryComs()
		{
			foreach (Table table in TableCollector.tables)
			{
				foreach (Entry entry in table.UiTable.Entries)
				{
					entry.UpdateComs();
				}
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			BindTableEntries();
			tableCollecter.Generate();
		}

		private void BindTableEntries()
		{
			foreach (Table table in TableCollector.tables)
			{
				table.Entries.Clear();
				foreach (Entry entry in table.UiTable.Entries)
				{
					TableEntry newEntry = entry.GetEntry();
					newEntry.TableName = table.ToString();
					table.Entries.Add(newEntry);
				}
			}
		}

		private void btnDir_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			DialogResult result = fbd.ShowDialog();

			if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
			{
				txtDir.Text = fbd.SelectedPath;
				TableCollector.dirPath = txtDir.Text;
			}
		}
	}
}
