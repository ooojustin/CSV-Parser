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

    public partial class SumColumn : Form {

        private Main parent;

        public SumColumn(Main parent) {

            InitializeComponent();

            this.parent = parent;

        }

        private void SumColumn_Load(object sender, EventArgs e) {

            // add numeric columns to combobox
            foreach (KeyValuePair<string, int> column in Data.SelectedColumns) {
                string columnName = column.Key;
                if (Data.IsColumnNumeric(columnName))
                    cmbColumns.Items.Add(columnName);
            }

            // make sure there's at least 1 numeric column
            if (cmbColumns.Items.Count == 0) {
                MessageBox.Show("failed to detect any numeric columns.", "csv parser", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

            // select first column by default
            cmbColumns.SelectedIndex = 0;

        }

        private void btnCreateCondition_Click(object sender, EventArgs e) {

            string columnName = cmbColumns.SelectedItem.ToString();
            int columnIndex = Data.SelectedColumns[columnName];

            double sum = 0;
            foreach (DataRow row in parent.data.Rows) {
                string raw = row[columnIndex] as string;
                sum += Convert.ToDouble(raw);
            }

            MessageBox.Show("sum evaluated: " + sum, "csv parser", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }
    }

}
