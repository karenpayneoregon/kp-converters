using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNetCoreApp1
{
    public class DataOperations
    {
        public static DataTable GetDataTable()
        {
            DataTable table = new ();

            table.Columns.Add(new DataColumn() { ColumnName = "Id", DataType = typeof(int) });
            table.Columns.Add(new DataColumn() { ColumnName = "FirstName", DataType = typeof(string) });
            table.Columns.Add(new DataColumn() { ColumnName = "LastName", DataType = typeof(string) });

            table.Rows.Add(1, "Karen", "Payne");

            return table;
        }
    }
}
