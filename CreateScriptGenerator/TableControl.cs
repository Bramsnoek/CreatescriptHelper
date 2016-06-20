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
	public partial class TableControl : UserControl
	{
		public List<Entry> Entries { get; set; }

		private int locX;
		private int locY;
		private string tablename;

		public TableControl(string tableName)
		{
			InitializeComponent();

			locX = 3;
			locY = 28;
			this.tablename = tableName;

			Entries = new List<Entry>();
			btnAdd.PerformClick();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Entry newEntry = new Entry(tablename);
			newEntry.Location = new Point(locX, locY);
			this.Controls.Add(newEntry);

			Entries.Add(newEntry);

			locY += 28;
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.Control | Keys.Shift | Keys.E))
			{
				btnAdd.PerformClick();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}
