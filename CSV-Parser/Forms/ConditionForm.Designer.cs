namespace CSV_Parser {
    partial class ConditionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbValue1 = new System.Windows.Forms.ComboBox();
            this.cmbValue2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateCondition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "value 1:";
            // 
            // cmbCondition
            // 
            this.cmbCondition.BackColor = System.Drawing.Color.Black;
            this.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondition.ForeColor = System.Drawing.Color.White;
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Location = new System.Drawing.Point(25, 88);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(376, 21);
            this.cmbCondition.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "condition:";
            // 
            // cmbValue1
            // 
            this.cmbValue1.BackColor = System.Drawing.Color.Black;
            this.cmbValue1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValue1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbValue1.ForeColor = System.Drawing.Color.White;
            this.cmbValue1.FormattingEnabled = true;
            this.cmbValue1.Location = new System.Drawing.Point(25, 36);
            this.cmbValue1.Name = "cmbValue1";
            this.cmbValue1.Size = new System.Drawing.Size(376, 21);
            this.cmbValue1.TabIndex = 4;
            this.cmbValue1.SelectedIndexChanged += new System.EventHandler(this.Value1_Changed);
            // 
            // cmbValue2
            // 
            this.cmbValue2.BackColor = System.Drawing.Color.Black;
            this.cmbValue2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValue2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbValue2.ForeColor = System.Drawing.Color.White;
            this.cmbValue2.FormattingEnabled = true;
            this.cmbValue2.Location = new System.Drawing.Point(25, 143);
            this.cmbValue2.Name = "cmbValue2";
            this.cmbValue2.Size = new System.Drawing.Size(376, 21);
            this.cmbValue2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "value 2:";
            // 
            // btnCreateCondition
            // 
            this.btnCreateCondition.BackColor = System.Drawing.Color.Black;
            this.btnCreateCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCondition.Location = new System.Drawing.Point(25, 185);
            this.btnCreateCondition.Name = "btnCreateCondition";
            this.btnCreateCondition.Size = new System.Drawing.Size(376, 31);
            this.btnCreateCondition.TabIndex = 7;
            this.btnCreateCondition.Text = "create condition";
            this.btnCreateCondition.UseVisualStyleBackColor = false;
            // 
            // ConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(427, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateCondition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbValue1);
            this.Controls.Add(this.cmbValue2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCondition);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ConditionForm";
            this.Text = "csv parser - add condition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbValue1;
        private System.Windows.Forms.ComboBox cmbValue2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateCondition;
    }
}