namespace CSV_Parser {
    partial class SumColumn {
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
            this.cmbColumns = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateCondition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbColumns
            // 
            this.cmbColumns.BackColor = System.Drawing.Color.Black;
            this.cmbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbColumns.ForeColor = System.Drawing.Color.White;
            this.cmbColumns.FormattingEnabled = true;
            this.cmbColumns.Location = new System.Drawing.Point(37, 37);
            this.cmbColumns.Name = "cmbColumns";
            this.cmbColumns.Size = new System.Drawing.Size(313, 21);
            this.cmbColumns.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "select a cloumn to evaluate:";
            // 
            // btnCreateCondition
            // 
            this.btnCreateCondition.BackColor = System.Drawing.Color.Black;
            this.btnCreateCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCondition.Location = new System.Drawing.Point(37, 75);
            this.btnCreateCondition.Name = "btnCreateCondition";
            this.btnCreateCondition.Size = new System.Drawing.Size(313, 31);
            this.btnCreateCondition.TabIndex = 8;
            this.btnCreateCondition.Text = "evaluate";
            this.btnCreateCondition.UseVisualStyleBackColor = false;
            this.btnCreateCondition.Click += new System.EventHandler(this.btnCreateCondition_Click);
            // 
            // SumColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(384, 133);
            this.Controls.Add(this.btnCreateCondition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbColumns);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SumColumn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "csv parser - sum column";
            this.Load += new System.EventHandler(this.SumColumn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateCondition;
    }
}