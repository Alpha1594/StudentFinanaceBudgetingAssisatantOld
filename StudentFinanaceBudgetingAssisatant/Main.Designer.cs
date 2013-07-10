namespace StudentFinanaceBudgetingAssisatant
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
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anualyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quarterlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Resultant = new System.Windows.Forms.Label();
            this.RCMTime = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RCMAnual = new System.Windows.Forms.ToolStripMenuItem();
            this.RCMTerm = new System.Windows.Forms.ToolStripMenuItem();
            this.RCMQuarter = new System.Windows.Forms.ToolStripMenuItem();
            this.RCMMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.RCMWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.RCMReset = new System.Windows.Forms.ToolStripMenuItem();
            this.In = new System.Windows.Forms.Label();
            this.Out = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabOverview = new System.Windows.Forms.TabPage();
            this.LBTransactionsToProcess = new System.Windows.Forms.ListBox();
            this.LBNextTransactions = new System.Windows.Forms.ListBox();
            this.TabIn = new System.Windows.Forms.TabPage();
            this.CBInCompany = new System.Windows.Forms.ComboBox();
            this.BtnResetTabIn = new System.Windows.Forms.Button();
            this.CBInCategory = new System.Windows.Forms.ComboBox();
            this.CBRepeatFreqIn = new System.Windows.Forms.ComboBox();
            this.DTRepeatEndIn = new System.Windows.Forms.DateTimePicker();
            this.DTRepeatStartIn = new System.Windows.Forms.DateTimePicker();
            this.CBInRepeat = new System.Windows.Forms.CheckBox();
            this.BtnAddIn = new System.Windows.Forms.Button();
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
            this.CBOutCompany = new System.Windows.Forms.ComboBox();
            this.BtnResetTabOut = new System.Windows.Forms.Button();
            this.LaAccomodation = new System.Windows.Forms.Label();
            this.LaFood = new System.Windows.Forms.Label();
            this.BtnAddOut = new System.Windows.Forms.Button();
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
            this.insuranceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.RCMTime.SuspendLayout();
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
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.transactionModeToolStripMenuItem,
            this.insuranceToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(701, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.EditConfig);
            // 
            // transactionModeToolStripMenuItem
            // 
            this.transactionModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anualyToolStripMenuItem,
            this.termlyToolStripMenuItem,
            this.quarterlyToolStripMenuItem,
            this.monthlyToolStripMenuItem,
            this.weeklyToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.transactionModeToolStripMenuItem.Name = "transactionModeToolStripMenuItem";
            this.transactionModeToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.transactionModeToolStripMenuItem.Text = "TransactionMode";
            // 
            // anualyToolStripMenuItem
            // 
            this.anualyToolStripMenuItem.Name = "anualyToolStripMenuItem";
            this.anualyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.anualyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.anualyToolStripMenuItem.Text = "&Anualy";
            this.anualyToolStripMenuItem.Click += new System.EventHandler(this.RCMAnual_Click);
            // 
            // termlyToolStripMenuItem
            // 
            this.termlyToolStripMenuItem.Name = "termlyToolStripMenuItem";
            this.termlyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.termlyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.termlyToolStripMenuItem.Text = "&Termly";
            this.termlyToolStripMenuItem.Click += new System.EventHandler(this.RCMTerm_Click);
            // 
            // quarterlyToolStripMenuItem
            // 
            this.quarterlyToolStripMenuItem.Name = "quarterlyToolStripMenuItem";
            this.quarterlyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quarterlyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.quarterlyToolStripMenuItem.Text = "&Quarterly";
            this.quarterlyToolStripMenuItem.Click += new System.EventHandler(this.RCMQuarter_Click);
            // 
            // monthlyToolStripMenuItem
            // 
            this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            this.monthlyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.monthlyToolStripMenuItem.Text = "&Monthly";
            this.monthlyToolStripMenuItem.Click += new System.EventHandler(this.RCMMonth_Click);
            // 
            // weeklyToolStripMenuItem
            // 
            this.weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
            this.weeklyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.weeklyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.weeklyToolStripMenuItem.Text = "&Weekly";
            this.weeklyToolStripMenuItem.Click += new System.EventHandler(this.RCMWeek_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.RCMReset_Click);
            // 
            // Resultant
            // 
            this.Resultant.AutoSize = true;
            this.Resultant.ContextMenuStrip = this.RCMTime;
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
            // RCMTime
            // 
            this.RCMTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RCMAnual,
            this.RCMTerm,
            this.RCMQuarter,
            this.RCMMonth,
            this.RCMWeek,
            this.RCMReset});
            this.RCMTime.Name = "RCMTime";
            this.RCMTime.Size = new System.Drawing.Size(180, 136);
            // 
            // RCMAnual
            // 
            this.RCMAnual.Name = "RCMAnual";
            this.RCMAnual.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.RCMAnual.Size = new System.Drawing.Size(179, 22);
            this.RCMAnual.Text = "RCM&Anual";
            this.RCMAnual.Click += new System.EventHandler(this.RCMAnual_Click);
            // 
            // RCMTerm
            // 
            this.RCMTerm.Name = "RCMTerm";
            this.RCMTerm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.RCMTerm.Size = new System.Drawing.Size(179, 22);
            this.RCMTerm.Text = "RCM&Term";
            this.RCMTerm.Click += new System.EventHandler(this.RCMTerm_Click);
            // 
            // RCMQuarter
            // 
            this.RCMQuarter.Name = "RCMQuarter";
            this.RCMQuarter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.RCMQuarter.Size = new System.Drawing.Size(179, 22);
            this.RCMQuarter.Text = "RCM&Quarter";
            this.RCMQuarter.Click += new System.EventHandler(this.RCMQuarter_Click);
            // 
            // RCMMonth
            // 
            this.RCMMonth.Name = "RCMMonth";
            this.RCMMonth.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.RCMMonth.Size = new System.Drawing.Size(179, 22);
            this.RCMMonth.Text = "RCM&Month";
            this.RCMMonth.Click += new System.EventHandler(this.RCMMonth_Click);
            // 
            // RCMWeek
            // 
            this.RCMWeek.Name = "RCMWeek";
            this.RCMWeek.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.RCMWeek.Size = new System.Drawing.Size(179, 22);
            this.RCMWeek.Text = "RCM&Week";
            this.RCMWeek.Click += new System.EventHandler(this.RCMWeek_Click);
            // 
            // RCMReset
            // 
            this.RCMReset.Name = "RCMReset";
            this.RCMReset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.RCMReset.Size = new System.Drawing.Size(179, 22);
            this.RCMReset.Text = "RCMReset";
            this.RCMReset.Click += new System.EventHandler(this.RCMReset_Click);
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
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 18);
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
            this.TabIn.Controls.Add(this.CBInCompany);
            this.TabIn.Controls.Add(this.BtnResetTabIn);
            this.TabIn.Controls.Add(this.CBInCategory);
            this.TabIn.Controls.Add(this.CBRepeatFreqIn);
            this.TabIn.Controls.Add(this.DTRepeatEndIn);
            this.TabIn.Controls.Add(this.DTRepeatStartIn);
            this.TabIn.Controls.Add(this.CBInRepeat);
            this.TabIn.Controls.Add(this.BtnAddIn);
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
            // CBInCompany
            // 
            this.CBInCompany.FormattingEnabled = true;
            this.CBInCompany.Location = new System.Drawing.Point(458, 11);
            this.CBInCompany.Name = "CBInCompany";
            this.CBInCompany.Size = new System.Drawing.Size(121, 21);
            this.CBInCompany.TabIndex = 17;
            // 
            // BtnResetTabIn
            // 
            this.BtnResetTabIn.Location = new System.Drawing.Point(529, 422);
            this.BtnResetTabIn.Name = "BtnResetTabIn";
            this.BtnResetTabIn.Size = new System.Drawing.Size(75, 23);
            this.BtnResetTabIn.TabIndex = 16;
            this.BtnResetTabIn.Text = "BtnResetTabIn";
            this.BtnResetTabIn.UseVisualStyleBackColor = true;
            this.BtnResetTabIn.Click += new System.EventHandler(this.ResetTabIn);
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
            this.DTRepeatEndIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTRepeatEndIn.Location = new System.Drawing.Point(458, 174);
            this.DTRepeatEndIn.Name = "DTRepeatEndIn";
            this.DTRepeatEndIn.Size = new System.Drawing.Size(120, 20);
            this.DTRepeatEndIn.TabIndex = 13;
            // 
            // DTRepeatStartIn
            // 
            this.DTRepeatStartIn.Enabled = false;
            this.DTRepeatStartIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            // BtnAddIn
            // 
            this.BtnAddIn.Location = new System.Drawing.Point(610, 422);
            this.BtnAddIn.Name = "BtnAddIn";
            this.BtnAddIn.Size = new System.Drawing.Size(75, 23);
            this.BtnAddIn.TabIndex = 10;
            this.BtnAddIn.Text = "BtnAddIn";
            this.BtnAddIn.UseVisualStyleBackColor = true;
            this.BtnAddIn.Click += new System.EventHandler(this.BtnAddIn_Click);
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
            this.DTInReal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTInReal.Location = new System.Drawing.Point(458, 91);
            this.DTInReal.Name = "DTInReal";
            this.DTInReal.Size = new System.Drawing.Size(120, 20);
            this.DTInReal.TabIndex = 7;
            this.DTInReal.EnabledChanged += new System.EventHandler(this.CompletionToggleIn);
            // 
            // DTInDeadline
            // 
            this.DTInDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            this.NuInAmountReal.ValueChanged += new System.EventHandler(this.InOnBudget);
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
            this.NuInAmountPre.ValueChanged += new System.EventHandler(this.InOnBudget);
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
            this.LBIn.SelectedIndexChanged += new System.EventHandler(this.LBIn_SelectedIndexChanged);
            // 
            // TabOut
            // 
            this.TabOut.Controls.Add(this.CBOutCompany);
            this.TabOut.Controls.Add(this.BtnResetTabOut);
            this.TabOut.Controls.Add(this.LaAccomodation);
            this.TabOut.Controls.Add(this.LaFood);
            this.TabOut.Controls.Add(this.BtnAddOut);
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
            // CBOutCompany
            // 
            this.CBOutCompany.FormattingEnabled = true;
            this.CBOutCompany.Location = new System.Drawing.Point(458, 12);
            this.CBOutCompany.Name = "CBOutCompany";
            this.CBOutCompany.Size = new System.Drawing.Size(121, 21);
            this.CBOutCompany.TabIndex = 31;
            // 
            // BtnResetTabOut
            // 
            this.BtnResetTabOut.Location = new System.Drawing.Point(529, 422);
            this.BtnResetTabOut.Name = "BtnResetTabOut";
            this.BtnResetTabOut.Size = new System.Drawing.Size(75, 23);
            this.BtnResetTabOut.TabIndex = 30;
            this.BtnResetTabOut.Text = "BtnResetTabOut";
            this.BtnResetTabOut.UseVisualStyleBackColor = true;
            this.BtnResetTabOut.Click += new System.EventHandler(this.ResetTabOut);
            // 
            // LaAccomodation
            // 
            this.LaAccomodation.AutoSize = true;
            this.LaAccomodation.Location = new System.Drawing.Point(245, 46);
            this.LaAccomodation.Name = "LaAccomodation";
            this.LaAccomodation.Size = new System.Drawing.Size(87, 13);
            this.LaAccomodation.TabIndex = 29;
            this.LaAccomodation.Text = "LaAccomodation";
            // 
            // LaFood
            // 
            this.LaFood.AutoSize = true;
            this.LaFood.Location = new System.Drawing.Point(245, 32);
            this.LaFood.Name = "LaFood";
            this.LaFood.Size = new System.Drawing.Size(43, 13);
            this.LaFood.TabIndex = 28;
            this.LaFood.Text = "LaFood";
            // 
            // BtnAddOut
            // 
            this.BtnAddOut.Location = new System.Drawing.Point(610, 422);
            this.BtnAddOut.Name = "BtnAddOut";
            this.BtnAddOut.Size = new System.Drawing.Size(75, 23);
            this.BtnAddOut.TabIndex = 27;
            this.BtnAddOut.Text = "BtnAddOut";
            this.BtnAddOut.UseVisualStyleBackColor = true;
            this.BtnAddOut.Click += new System.EventHandler(this.BtnAddOut_Click);
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
            this.DTRepeatEndOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTRepeatEndOut.Location = new System.Drawing.Point(458, 174);
            this.DTRepeatEndOut.Name = "DTRepeatEndOut";
            this.DTRepeatEndOut.Size = new System.Drawing.Size(120, 20);
            this.DTRepeatEndOut.TabIndex = 24;
            // 
            // DTRepeatStartOut
            // 
            this.DTRepeatStartOut.Enabled = false;
            this.DTRepeatStartOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            this.DTOutReal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            this.DTOutDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            this.NuOutAmountPre.ValueChanged += new System.EventHandler(this.OutOnBudget);
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
            this.LBOut.SelectedIndexChanged += new System.EventHandler(this.LBOut_SelectedIndexChanged);
            // 
            // insuranceToolStripMenuItem
            // 
            this.insuranceToolStripMenuItem.Name = "insuranceToolStripMenuItem";
            this.insuranceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.insuranceToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.insuranceToolStripMenuItem.Text = "&Insurance";
            this.insuranceToolStripMenuItem.Click += new System.EventHandler(this.insuranceToolStripMenuItem_Click);
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
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.RCMTime.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox TBInComment;
        private System.Windows.Forms.DateTimePicker DTInReal;
        private System.Windows.Forms.DateTimePicker DTInDeadline;
        private System.Windows.Forms.NumericUpDown NuInAmountReal;
        private System.Windows.Forms.NumericUpDown NuInAmountPre;
        private System.Windows.Forms.TextBox TBInName;
        private System.Windows.Forms.Button BtnAddIn;
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
        private System.Windows.Forms.Button BtnAddOut;
        private System.Windows.Forms.TextBox TBOutComment;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.CheckBox CBInCompleted;
        private System.Windows.Forms.Label LaFood;
        private System.Windows.Forms.Label LaAccomodation;
        private System.Windows.Forms.ContextMenuStrip RCMTime;
        private System.Windows.Forms.ToolStripMenuItem RCMAnual;
        private System.Windows.Forms.ToolStripMenuItem RCMTerm;
        private System.Windows.Forms.ToolStripMenuItem RCMQuarter;
        private System.Windows.Forms.ToolStripMenuItem RCMMonth;
        private System.Windows.Forms.ToolStripMenuItem RCMWeek;
        private System.Windows.Forms.ToolStripMenuItem transactionModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anualyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quarterlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyToolStripMenuItem;
        private System.Windows.Forms.Button BtnResetTabIn;
        private System.Windows.Forms.Button BtnResetTabOut;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RCMReset;
        private System.Windows.Forms.ComboBox CBInCompany;
        private System.Windows.Forms.ComboBox CBOutCompany;
        private System.Windows.Forms.ToolStripMenuItem insuranceToolStripMenuItem;
    }
}

