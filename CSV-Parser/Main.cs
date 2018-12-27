using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Parser {

    public partial class Main : Form {

        DataTable data = new DataTable();

        public Main() {

            InitializeComponent();
            dataGrid.DataSource = data;

            Text = string.Format(Text, Data.FileName, Data.SelectedRows.Count);

            // add columns to data table
            foreach (KeyValuePair<string, int> column in Data.SelectedColumns)
                data.Columns.Add(column.Key, typeof(string));

            UpdateRows();

        }

        private void UpdateRows() {

            data.Clear();

            foreach (string[] rowData in Data.SelectedRows) {

                DataRow row = data.NewRow();

                for (int i = 0; i < Data.SelectedColumns.Count; i++)
                    row[i] = rowData[i];

                data.Rows.Add(row);

            }

        }

    }

}
