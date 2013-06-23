namespace StudentFinanaceBudgetingAssisatant
{
    partial class Config
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabDates = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DTT1S = new System.Windows.Forms.DateTimePicker();
            this.DTT1E = new System.Windows.Forms.DateTimePicker();
            this.DTT2S = new System.Windows.Forms.DateTimePicker();
            this.DTT2E = new System.Windows.Forms.DateTimePicker();
            this.DTT3S = new System.Windows.Forms.DateTimePicker();
            this.DTT3E = new System.Windows.Forms.DateTimePicker();
            this.BtnSaveConfig = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabDates);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 230);
            this.tabControl1.TabIndex = 0;
            // 
            // TabDates
            // 
            this.TabDates.Controls.Add(this.DTT3E);
            this.TabDates.Controls.Add(this.DTT3S);
            this.TabDates.Controls.Add(this.DTT2E);
            this.TabDates.Controls.Add(this.DTT2S);
            this.TabDates.Controls.Add(this.DTT1E);
            this.TabDates.Controls.Add(this.DTT1S);
            this.TabDates.Location = new System.Drawing.Point(4, 22);
            this.TabDates.Name = "TabDates";
            this.TabDates.Padding = new System.Windows.Forms.Padding(3);
            this.TabDates.Size = new System.Drawing.Size(277, 204);
            this.TabDates.TabIndex = 0;
            this.TabDates.Text = "Dates";
            this.TabDates.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DTT1S
            // 
            this.DTT1S.Location = new System.Drawing.Point(152, 6);
            this.DTT1S.Name = "DTT1S";
            this.DTT1S.Size = new System.Drawing.Size(116, 20);
            this.DTT1S.TabIndex = 0;
            // 
            // DTT1E
            // 
            this.DTT1E.Location = new System.Drawing.Point(152, 32);
            this.DTT1E.Name = "DTT1E";
            this.DTT1E.Size = new System.Drawing.Size(116, 20);
            this.DTT1E.TabIndex = 1;
            // 
            // DTT2S
            // 
            this.DTT2S.Location = new System.Drawing.Point(152, 58);
            this.DTT2S.Name = "DTT2S";
            this.DTT2S.Size = new System.Drawing.Size(116, 20);
            this.DTT2S.TabIndex = 2;
            // 
            // DTT2E
            // 
            this.DTT2E.Location = new System.Drawing.Point(152, 84);
            this.DTT2E.Name = "DTT2E";
            this.DTT2E.Size = new System.Drawing.Size(116, 20);
            this.DTT2E.TabIndex = 3;
            // 
            // DTT3S
            // 
            this.DTT3S.Location = new System.Drawing.Point(152, 110);
            this.DTT3S.Name = "DTT3S";
            this.DTT3S.Size = new System.Drawing.Size(116, 20);
            this.DTT3S.TabIndex = 4;
            // 
            // DTT3E
            // 
            this.DTT3E.Location = new System.Drawing.Point(152, 136);
            this.DTT3E.Name = "DTT3E";
            this.DTT3E.Size = new System.Drawing.Size(116, 20);
            this.DTT3E.TabIndex = 5;
            // 
            // BtnSaveConfig
            // 
            this.BtnSaveConfig.Location = new System.Drawing.Point(206, 236);
            this.BtnSaveConfig.Name = "BtnSaveConfig";
            this.BtnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveConfig.TabIndex = 6;
            this.BtnSaveConfig.Text = "BtnSaveConfig";
            this.BtnSaveConfig.UseVisualStyleBackColor = true;
            this.BtnSaveConfig.Click += new System.EventHandler(this.BtnSaveConfig_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnSaveConfig);
            this.Controls.Add(this.tabControl1);
            this.Name = "Config";
            this.Text = "Config";
            this.tabControl1.ResumeLayout(false);
            this.TabDates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabDates;
        private System.Windows.Forms.DateTimePicker DTT3E;
        private System.Windows.Forms.DateTimePicker DTT3S;
        private System.Windows.Forms.DateTimePicker DTT2E;
        private System.Windows.Forms.DateTimePicker DTT2S;
        private System.Windows.Forms.DateTimePicker DTT1E;
        private System.Windows.Forms.DateTimePicker DTT1S;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnSaveConfig;
    }
}