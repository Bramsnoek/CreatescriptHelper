using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateScriptGenerator
{
	public enum OracleType
	{
		Varchar2,
		Date,
		Number,
		Decimal,
		Timestamp,
		Char,
		Byte,
		NVarchar2
	}
	public partial class Entry : UserControl
	{
		public TableEntry TableEntry { get; set; }

		private string tablename;
		public Entry(string tableName)
		{
			InitializeComponent();
			this.tablename = tableName;
			UpdateComs();
		}

		private void ComTable_SelectedIndexChanged(object sender, EventArgs e)
		{
			comEntries.Items.Clear();
			Table selectedTable = TableCollector.tables.Find(x => x.Name == comTable.Items[comTable.SelectedIndex].ToString());
			foreach (Entry entry in selectedTable.UiTable.Entries)
			{
				TableEntry currentEntry = entry.GetEntry();

				if (currentEntry.PK)
					comEntries.Items.Add(entry.GetEntry().ToString());
			}
		}

		public void UpdateComs()
		{
			comEntries.Items.Clear();
			comTable.Items.Clear();
			comType.Items.Clear();

			foreach (OracleType type in Enum.GetValues(typeof(OracleType)))
			{
				comType.Items.Add(type.ToString());
			}

			foreach (Table table in TableCollector.tables.Where(x => x.Name != this.tablename))
			{
				comTable.Items.Add(table.ToString());
			}

			comTable.SelectedIndexChanged += ComTable_SelectedIndexChanged;
			comType.SelectedIndex = 0;
		}

		public TableEntry GetEntry()
		{
			TableEntry boundedEntry = null;

			if (comEntries.SelectedItem == null)
			{
				boundedEntry = new TableEntry(
				textName.Text,
				(OracleType)comType.SelectedIndex,
				cbPrimarykey.Checked,
				cbNullable.Checked);
			}
			else
			{
				TableEntry selectedEntry = null;

				try
				{
					foreach (Table table in TableCollector.tables.Where(x => x.Name == comTable.Items[comTable.SelectedIndex].ToString()))
					{
						foreach (Entry entry in table.UiTable.Entries.Where(x => x.TableEntry.Name == comEntries.Items[comEntries.SelectedIndex].ToString()))
						{
							selectedEntry = entry.TableEntry;
							selectedEntry.TableName = table.ToString();
						}
					}
				}
				catch(NullReferenceException ex)
				{
					Console.WriteLine(ex);
				}


				boundedEntry = new TableEntry(
				textName.Text,
				(OracleType)comType.SelectedIndex,
				cbPrimarykey.Checked,
				cbNullable.Checked,
				selectedEntry);
			}

			this.TableEntry = boundedEntry;
			return TableEntry;
		}

		private void cbPrimarykey_CheckedChanged(object sender, EventArgs e)
		{
			if (cbPrimarykey.Checked)
			{
				comEntries.SelectedItem = null;
				comTable.SelectedItem = null;
				comTable.SelectedIndex = -1;
				comEntries.SelectedIndex = -1;
				cbNullable.Checked = false;

				cbNullable.Enabled = false;
				comEntries.Enabled = false;
				comTable.Enabled = false;
			}
			else
			{
				cbNullable.Enabled = true;
				comEntries.Enabled = true;
				comTable.Enabled = true;
			}
		}

		private void cbNullable_CheckedChanged(object sender, EventArgs e)
		{
			if (cbNullable.Checked)
			{
				cbPrimarykey.Checked = false;
				cbPrimarykey.Enabled = false;
			}
			else
			{
				cbPrimarykey.Enabled = true;
			}
		}
	}
}
