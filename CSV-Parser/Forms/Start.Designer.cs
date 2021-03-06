﻿namespace CSV_Parser {
    partial class Start {
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
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lblFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlColumnList = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.Filter = "CSV files (*.csv)|*.csv";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(61, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "file: {0}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "please select the columns you\'d like parse.";
            // 
            // pnlColumnList
            // 
            this.pnlColumnList.BackColor = System.Drawing.Color.Black;
            this.pnlColumnList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColumnList.Location = new System.Drawing.Point(15, 44);
            this.pnlColumnList.Name = "pnlColumnList";
            this.pnlColumnList.Size = new System.Drawing.Size(353, 377);
            this.pnlColumnList.TabIndex = 2;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Black;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Location = new System.Drawing.Point(15, 427);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(353, 27);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.Continue);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(380, 466);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.pnlColumnList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFile);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "csv parser - column selection";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlColumnList;
        private System.Windows.Forms.Button btnContinue;
    }
}

