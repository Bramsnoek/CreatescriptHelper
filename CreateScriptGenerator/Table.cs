using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateScriptGenerator
{
	public class Table
	{
		public TabPage Page { get; set; }
		public TableControl UiTable { get; set; }
		public string Name { get; set; }
		public List<TableEntry> Entries { get; set; }

		public Table(string name, TabPage page, TableControl uiTable)
		{
			this.Page = page;
			this.UiTable = uiTable;
			this.Name = name;
			this.Entries = new List<TableEntry>();

			page.Controls.Add(UiTable);
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
}
