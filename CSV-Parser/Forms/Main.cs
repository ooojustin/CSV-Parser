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

    // column name 1, column name 2 (or custom value), mode
    using StandardCondition = Tuple<string, string, Mode>;
    using NumericCondition = Tuple<string, string, ModeNumeric>;

    public partial class Main : Form {

        DataTable data = new DataTable();

        List<StandardCondition> standardConditions = new List<StandardCondition>();
        List<NumericCondition> numericConditions = new List<NumericCondition>();


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

            for (int x = 0; x < Data.Rows.Count; x++) {

                string[] rowData = Data.Rows[x];
                bool evaluate = true;

                // evaluate standard conditions
                foreach (StandardCondition condition in standardConditions) {

                    string value1 = rowData[Data.SelectedColumns[condition.Item1]];
                    string value2 = condition.Item2;

                    if (Data.SelectedColumns.ContainsKey(condition.Item2))
                        value2 = rowData[Data.SelectedColumns[condition.Item2]];

                    Condition c = new Condition(value1, value2, condition.Item3);
                    if (!c.Evaluate()) {
                        evaluate = false;
                        break;
                    }

                }

                // evaluate numeric conditions
                foreach (NumericCondition condition in numericConditions) {

                    string value1 = rowData[Data.SelectedColumns[condition.Item1]];
                    string value2 = condition.Item2;

                    if (Data.SelectedColumns.ContainsKey(condition.Item2))
                        value2 = rowData[Data.SelectedColumns[condition.Item2]];


                    Condition c = new Condition(Convert.ToDouble(value1), Convert.ToDouble(value2), condition.Item3);
                    if (!c.Evaluate()) {
                        evaluate = false;
                        break;
                    }

                }

                if (!evaluate)
                    continue;

                DataRow row = data.NewRow();

                for (int y = 0; y < Data.SelectedColumns.Count; y++)
                    row[y] = Data.SelectedRows[x][y];

                data.Rows.Add(row);

            }

        }

        private void CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {

            DataGridViewRow row = dataGrid.Rows[e.RowIndex];

            row.DefaultCellStyle.BackColor = Color.Black;
            row.DefaultCellStyle.SelectionBackColor = Color.Magenta;

        }

        private void btnAddCondition_Click(object sender, EventArgs e) {

            ConditionForm form = new ConditionForm();
            DialogResult result = form.ShowDialog(this);

            if (result == DialogResult.OK) {

                if (form.IsNumeric) {
                    NumericCondition condition = new NumericCondition(form.Value1, form.Value2, form.ConditionMode_Numeric);
                    numericConditions.Add(condition);
                    lbConditions.Items.Add(condition.Item1 + " [" + condition.Item3.GetString() + "] " + condition.Item2);
                } else {
                    StandardCondition condition = new StandardCondition(form.Value1, form.Value2, form.ConditionMode);
                    standardConditions.Add(condition);
                    lbConditions.Items.Add(condition.Item1 + " [" + condition.Item3.GetString() + "] " + condition.Item2);
                }

                UpdateRows();

            }

        }

    }

}
