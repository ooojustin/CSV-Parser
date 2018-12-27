using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Parser {

    public static class Data {

        public static Dictionary<string, int> SelectedColumns;
        public static List<string> Columns;

        public static List<string[]> SelectedRows;
        public static List<string[]> Rows;

        public static string[] SelectedData(this string[] row) {

            string[] data = new string[SelectedColumns.Count];
            int index = 0;

            for (int columnIndex = 0; columnIndex < row.Length; columnIndex++) {

                // make sure it's in our SelectedColumns
                string column = Columns[columnIndex];
                if (!SelectedColumns.ContainsKey(column))
                    continue;

                // get the real index
                int realColumnIndex = SelectedColumns[column];

                // store in array and increment index
                data[index] = row[realColumnIndex];
                index++;

            }

            return data;

        }

    }

}
