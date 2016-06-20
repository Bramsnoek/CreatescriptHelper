using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateScriptGenerator
{
	public class TableCollector
	{
		public static List<Table> tables;
		public static string dirPath;

		public TableCollector()
		{
			tables = new List<Table>();
		}

		public void Generate()
		{
			File.Create("Createscript.sql").Dispose();

			foreach(Table table in tables)
			{
				AppendTableToFile(table);
			}
		}	

		private void AppendTableToFile(Table table)
		{
			using (StreamWriter fileWriter = File.AppendText(dirPath + "/Createscript.sql"))
			{
				fileWriter.Write(@"CREATE TABLE " + table.ToString());
				fileWriter.Write(Environment.NewLine);
				fileWriter.Write(@"(");

				foreach(TableEntry entry in table.Entries)
				{
					fileWriter.Write("Drop Table " + entry.TableName + " Cascade Constraints;");
					string nullable = entry.Nullable ? "NOT NULL" : "";
					string pk = entry.PK ? "PRIMARY KEY" : "";
					string references = entry.Reference != null ? "References " + entry.Reference.TableName + "(" + entry.Reference.Name + ")" : "";
					string comma = table.Entries.IndexOf(entry) + 1 == table.Entries.Count ? "" : ",";
					string fieldName = GetFieldName(entry.Type);


					fileWriter.Write(Environment.NewLine + "	");
					fileWriter.Write(entry.Name + " " + fieldName + " " + nullable + " " + pk + " " + references + comma);
				}

				fileWriter.Write(Environment.NewLine);
				fileWriter.Write(@");");
				fileWriter.Write(Environment.NewLine);
			}
		}

		private string GetFieldName(OracleType type)
		{
			switch (type)
			{
				case OracleType.Varchar2:
					return "Varchar2(255)";
				case OracleType.Date:
					return "Date";
				case OracleType.Number:
					return "Number";
				case OracleType.Decimal:
					return "Decimal";
				case OracleType.Timestamp:
					return "TimeStamp";
				case OracleType.Char:
					return "Char";
				case OracleType.Byte:
					return "Byte";
				case OracleType.NVarchar2:
					return "NVarchar2";
			}
			return "";
		}
	}
}
