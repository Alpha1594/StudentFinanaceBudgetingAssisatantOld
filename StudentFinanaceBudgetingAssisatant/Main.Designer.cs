﻿namespace StudentFinanaceBudgetingAssisatant
{
    partial class Main
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.Resultant = new System.Windows.Forms.Label();
            this.In = new System.Windows.Forms.Label();
            this.Out = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabOverview = new System.Windows.Forms.TabPage();
            this.LBTransactionsToProcess = new System.Windows.Forms.ListBox();
            this.LBNextTransactions = new System.Windows.Forms.ListBox();
            this.TabIn = new System.Windows.Forms.TabPage();
            this.CBInCategory = new System.Windows.Forms.ComboBox();
            this.CBRepeatFreqIn = new System.Windows.Forms.ComboBox();
            this.DTRepeatEndIn = new System.Windows.Forms.DateTimePicker();
            this.DTRepeatStartIn = new System.Windows.Forms.DateTimePicker();
            this.CBInRepeat = new System.Windows.Forms.CheckBox();
            this.BtnSaveIn = new System.Windows.Forms.Button();
            this.CBInCompleted = new System.Windows.Forms.CheckBox();
            this.TBInComment = new System.Windows.Forms.TextBox();
            this.DTInReal = new System.Windows.Forms.DateTimePicker();
            this.DTInDeadline = new System.Windows.Forms.DateTimePicker();
            this.NuInAmountReal = new System.Windows.Forms.NumericUpDown();
            this.NuInAmountPre = new System.Windows.Forms.NumericUpDown();
            this.TBInName = new System.Windows.Forms.TextBox();
            this.LaIn = new System.Windows.Forms.Label();
            this.LBIn = new System.Windows.Forms.ListBox();
            this.TabOut = new System.Windows.Forms.TabPage();
            this.BtnSaveOut = new System.Windows.Forms.Button();
            this.TBOutComment = new System.Windows.Forms.TextBox();
            this.CBRepeatFreqOut = new System.Windows.Forms.ComboBox();
            this.DTRepeatEndOut = new System.Windows.Forms.DateTimePicker();
            this.DTRepeatStartOut = new System.Windows.Forms.DateTimePicker();
            this.CBOutRepeat = new System.Windows.Forms.CheckBox();
            this.DTOutReal = new System.Windows.Forms.DateTimePicker();
            this.NuOutAmountReal = new System.Windows.Forms.NumericUpDown();
            this.CBOutCompleted = new System.Windows.Forms.CheckBox();
            this.DTOutDeadline = new System.Windows.Forms.DateTimePicker();
            this.NuOutAmountPre = new System.Windows.Forms.NumericUpDown();
            this.CBOutCategory = new System.Windows.Forms.ComboBox();
            this.TBOutName = new System.Windows.Forms.TextBox();
            this.LaOut = new System.Windows.Forms.Label();
            this.LBOut = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.TabOverview.SuspendLayout();
            this.TabIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuInAmountReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuInAmountPre)).BeginInit();
            this.TabOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuOutAmountReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuOutAmountPre)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(701, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // Resultant
            // 
            this.Resultant.AutoSize = true;
            this.Resultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultant.Location = new System.Drawing.Point(8, 3);
            this.Resultant.Name = "Resultant";
            this.Resultant.Size = new System.Drawing.Size(214, 51);
            this.Resultant.TabIndex = 1;
            this.Resultant.Tag = "Resultant";
            this.Resultant.Text = "Resultant";
            this.Resultant.TextChanged += new System.EventHandler(this.ResultantFmt);
            this.Resultant.DoubleClick += new System.EventHandler(this.ResultantFmt);
            // 
            // In
            // 
            this.In.AutoSize = true;
            this.In.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In.Location = new System.Drawing.Point(14, 63);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(32, 26);
            this.In.TabIndex = 2;
            this.In.Text = "In";
            this.In.TextChanged += new System.EventHandler(this.InFmt);
            this.In.DoubleClick += new System.EventHandler(this.GotoTabIn);
            // 
            // Out
            // 
            this.Out.AutoSize = true;
            this.Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out.Location = new System.Drawing.Point(172, 63);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(50, 26);
            this.Out.TabIndex = 3;
            this.Out.Text = "Out";
            this.Out.DoubleClick += new System.EventHandler(this.GotoTabOut);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabOverview);
            this.tabControl1.Controls.Add(this.TabIn);
            this.tabControl1.Controls.Add(this.TabOut);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 481);
            this.tabControl1.TabIndex = 4;
            // 
            // TabOverview
            // 
            this.TabOverview.Controls.Add(this.LBTransactionsToProcess);
            this.TabOverview.Controls.Add(this.LBNextTransactions);
            this.TabOverview.Controls.Add(this.Resultant);
            this.TabOverview.Controls.Add(this.Out);
            this.TabOverview.Controls.Add(this.In);
            this.TabOverview.Location = new System.Drawing.Point(4, 22);
            this.TabOverview.Name = "TabOverview";
            this.TabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.TabOverview.Size = new System.Drawing.Size(693, 455);
            this.TabOverview.TabIndex = 0;
            this.TabOverview.Text = "TabOverview";
            this.TabOverview.UseVisualStyleBackColor = true;
            // 
            // LBTransactionsToProcess
            // 
            this.LBTransactionsToProcess.FormattingEnabled = true;
            this.LBTransactionsToProcess.Location = new System.Drawing.Point(17, 279);
            this.LBTransactionsToProcess.Name = "LBTransactionsToProcess";
            this.LBTransactionsToProcess.Size = new System.Drawing.Size(205, 173);
            this.LBTransactionsToProcess.TabIndex = 5;
            // 
            // LBNextTransactions
            // 
            this.LBNextTransactions.FormattingEnabled = true;
            this.LBNextTransactions.Location = new System.Drawing.Point(17, 92);
            this.LBNextTransactions.Name = "LBNextTransactions";
            this.LBNextTransactions.Size = new System.Drawing.Size(205, 173);
            this.LBNextTransactions.TabIndex = 4;
            // 
            // TabIn
            // 
            this.TabIn.Controls.Add(this.CBInCategory);
            this.TabIn.Controls.Add(this.CBRepeatFreqIn);
            this.TabIn.Controls.Add(this.DTRepeatEndIn);
            this.TabIn.Controls.Add(this.DTRepeatStartIn);
            this.TabIn.Controls.Add(this.CBInRepeat);
            this.TabIn.Controls.Add(this.BtnSaveIn);
            this.TabIn.Controls.Add(this.CBInCompleted);
            this.TabIn.Controls.Add(this.TBInComment);
            this.TabIn.Controls.Add(this.DTInReal);
            this.TabIn.Controls.Add(this.DTInDeadline);
            this.TabIn.Controls.Add(this.NuInAmountReal);
            this.TabIn.Controls.Add(this.NuInAmountPre);
            this.TabIn.Controls.Add(this.TBInName);
            this.TabIn.Controls.Add(this.LaIn);
            this.TabIn.Controls.Add(this.LBIn);
            this.TabIn.Location = new System.Drawing.Point(4, 22);
            this.TabIn.Name = "TabIn";
            this.TabIn.Padding = new System.Windows.Forms.Padding(3);
            this.TabIn.Size = new System.Drawing.Size(693, 455);
            this.TabIn.TabIndex = 1;
            this.TabIn.Text = "TabIn";
            this.TabIn.UseVisualStyleBackColor = true;
            // 
            // CBInCategory
            // 
            this.CBInCategory.FormattingEnabled = true;
            this.CBInCategory.Location = new System.Drawing.Point(332, 38);
            this.CBInCategory.Name = "CBInCategory";
            this.CBInCategory.Size = new System.Drawing.Size(121, 21);
            this.CBInCategory.TabIndex = 15;
            // 
            // CBRepeatFreqIn
            // 
            this.CBRepeatFreqIn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBRepeatFreqIn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBRepeatFreqIn.Enabled = false;
            this.CBRepeatFreqIn.FormattingEnabled = true;
            this.CBRepeatFreqIn.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Quarterly",
            "Termly",
            "Anualy"});
            this.CBRepeatFreqIn.Location = new System.Drawing.Point(331, 200);
            this.CBRepeatFreqIn.Name = "CBRepeatFreqIn";
            this.CBRepeatFreqIn.Size = new System.Drawing.Size(121, 21);
            this.CBRepeatFreqIn.TabIndex = 14;
            // 
            // DTRepeatEndIn
            // 
            this.DTRepeatEndIn.Enabled = false;
            this.DTRepeatEndIn.Location = new System.Drawing.Point(458, 174);
            this.DTRepeatEndIn.Name = "DTRepeatEndIn";
            this.DTRepeatEndIn.Size = new System.Drawing.Size(120, 20);
            this.DTRepeatEndIn.TabIndex = 13;
            // 
            // DTRepeatStartIn
            // 
            this.DTRepeatStartIn.Enabled = false;
            this.DTRepeatStartIn.Location = new System.Drawing.Point(332, 174);
            this.DTRepeatStartIn.Name = "DTRepeatStartIn";
            this.DTRepeatStartIn.Size = new System.Drawing.Size(120, 20);
            this.DTRepeatStartIn.TabIndex = 12;
            // 
            // CBInRepeat
            // 
            this.CBInRepeat.AutoSize = true;
            this.CBInRepeat.Location = new System.Drawing.Point(332, 151);
            this.CBInRepeat.Name = "CBInRepeat";
            this.CBInRepeat.Size = new System.Drawing.Size(84, 17);
            this.CBInRepeat.TabIndex = 11;
            this.CBInRepeat.Text = "CBInRepeat";
            this.CBInRepeat.UseVisualStyleBackColor = true;
            this.CBInRepeat.CheckStateChanged += new System.EventHandler(this.ToggleRepeatIn);
            // 
            // BtnSaveIn
            // 
            this.BtnSaveIn.Location = new System.Drawing.Point(610, 422);
            this.BtnSaveIn.Name = "BtnSaveIn";
            this.BtnSaveIn.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveIn.TabIndex = 10;
            this.BtnSaveIn.Text = "BtnSaveIn";
            this.BtnSaveIn.UseVisualStyleBackColor = true;
            this.BtnSaveIn.Click += new System.EventHandler(this.BtnSaveIn_Click);
            // 
            // CBInCompleted
            // 
            this.CBInCompleted.AutoSize = true;
            this.CBInCompleted.Location = new System.Drawing.Point(332, 117);
            this.CBInCompleted.Name = "CBInCompleted";
            this.CBInCompleted.Size = new System.Drawing.Size(99, 17);
            this.CBInCompleted.TabIndex = 9;
            this.CBInCompleted.Text = "CBInCompleted";
            this.CBInCompleted.UseVisualStyleBackColor = true;
            this.CBInCompleted.CheckStateChanged += new System.EventHandler(this.CompletionToggleIn);
            // 
            // TBInComment
            // 
            this.TBInComment.Location = new System.Drawing.Point(332, 260);
            this.TBInComment.Multiline = true;
            this.TBInComment.Name = "TBInComment";
            this.TBInComment.Size = new System.Drawing.Size(246, 80);
            this.TBInComment.TabIndex = 8;
            this.TBInComment.Text = "TBInComment";
            // 
            // DTInReal
            // 
            this.DTInReal.Enabled = false;
            this.DTInReal.Location = new System.Drawing.Point(458, 91);
            this.DTInReal.Name = "DTInReal";
            this.DTInReal.Size = new System.Drawing.Size(120, 20);
            this.DTInReal.TabIndex = 7;
            // 
            // DTInDeadline
            // 
            this.DTInDeadline.Location = new System.Drawing.Point(332, 91);
            this.DTInDeadline.Name = "DTInDeadline";
            this.DTInDeadline.Size = new System.Drawing.Size(120, 20);
            this.DTInDeadline.TabIndex = 6;
            // 
            // NuInAmountReal
            // 
            this.NuInAmountReal.DecimalPlaces = 2;
            this.NuInAmountReal.Enabled = false;
            this.NuInAmountReal.Location = new System.Drawing.Point(458, 65);
            this.NuInAmountReal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NuInAmountReal.Name = "NuInAmountReal";
            this.NuInAmountReal.Size = new System.Drawing.Size(120, 20);
            this.NuInAmountReal.TabIndex = 5;
            this.NuInAmountReal.ThousandsSeparator = true;
            // 
            // NuInAmountPre
            // 
            this.NuInAmountPre.DecimalPlaces = 2;
            this.NuInAmountPre.Location = new System.Drawing.Point(332, 65);
            this.NuInAmountPre.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NuInAmountPre.Name = "NuInAmountPre";
            this.NuInAmountPre.Size = new System.Drawing.Size(120, 20);
            this.NuInAmountPre.TabIndex = 4;
            this.NuInAmountPre.ThousandsSeparator = true;
            // 
            // TBInName
            // 
            this.TBInName.Location = new System.Drawing.Point(332, 12);
            this.TBInName.Name = "TBInName";
            this.TBInName.Size = new System.Drawing.Size(100, 20);
            this.TBInName.TabIndex = 2;
            this.TBInName.Text = "TBInName";
            // 
            // LaIn
            // 
            this.LaIn.AutoSize = true;
            this.LaIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaIn.Location = new System.Drawing.Point(243, 6);
            this.LaIn.Name = "LaIn";
            this.LaIn.Size = new System.Drawing.Size(54, 26);
            this.LaIn.TabIndex = 1;
            this.LaIn.Text = "LaIn";
            // 
            // LBIn
            // 
            this.LBIn.FormattingEnabled = true;
            this.LBIn.Location = new System.Drawing.Point(3, 6);
            this.LBIn.Name = "LBIn";
            this.LBIn.Size = new System.Drawing.Size(234, 355);
            this.LBIn.TabIndex = 0;
            // 
            // TabOut
            // 
            this.TabOut.Controls.Add(this.BtnSaveOut);
            this.TabOut.Controls.Add(this.TBOutComment);
            this.TabOut.Controls.Add(this.CBRepeatFreqOut);
            this.TabOut.Controls.Add(this.DTRepeatEndOut);
            this.TabOut.Controls.Add(this.DTRepeatStartOut);
            this.TabOut.Controls.Add(this.CBOutRepeat);
            this.TabOut.Controls.Add(this.DTOutReal);
            this.TabOut.Controls.Add(this.NuOutAmountReal);
            this.TabOut.Controls.Add(this.CBOutCompleted);
            this.TabOut.Controls.Add(this.DTOutDeadline);
            this.TabOut.Controls.Add(this.NuOutAmountPre);
            this.TabOut.Controls.Add(this.CBOutCategory);
            this.TabOut.Controls.Add(this.TBOutName);
            this.TabOut.Controls.Add(this.LaOut);
            this.TabOut.Controls.Add(this.LBOut);
            this.TabOut.Location = new System.Drawing.Point(4, 22);
            this.TabOut.Name = "TabOut";
            this.TabOut.Size = new System.Drawing.Size(693, 455);
            this.TabOut.TabIndex = 2;
            this.TabOut.Text = "TabOut";
            this.TabOut.UseVisualStyleBackColor = true;
            // 
            // BtnSaveOut
            // 
            this.BtnSaveOut.Location = new System.Drawing.Point(610, 422);
            this.BtnSaveOut.Name = "BtnSaveOut";
            this.BtnSaveOut.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveOut.TabIndex = 27;
            this.BtnSaveOut.Text = "BtnSaveOut";
            this.BtnSaveOut.UseVisualStyleBackColor = true;
            this.BtnSaveOut.Click += new System.EventHandler(this.BtnSaveOut_Click);
            // 
            // TBOutComment
            // 
            this.TBOutComment.Location = new System.Drawing.Point(332, 260);
            this.TBOutComment.Multiline = true;
            this.TBOutComment.Name = "TBOutComment";
            this.TBOutComment.Size = new System.Drawing.Size(246, 80);
            this.TBOutComment.TabIndex = 26;
            this.TBOutComment.Text = "TBOutComment";
            // 
            // CBRepeatFreqOut
            // 
            this.CBRepeatFreqOut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBRepeatFreqOut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBRepeatFreqOut.Enabled = false;
            this.CBRepeatFreqOut.FormattingEnabled = true;
            this.CBRepeatFreqOut.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Quarterly",
            "Termly",
            "Anualy"});
            this.CBRepeatFreqOut.Location = new System.Drawing.Point(331, 200);
            this.CBRepeatFreqOut.Name = "CBRepeatFreqOut";
            this.CBRepeatFreqOut.Size = new System.Drawing.Size(121, 21);
            this.CBRepeatFreqOut.TabIndex = 25;
            // 
            // DTRepeatEndOut
            // 
            this.DTRepeatEndOut.Enabled = false;
            this.DTRepeatEndOut.Location = new System.Drawing.Point(458, 174);
            this.DTRepeatEndOut.Name = "DTRepeatEndOut";
            this.DTRepeatEndOut.Size = new System.Drawing.Size(120, 20);
            this.DTRepeatEndOut.TabIndex = 24;
            // 
            // DTRepeatStartOut
            // 
            this.DTRepeatStartOut.Enabled = false;
            this.DTRepeatStartOut.Location = new System.Drawing.Point(332, 174);
            this.DTRepeatStartOut.Name = "DTRepeatStartOut";
            this.DTRepeatStartOut.Size = new System.Drawing.Size(120, 20);
            this.DTRepeatStartOut.TabIndex = 23;
            // 
            // CBOutRepeat
            // 
            this.CBOutRepeat.AutoSize = true;
            this.CBOutRepeat.Location = new System.Drawing.Point(332, 151);
            this.CBOutRepeat.Name = "CBOutRepeat";
            this.CBOutRepeat.Size = new System.Drawing.Size(92, 17);
            this.CBOutRepeat.TabIndex = 22;
            this.CBOutRepeat.Text = "CBOutRepeat";
            this.CBOutRepeat.UseVisualStyleBackColor = true;
            this.CBOutRepeat.CheckStateChanged += new System.EventHandler(this.ToggleRepeatOut);
            // 
            // DTOutReal
            // 
            this.DTOutReal.Enabled = false;
            this.DTOutReal.Location = new System.Drawing.Point(458, 91);
            this.DTOutReal.Name = "DTOutReal";
            this.DTOutReal.Size = new System.Drawing.Size(120, 20);
            this.DTOutReal.TabIndex = 21;
            // 
            // NuOutAmountReal
            // 
            this.NuOutAmountReal.DecimalPlaces = 2;
            this.NuOutAmountReal.Enabled = false;
            this.NuOutAmountReal.Location = new System.Drawing.Point(458, 65);
            this.NuOutAmountReal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NuOutAmountReal.Name = "NuOutAmountReal";
            this.NuOutAmountReal.Size = new System.Drawing.Size(120, 20);
            this.NuOutAmountReal.TabIndex = 20;
            this.NuOutAmountReal.ThousandsSeparator = true;
            // 
            // CBOutCompleted
            // 
            this.CBOutCompleted.AutoSize = true;
            this.CBOutCompleted.Location = new System.Drawing.Point(332, 117);
            this.CBOutCompleted.Name = "CBOutCompleted";
            this.CBOutCompleted.Size = new System.Drawing.Size(107, 17);
            this.CBOutCompleted.TabIndex = 19;
            this.CBOutCompleted.Text = "CBOutCompleted";
            this.CBOutCompleted.UseVisualStyleBackColor = true;
            this.CBOutCompleted.CheckStateChanged += new System.EventHandler(this.CompletionToggleOut);
            // 
            // DTOutDeadline
            // 
            this.DTOutDeadline.Location = new System.Drawing.Point(332, 91);
            this.DTOutDeadline.Name = "DTOutDeadline";
            this.DTOutDeadline.Size = new System.Drawing.Size(120, 20);
            this.DTOutDeadline.TabIndex = 18;
            // 
            // NuOutAmountPre
            // 
            this.NuOutAmountPre.DecimalPlaces = 2;
            this.NuOutAmountPre.Location = new System.Drawing.Point(332, 65);
            this.NuOutAmountPre.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NuOutAmountPre.Name = "NuOutAmountPre";
            this.NuOutAmountPre.Size = new System.Drawing.Size(120, 20);
            this.NuOutAmountPre.TabIndex = 17;
            this.NuOutAmountPre.ThousandsSeparator = true;
            // 
            // CBOutCategory
            // 
            this.CBOutCategory.FormattingEnabled = true;
            this.CBOutCategory.Location = new System.Drawing.Point(332, 38);
            this.CBOutCategory.Name = "CBOutCategory";
            this.CBOutCategory.Size = new System.Drawing.Size(121, 21);
            this.CBOutCategory.TabIndex = 16;
            // 
            // TBOutName
            // 
            this.TBOutName.Location = new System.Drawing.Point(332, 12);
            this.TBOutName.Name = "TBOutName";
            this.TBOutName.Size = new System.Drawing.Size(100, 20);
            this.TBOutName.TabIndex = 3;
            this.TBOutName.Text = "TBOutName";
            // 
            // LaOut
            // 
            this.LaOut.AutoSize = true;
            this.LaOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaOut.Location = new System.Drawing.Point(243, 6);
            this.LaOut.Name = "LaOut";
            this.LaOut.Size = new System.Drawing.Size(71, 26);
            this.LaOut.TabIndex = 2;
            this.LaOut.Text = "LaOut";
            // 
            // LBOut
            // 
            this.LBOut.FormattingEnabled = true;
            this.LBOut.Location = new System.Drawing.Point(3, 6);
            this.LBOut.Name = "LBOut";
            this.LBOut.Size = new System.Drawing.Size(234, 355);
            this.LBOut.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 506);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.TabOverview.ResumeLayout(false);
            this.TabOverview.PerformLayout();
            this.TabIn.ResumeLayout(false);
            this.TabIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuInAmountReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuInAmountPre)).EndInit();
            this.TabOut.ResumeLayout(false);
            this.TabOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuOutAmountReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuOutAmountPre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.Label Resultant;
        private System.Windows.Forms.Label In;
        private System.Windows.Forms.Label Out;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabOverview;
        private System.Windows.Forms.TabPage TabIn;
        private System.Windows.Forms.TabPage TabOut;
        private System.Windows.Forms.ListBox LBTransactionsToProcess;
        private System.Windows.Forms.ListBox LBNextTransactions;
        private System.Windows.Forms.Label LaIn;
        private System.Windows.Forms.ListBox LBIn;
        private System.Windows.Forms.CheckBox CBInCompleted;
        private System.Windows.Forms.TextBox TBInComment;
        private System.Windows.Forms.DateTimePicker DTInReal;
        private System.Windows.Forms.DateTimePicker DTInDeadline;
        private System.Windows.Forms.NumericUpDown NuInAmountReal;
        private System.Windows.Forms.NumericUpDown NuInAmountPre;
        private System.Windows.Forms.TextBox TBInName;
        private System.Windows.Forms.Button BtnSaveIn;
        private System.Windows.Forms.CheckBox CBInRepeat;
        private System.Windows.Forms.DateTimePicker DTRepeatEndIn;
        private System.Windows.Forms.DateTimePicker DTRepeatStartIn;
        private System.Windows.Forms.ComboBox CBRepeatFreqIn;
        private System.Windows.Forms.ComboBox CBInCategory;
        private System.Windows.Forms.ComboBox CBOutCategory;
        private System.Windows.Forms.TextBox TBOutName;
        private System.Windows.Forms.Label LaOut;
        private System.Windows.Forms.ListBox LBOut;
        private System.Windows.Forms.CheckBox CBOutCompleted;
        private System.Windows.Forms.DateTimePicker DTOutDeadline;
        private System.Windows.Forms.NumericUpDown NuOutAmountPre;
        private System.Windows.Forms.NumericUpDown NuOutAmountReal;
        private System.Windows.Forms.DateTimePicker DTOutReal;
        private System.Windows.Forms.ComboBox CBRepeatFreqOut;
        private System.Windows.Forms.DateTimePicker DTRepeatEndOut;
        private System.Windows.Forms.DateTimePicker DTRepeatStartOut;
        private System.Windows.Forms.CheckBox CBOutRepeat;
        private System.Windows.Forms.Button BtnSaveOut;
        private System.Windows.Forms.TextBox TBOutComment;
    }
}
