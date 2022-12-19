
namespace WinformPetStore
{
    partial class frmStatistics
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
            this.dgvStatisticsList = new System.Windows.Forms.DataGridView();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dtkStart = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dtkEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lbBills = new System.Windows.Forms.Label();
            this.txtBills = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatisticsList
            // 
            this.dgvStatisticsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatisticsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatisticsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStatisticsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatisticsList.Enabled = false;
            this.dgvStatisticsList.Location = new System.Drawing.Point(0, 169);
            this.dgvStatisticsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStatisticsList.Name = "dgvStatisticsList";
            this.dgvStatisticsList.RowHeadersWidth = 51;
            this.dgvStatisticsList.RowTemplate.Height = 25;
            this.dgvStatisticsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatisticsList.Size = new System.Drawing.Size(959, 392);
            this.dgvStatisticsList.TabIndex = 1021;
            // 
            // lbStartDate
            // 
            this.lbStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStartDate.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbStartDate.Location = new System.Drawing.Point(322, 16);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(91, 22);
            this.lbStartDate.TabIndex = 1023;
            this.lbStartDate.Text = "Start date";
            // 
            // dtkStart
            // 
            this.dtkStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtkStart.Location = new System.Drawing.Point(418, 15);
            this.dtkStart.Name = "dtkStart";
            this.dtkStart.Size = new System.Drawing.Size(250, 22);
            this.dtkStart.TabIndex = 1024;
            // 
            // lbEndDate
            // 
            this.lbEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEndDate.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbEndDate.Location = new System.Drawing.Point(322, 74);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(83, 22);
            this.lbEndDate.TabIndex = 1025;
            this.lbEndDate.Text = "End date";
            // 
            // dtkEnd
            // 
            this.dtkEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtkEnd.Location = new System.Drawing.Point(418, 73);
            this.dtkEnd.Name = "dtkEnd";
            this.dtkEnd.Size = new System.Drawing.Size(250, 22);
            this.dtkEnd.TabIndex = 1026;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSearch.Location = new System.Drawing.Point(418, 115);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 46);
            this.btnSearch.TabIndex = 1027;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSort.Location = new System.Drawing.Point(832, 115);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(115, 46);
            this.btnSort.TabIndex = 1032;
            this.btnSort.Text = "SORT BY TOTAL";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lbBills
            // 
            this.lbBills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBills.AutoSize = true;
            this.lbBills.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBills.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbBills.Location = new System.Drawing.Point(823, 16);
            this.lbBills.Name = "lbBills";
            this.lbBills.Size = new System.Drawing.Size(46, 22);
            this.lbBills.TabIndex = 1028;
            this.lbBills.Text = "Bills";
            // 
            // txtBills
            // 
            this.txtBills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBills.Enabled = false;
            this.txtBills.Location = new System.Drawing.Point(890, 18);
            this.txtBills.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBills.Name = "txtBills";
            this.txtBills.Size = new System.Drawing.Size(57, 22);
            this.txtBills.TabIndex = 1029;
            this.txtBills.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(55)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtBills);
            this.Controls.Add(this.lbBills);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtkEnd);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.dtkStart);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.dgvStatisticsList);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.MinimumSize = new System.Drawing.Size(975, 600);
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStatisticsList;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.DateTimePicker dtkStart;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker dtkEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lbBills;
        private System.Windows.Forms.TextBox txtBills;
    }
}