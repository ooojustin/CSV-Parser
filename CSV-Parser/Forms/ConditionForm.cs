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

    public partial class ConditionForm : Form {

        public ConditionForm() {

            InitializeComponent();

            foreach (KeyValuePair<string, int> column in Data.SelectedColumns) {
                cmbValue1.Items.Add(column.Key);
                cmbValue2.Items.Add(column.Key);
            }
            cmbValue2.Items.Add("Custom");

            cmbValue1.SelectedIndexChanged += (s, e) => ActiveControl = null;
            cmbCondition.SelectedIndexChanged += (s, e) => ActiveControl = null;
            cmbValue2.SelectedIndexChanged += (s, e) => ActiveControl = null;

            cmbValue1.SelectedIndex = 0;

        }

        private void Value1_Changed(object sender, EventArgs e) {

            int columnIndex = Data.SelectedColumns[cmbValue1.SelectedItem.ToString()];
            string sampleData = Data.Rows.First()[columnIndex];

            double sampleDouble = Double.NaN;
            bool isNumeric = Double.TryParse(sampleData, out sampleDouble);

            cmbCondition.Items.Clear();

            if (isNumeric) {
                int maxValue = (int) ConditionExtensions.GetMaxValue<ModeNumeric>();
                for (int i = 0; i <= maxValue; i++) {
                    ModeNumeric mode = (ModeNumeric)i;
                    cmbCondition.Items.Add(mode.GetString());
                }
            } else {
                int maxValue = (int)ConditionExtensions.GetMaxValue<Mode>();
                for (int i = 0; i <= maxValue; i++) {
                    Mode mode = (Mode)i;
                    cmbCondition.Items.Add(mode.GetString());
                }
            }

            cmbCondition.SelectedIndex = 0;

        }

    }

}
