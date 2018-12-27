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

        public Mode ConditionMode;
        public ModeNumeric ConditionMode_Numeric;

        public bool IsNumeric = false;
        public bool IsCustom = false;

        public string Value1 = string.Empty;
        public string Value2 = string.Empty;

        public ConditionForm() {

            InitializeComponent();

            // add value types
            foreach (KeyValuePair<string, int> column in Data.SelectedColumns)
                cmbValue1.Items.Add(column.Key);
            
            // allow custom values
            cmbValue2.Items.Add("Custom");

            cmbValue1.SelectedIndexChanged += (s, e) => ActiveControl = null;
            cmbCondition.SelectedIndexChanged += (s, e) => ActiveControl = null;
            cmbValue2.SelectedIndexChanged += (s, e) => ActiveControl = null;

            cmbValue1.SelectedIndex = 0;

        }

        private void Value1_Changed(object sender, EventArgs e) {

            // check if it's numeric
            string columnName = cmbValue1.SelectedItem.ToString();
            IsNumeric = IsColumnNumeric(columnName);

            // clear conditions & second values
            cmbCondition.Items.Clear();
            cmbValue2.Items.Clear();

            // re-add conditions based on whether or not the column contains numeric values
            if (IsNumeric) {
                int maxValue = (int) ConditionExtensions.GetMaxValue<ModeNumeric>();
                for (int i = 0; i <= maxValue; i++) {
                    ModeNumeric mode = (ModeNumeric)i;
                    cmbCondition.Items.Add(mode.GetString());
                }
                foreach (KeyValuePair<string, int> column in Data.SelectedColumns)
                    if (IsColumnNumeric(column.Key))
                        cmbValue2.Items.Add(column.Key);
            } else {
                int maxValue = (int)ConditionExtensions.GetMaxValue<Mode>();
                for (int i = 0; i <= maxValue; i++) {
                    Mode mode = (Mode)i;
                    cmbCondition.Items.Add(mode.GetString());
                }
                foreach (KeyValuePair<string, int> column in Data.SelectedColumns)
                    cmbValue2.Items.Add(column.Key);
            }

            cmbValue2.Items.Add("Custom");
            cmbCondition.SelectedIndex = 0;

        }

        private bool IsColumnNumeric(string name) {
            int columnIndex = Data.SelectedColumns[name];
            string sampleData = Data.Rows.First()[columnIndex];
            return sampleData.IsNumeric();
        }

        private void Value2_Changed(object sender, EventArgs e) {

            // determine whether or not they want to use a custom value
            int lastIndex = cmbValue2.Items.Count - 1;
            bool isCustom = cmbValue2.SelectedIndex == lastIndex;

            if (isCustom) {
                txtCustomValue.Visible = true;
                cmbValue2.Size = new Size(139, 21);
            } else {
                txtCustomValue.Visible = false;
                cmbValue2.Size = new Size(376, 21);
            }

        }

        private void btnCreateCondition_Click(object sender, EventArgs e) {

            // set value 1
            Value1 = cmbValue1.SelectedItem.ToString();

            // set value 2 (and ensure its numeric, if condition is numeric)
            IsCustom = IsCustomValue();
            if (IsCustom) {
                Value2 = txtCustomValue.Text;
                if (IsNumeric && !Value2.IsNumeric()) {
                    MessageBox.Show("custom value must be numeric.", "CSV Parser", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            } else
                Value2 = cmbValue2.SelectedItem.ToString();

            // establish condition mode
            if (IsNumeric)
                ConditionMode_Numeric = (ModeNumeric) cmbCondition.SelectedIndex;
            else
                ConditionMode = (Mode) cmbCondition.SelectedIndex;

            DialogResult = DialogResult.OK;
            Close();

        }

        private bool IsCustomValue() {
            int lastIndex = cmbValue2.Items.Count - 1;
            bool isCustom = cmbValue2.SelectedIndex == lastIndex;
            return isCustom;
        }

    }

}
