using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateScriptGenerator
{
	public class TableEntry
	{
		public string Name { get; set; }
		public OracleType Type { get; set; }
		public bool PK { get; set; }
		public bool Nullable { get; set; }
		public TableEntry Reference { get; set; }
		public string TableName { get; set; }

		public TableEntry(string name, OracleType type, bool pk, bool nullable)
		{
			this.Name = name;
			this.Type = type;
			this.PK = pk;
			this.Nullable = nullable;
		}

		public TableEntry(string name, OracleType type, bool pk, bool nullable, TableEntry reference)
		{
			this.Reference = reference;
			this.Name = name;
			this.Type = type;
			this.PK = pk;
			this.Nullable = nullable;
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
}
