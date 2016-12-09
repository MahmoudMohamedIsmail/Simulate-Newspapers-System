namespace SimulationTask2_NewspapperSeller
{
    partial class Output
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SimTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalCostofNewspapers = new System.Windows.Forms.TextBox();
            this.NumberOfDaysHavingUnsoldPapers = new System.Windows.Forms.TextBox();
            this.Numberofdayshavingexcessdemand = new System.Windows.Forms.TextBox();
            this.TotalLostProfitFromExcessDemand = new System.Windows.Forms.TextBox();
            this.TotalSalvagefromSaleOfscrapPapers = new System.Windows.Forms.TextBox();
            this.TotalRevenuefromSales = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SimTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 447);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation Table";
            // 
            // SimTable
            // 
            this.SimTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.SimTable.Location = new System.Drawing.Point(6, 19);
            this.SimTable.Name = "SimTable";
            this.SimTable.Size = new System.Drawing.Size(924, 422);
            this.SimTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DayNo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Random DigitFor type Of Newsday";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type of Newsday ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Random Digits for Demand";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Demand";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Revenue From Sales";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Last Profit";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Salvage From sale of scrap";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Daily Profit";
            this.Column9.Name = "Column9";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TotalCostofNewspapers);
            this.groupBox2.Controls.Add(this.NumberOfDaysHavingUnsoldPapers);
            this.groupBox2.Controls.Add(this.Numberofdayshavingexcessdemand);
            this.groupBox2.Controls.Add(this.TotalLostProfitFromExcessDemand);
            this.groupBox2.Controls.Add(this.TotalSalvagefromSaleOfscrapPapers);
            this.groupBox2.Controls.Add(this.TotalRevenuefromSales);
            this.groupBox2.Location = new System.Drawing.Point(137, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of days having unsold papers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of days having excess demand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TotalSalvagefromSaleOfscrapPapers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Lost Profit from Excess Demand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Cost of Newspapers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Revenue from Sales";
            // 
            // TotalCostofNewspapers
            // 
            this.TotalCostofNewspapers.Location = new System.Drawing.Point(523, 34);
            this.TotalCostofNewspapers.Name = "TotalCostofNewspapers";
            this.TotalCostofNewspapers.Size = new System.Drawing.Size(100, 20);
            this.TotalCostofNewspapers.TabIndex = 5;
            // 
            // NumberOfDaysHavingUnsoldPapers
            // 
            this.NumberOfDaysHavingUnsoldPapers.Location = new System.Drawing.Point(196, 16);
            this.NumberOfDaysHavingUnsoldPapers.Name = "NumberOfDaysHavingUnsoldPapers";
            this.NumberOfDaysHavingUnsoldPapers.Size = new System.Drawing.Size(100, 20);
            this.NumberOfDaysHavingUnsoldPapers.TabIndex = 4;
            // 
            // Numberofdayshavingexcessdemand
            // 
            this.Numberofdayshavingexcessdemand.Location = new System.Drawing.Point(523, 74);
            this.Numberofdayshavingexcessdemand.Name = "Numberofdayshavingexcessdemand";
            this.Numberofdayshavingexcessdemand.Size = new System.Drawing.Size(100, 20);
            this.Numberofdayshavingexcessdemand.TabIndex = 3;
            // 
            // TotalLostProfitFromExcessDemand
            // 
            this.TotalLostProfitFromExcessDemand.Location = new System.Drawing.Point(196, 41);
            this.TotalLostProfitFromExcessDemand.Name = "TotalLostProfitFromExcessDemand";
            this.TotalLostProfitFromExcessDemand.Size = new System.Drawing.Size(100, 20);
            this.TotalLostProfitFromExcessDemand.TabIndex = 2;
            // 
            // TotalSalvagefromSaleOfscrapPapers
            // 
            this.TotalSalvagefromSaleOfscrapPapers.Location = new System.Drawing.Point(196, 69);
            this.TotalSalvagefromSaleOfscrapPapers.Name = "TotalSalvagefromSaleOfscrapPapers";
            this.TotalSalvagefromSaleOfscrapPapers.Size = new System.Drawing.Size(100, 20);
            this.TotalSalvagefromSaleOfscrapPapers.TabIndex = 1;
            // 
            // TotalRevenuefromSales
            // 
            this.TotalRevenuefromSales.Location = new System.Drawing.Point(363, 33);
            this.TotalRevenuefromSales.Name = "TotalRevenuefromSales";
            this.TotalRevenuefromSales.Size = new System.Drawing.Size(100, 20);
            this.TotalRevenuefromSales.TabIndex = 0;
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Output";
            this.Text = "Output";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SimTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView SimTable;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TotalCostofNewspapers;
        public System.Windows.Forms.TextBox NumberOfDaysHavingUnsoldPapers;
        public System.Windows.Forms.TextBox Numberofdayshavingexcessdemand;
        public System.Windows.Forms.TextBox TotalLostProfitFromExcessDemand;
        public System.Windows.Forms.TextBox TotalSalvagefromSaleOfscrapPapers;
        public System.Windows.Forms.TextBox TotalRevenuefromSales;
    }
}