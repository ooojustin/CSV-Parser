namespace CSV_Parser {
    partial class Main {
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lbConditions = new System.Windows.Forms.ListBox();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCondition = new System.Windows.Forms.Button();
            this.btnRemoveCondition = new System.Windows.Forms.Button();
            this.pnlConditions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSumColumn = new System.Windows.Forms.Button();
            this.btnExportData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.pnlDataGrid.SuspendLayout();
            this.pnlConditions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.Black;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.GridColor = System.Drawing.Color.Black;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(917, 601);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CellFormatting);
            // 
            // lbConditions
            // 
            this.lbConditions.BackColor = System.Drawing.Color.Black;
            this.lbConditions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbConditions.ForeColor = System.Drawing.Color.White;
            this.lbConditions.FormattingEnabled = true;
            this.lbConditions.Location = new System.Drawing.Point(0, 0);
            this.lbConditions.Name = "lbConditions";
            this.lbConditions.Size = new System.Drawing.Size(384, 136);
            this.lbConditions.TabIndex = 1;
            // 
            // panel1
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.Black;
            this.pnlDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataGrid.Controls.Add(this.dataGrid);
            this.pnlDataGrid.Location = new System.Drawing.Point(12, 169);
            this.pnlDataGrid.Name = "panel1";
            this.pnlDataGrid.Size = new System.Drawing.Size(919, 603);
            this.pnlDataGrid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "conditions:";
            // 
            // btnAddCondition
            // 
            this.btnAddCondition.BackColor = System.Drawing.Color.Black;
            this.btnAddCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCondition.Location = new System.Drawing.Point(404, 26);
            this.btnAddCondition.Name = "btnAddCondition";
            this.btnAddCondition.Size = new System.Drawing.Size(116, 66);
            this.btnAddCondition.TabIndex = 4;
            this.btnAddCondition.Text = "add condition";
            this.btnAddCondition.UseVisualStyleBackColor = false;
            this.btnAddCondition.Click += new System.EventHandler(this.btnAddCondition_Click);
            // 
            // btnRemoveCondition
            // 
            this.btnRemoveCondition.BackColor = System.Drawing.Color.Black;
            this.btnRemoveCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCondition.Location = new System.Drawing.Point(404, 98);
            this.btnRemoveCondition.Name = "btnRemoveCondition";
            this.btnRemoveCondition.Size = new System.Drawing.Size(116, 66);
            this.btnRemoveCondition.TabIndex = 5;
            this.btnRemoveCondition.Text = "remove condition";
            this.btnRemoveCondition.UseVisualStyleBackColor = false;
            this.btnRemoveCondition.Click += new System.EventHandler(this.btnRemoveCondition_Click);
            // 
            // pnlConditions
            // 
            this.pnlConditions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConditions.Controls.Add(this.lbConditions);
            this.pnlConditions.Location = new System.Drawing.Point(12, 26);
            this.pnlConditions.Name = "pnlConditions";
            this.pnlConditions.Size = new System.Drawing.Size(386, 138);
            this.pnlConditions.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(530, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 154);
            this.label1.TabIndex = 7;
            // 
            // btnSumColumn
            // 
            this.btnSumColumn.BackColor = System.Drawing.Color.Black;
            this.btnSumColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumColumn.Location = new System.Drawing.Point(541, 26);
            this.btnSumColumn.Name = "btnSumColumn";
            this.btnSumColumn.Size = new System.Drawing.Size(140, 37);
            this.btnSumColumn.TabIndex = 8;
            this.btnSumColumn.Text = "sum column";
            this.btnSumColumn.UseVisualStyleBackColor = false;
            this.btnSumColumn.Click += new System.EventHandler(this.btnSumColumn_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.BackColor = System.Drawing.Color.Black;
            this.btnExportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportData.Location = new System.Drawing.Point(541, 69);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(140, 37);
            this.btnExportData.TabIndex = 9;
            this.btnExportData.Text = "export data";
            this.btnExportData.UseVisualStyleBackColor = false;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(943, 784);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.btnSumColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlConditions);
            this.Controls.Add(this.btnRemoveCondition);
            this.Controls.Add(this.btnAddCondition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlDataGrid);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(714, 388);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "csv parser - {0} - {1} rows";
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.pnlDataGrid.ResumeLayout(false);
            this.pnlConditions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCondition;
        private System.Windows.Forms.Button btnRemoveCondition;
        private System.Windows.Forms.ListBox lbConditions;
        private System.Windows.Forms.Panel pnlConditions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSumColumn;
        private System.Windows.Forms.Button btnExportData;
    }
}