﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Parser {


    public partial class Main : Form {

        public DataTable data = new DataTable();
        public List<Condition> conditions = new List<Condition>();

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
                if (!rowData.Evaluates(conditions))
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
           
                Condition c = new Condition();
                c.IsCustom = form.IsCustom;
                c.IsNumeric = form.IsNumeric;
                c.IsDate = form.IsDate;
                c.Value1 = form.Value1;
                c.Value2 = form.Value2;
                if (c.IsNumeric)
                    c.ConditionMode_Numeric = form.ConditionMode_Numeric;
                else if (c.IsDate)
                    c.ConditionMode_Date = form.ConditionMode_Date;
                else
                    c.ConditionMode = form.ConditionMode;

                lbConditions.Items.Add(c.GetDescription());
                conditions.Add(c);

                UpdateRows();

            }

        }

        private void btnRemoveCondition_Click(object sender, EventArgs e) {

            int index = lbConditions.SelectedIndex;
            if (index == -1)
                return;

            lbConditions.Items.RemoveAt(index);
            conditions.RemoveAt(index);

            UpdateRows();

        }

        private void btnSumColumn_Click(object sender, EventArgs e) {
            new SumColumn(this).Show();
        }

        private void btnExportData_Click(object sender, EventArgs e) {

            StringBuilder builder = new StringBuilder();

            // add column names
            foreach (var column in Data.SelectedColumns)
                builder.Append(column.Key + ",");
            NextLine(builder);

            // add column data
            foreach (string[] row in Data.SelectedRows) {
                if (!row.Evaluates(conditions))
                    continue;
                foreach (string column in row)
                    builder.Append(column + ",");
                NextLine(builder);
            }

            File.WriteAllText("exported.csv", builder.ToString());
            MessageBox.Show("Data exported to exported.csv", "CSV Parser", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private static void NextLine(StringBuilder builder) {
            builder.Remove(builder.Length - 1, 1);
            builder.AppendLine();
        }

        // original window size: 959, 823
        // original data grid size: 917, 601
        private void Main_Resize(object sender, EventArgs e) {
            int widthDelta = Size.Width - 959;
            int heightDelta = Size.Height - 823;
            pnlDataGrid.Size = new Size(917 + widthDelta, 601 + heightDelta);
        }

    }

}
