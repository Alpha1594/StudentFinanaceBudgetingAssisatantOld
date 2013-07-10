namespace StudentFinanaceBudgetingAssisatant
{
    partial class Insurance
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
            this.LBIns = new System.Windows.Forms.ListBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.NUValue = new System.Windows.Forms.NumericUpDown();
            this.DTPurchased = new System.Windows.Forms.DateTimePicker();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.BTNSave = new System.Windows.Forms.Button();
            this.TBComments = new System.Windows.Forms.TextBox();
            this.LBLTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUValue)).BeginInit();
            this.SuspendLayout();
            // 
            // LBIns
            // 
            this.LBIns.FormattingEnabled = true;
            this.LBIns.Location = new System.Drawing.Point(0, 0);
            this.LBIns.Name = "LBIns";
            this.LBIns.Size = new System.Drawing.Size(180, 316);
            this.LBIns.TabIndex = 0;
            this.LBIns.SelectedIndexChanged += new System.EventHandler(this.LBIns_SelectedIndexChanged);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(186, 12);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 1;
            this.TBName.Text = "TBName";
            // 
            // NUValue
            // 
            this.NUValue.Location = new System.Drawing.Point(186, 38);
            this.NUValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUValue.Name = "NUValue";
            this.NUValue.Size = new System.Drawing.Size(120, 20);
            this.NUValue.TabIndex = 2;
            this.NUValue.ThousandsSeparator = true;
            // 
            // DTPurchased
            // 
            this.DTPurchased.Location = new System.Drawing.Point(186, 64);
            this.DTPurchased.Name = "DTPurchased";
            this.DTPurchased.Size = new System.Drawing.Size(120, 20);
            this.DTPurchased.TabIndex = 3;
            // 
            // CBCategory
            // 
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(186, 90);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(121, 21);
            this.CBCategory.TabIndex = 4;
            // 
            // BTNSave
            // 
            this.BTNSave.Location = new System.Drawing.Point(186, 190);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(75, 23);
            this.BTNSave.TabIndex = 5;
            this.BTNSave.Text = "BTNSave";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // TBComments
            // 
            this.TBComments.Location = new System.Drawing.Point(186, 117);
            this.TBComments.Multiline = true;
            this.TBComments.Name = "TBComments";
            this.TBComments.Size = new System.Drawing.Size(100, 50);
            this.TBComments.TabIndex = 6;
            this.TBComments.Text = "TBComments";
            // 
            // LBLTotal
            // 
            this.LBLTotal.AutoSize = true;
            this.LBLTotal.Location = new System.Drawing.Point(12, 328);
            this.LBLTotal.Name = "LBLTotal";
            this.LBLTotal.Size = new System.Drawing.Size(50, 13);
            this.LBLTotal.TabIndex = 7;
            this.LBLTotal.Text = "LBLTotal";
            // 
            // Insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 350);
            this.Controls.Add(this.LBLTotal);
            this.Controls.Add(this.TBComments);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.CBCategory);
            this.Controls.Add(this.DTPurchased);
            this.Controls.Add(this.NUValue);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LBIns);
            this.Name = "Insurance";
            this.Text = "Insurance";
            ((System.ComponentModel.ISupportInitialize)(this.NUValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBIns;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.NumericUpDown NUValue;
        private System.Windows.Forms.DateTimePicker DTPurchased;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.Button BTNSave;
        private System.Windows.Forms.TextBox TBComments;
        private System.Windows.Forms.Label LBLTotal;
    }
}