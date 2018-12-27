using Microsoft.VisualBasic.FileIO;
using System;
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

    public partial class Start : Form {

        private string FilePath;
        private List<CheckBox> ColumnChecks;
        private Dictionary<string, int> Columns;

        public Start() {

            InitializeComponent();

            // don't allow horizontal scroll bar (not needed)
            pnlColumnList.HorizontalScroll.Enabled = false;
            pnlColumnList.HorizontalScroll.Visible = false;
            pnlColumnList.HorizontalScroll.Maximum = 0;

            // enable auto-scroll (allow for vertical scroll bar, if needed)
            pnlColumnList.AutoScroll = true;

        }

        private void Continue(object sender, EventArgs e) {

            // get a list of selected columns
            List<CheckBox> selectedColumns = SelectedColumns();
            if (selectedColumns.Count == 0) {
                Failed("Please select at least 1 column.");
                return;
            }

            // find their indexes and columnl name to add to list
            Columns = new Dictionary<string, int>();
            foreach (CheckBox selectedColumn in selectedColumns) {
                string name = selectedColumn.Text;
                int index = ColumnChecks.IndexOf(selectedColumn);
                Columns.Add(name, index);
                Console.WriteLine(name + " => " + index);
            }

        }

        private List<CheckBox> SelectedColumns() {

            List<CheckBox> checkedColumns = new List<CheckBox>();
            foreach (CheckBox cb in ColumnChecks)
                if (cb.Checked)
                    checkedColumns.Add(cb);

            return checkedColumns;

        }

        private void OnLoad(object sender, EventArgs e) {

            // make sure they've selected a csv file
            bool selected = SelectCSV();
            if (!selected) {
                Failed("Issue occurred while selecting .csv file.", true);
                return;
            }

            // parse information from csv
            using (TextFieldParser parser = new TextFieldParser(FilePath)) {

                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                if (parser.EndOfData) {
                    Failed("Unable to resolve .csv data columns.", true);
                    return;
                }

                // read the first row of data from the .csv file
                // this generally contains the column names
                string[] fields = parser.ReadFields();

                const int Y_PADDING = 5;
                const int X_OFFSET = 7;
                int Y_OFFSET = 7;

                ColumnChecks = new List<CheckBox>();

                for (int i = 0; i < fields.Length; i++) {

                    string field = fields[i];

                    // initialize checkbox component
                    CheckBox cb = new CheckBox();
                    cb.Location = new Point(X_OFFSET, Y_OFFSET);
                    cb.AutoSize = true;
                    cb.Text = field;

                    // add to panel and account for y offset/padding
                    ColumnChecks.Add(cb);
                    pnlColumnList.Controls.Add(cb);
                    Y_OFFSET += cb.Size.Height + Y_PADDING;

                }

            }

        }

        private bool SelectCSV() {

            // make sure they didn't cancel
            DialogResult result = ofd.ShowDialog();
            if (result != DialogResult.OK)
                return false;

            // make sure it exists
            string file = ofd.FileName;
            if (!File.Exists(file))
                return false;

            // make sure its a .csv file
            if (Path.GetExtension(file).ToLower() != ".csv")
                return false;

            // it's good :)
            FilePath = ofd.FileName;
            return true;

        }

        private void Failed(string reason, bool close = false) {
            MessageBox.Show(reason, "CSV Parser", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (close)
                Close();
        }

    }

}
