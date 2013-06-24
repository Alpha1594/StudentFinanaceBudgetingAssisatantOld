﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace StudentFinanaceBudgetingAssisatant
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            foreach (string str in CategorieIn)
            {
                CBInCategory.Items.Add(str);
            }

            foreach (string str in CategoriesOut)
            {
                CBOutCategory.Items.Add(str);
            }
            LoadData();
            Total();
        }

        #region SharedVaribles
        public enum Type { In, Out };
        public enum RepeatFreq { Weekly, Monthly, Quarterly, Termly, Anualy };
        public RepeatFreq RF = RepeatFreq.Anualy;
        string[] CategorieIn = { "Loan- Student Finance", "Grant -Student Finance", "Bursary", "Job" };
        string[] CategoriesOut = { "Food", "Accomodation" };
        decimal BreakEvenThreshold = 20;    // Temp Val TODO replace with user set value.
        public decimal TotalIncome;
        public decimal TotalOutcome;
        public decimal Food;
        public decimal Accomodation;
        public decimal Balance;
        public StoredData SD;
        public int LimNextTranaction = 10;
        public int LimTransactionsToProcess = 10;

        public struct Transactions{
            public string Name;
            public string Category;
            public string Type;
            public decimal AmountPre;
            public decimal AmountReal;
            public bool Completed;
            public string[] Comment;
            public DateTime Deadline;
            public DateTime ProcessedOn;
            public bool Repeat;
            public DateTime RepeatStart;
            public DateTime RepeatEnd;
            public string RepeatFreq;

            public Transactions(string Name, string Category, string Type, decimal AmountPre, decimal AmountReal,
                bool Completed, string[] Comment, DateTime Deadline, DateTime ProcessedOn, bool Repeat, 
                DateTime RepeatStart, DateTime RepeatEnd, string RepeatFreq)
            {
				this.Name = Name;
				this.Category = Category;
                this.Type = Type;
				this.AmountPre = AmountPre;
				this.AmountReal = AmountReal;
				this.Completed = Completed;
				this.Comment = Comment;
				this.Deadline = Deadline;
				this.ProcessedOn = ProcessedOn;
				this.Repeat = Repeat;
				this.RepeatStart = RepeatStart;
				this.RepeatEnd = RepeatEnd;
                this.RepeatFreq = RepeatFreq;
            }
        }

        public struct StoredData
        {
            public List<Transactions> In;
            public List<Transactions> Out;
            public StoredData(List<Transactions> Income, List<Transactions> Outcome)
            {
                this.In = Income;
                this.Out = Outcome;
            }
        }

        public struct TotalPerTime
        {
            public decimal Previous;
            public decimal Current;
            public TotalPerTime(decimal Previous, decimal Current)
            {
                this.Previous = Previous;
                this.Current = Current;
            }
        }
        public TotalPerTime InAnualy;
        public TotalPerTime InTermly;
        public TotalPerTime InQuarterly;
        public TotalPerTime InMonthly;
        public TotalPerTime InWeekly;

        public TotalPerTime OutAnualy;
        public TotalPerTime OutTermly;
        public TotalPerTime OutQuarterly;
        public TotalPerTime OutMonthly;
        public TotalPerTime OutWeekly;

        public struct Configuration
        {
            public DateTime StartT1;
            public DateTime EndT1;
            public DateTime StartT2;
            public DateTime EndT2;
            public DateTime StartT3;
            public DateTime EndT3;

            public Configuration(DateTime ST1, DateTime ET1, DateTime ST2, DateTime ET2, DateTime ST3, DateTime ET3)
            {
                this.StartT1 = ST1;
                this.EndT1 = ET1;
                this.StartT2 = ST2;
                this.EndT2 = ET2;
                this.StartT3 = ST3;
                this.EndT3 = ET3;
            }
        }

        public Configuration RC = new Configuration();
        
        #endregion

        #region In
        public List<Transactions> Income = new List<Transactions>();

        private void GotoTabIn(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void CompletionToggleIn(object sender, EventArgs e)
        {
            if (CBInCompleted.Checked == true)
            {
                NuInAmountReal.Enabled = true;
                DTInReal.Enabled = true;

                // Add check to avoid overwriting existing values.
                NuInAmountReal.Value = NuInAmountPre.Value;
                DTInReal.Value = DateTime.Now;
            }
            else
            {
                NuInAmountReal.Enabled = false;
                DTInReal.Enabled = false;
            }
        }

        private void ToggleRepeatIn(object sender, EventArgs e)
        {
            if (CBInRepeat.Checked == true)
            {
                DTRepeatStartIn.Enabled = true;
                DTRepeatEndIn.Enabled = true;
                CBRepeatFreqIn.Enabled = true;
            }
            else
            {
                DTRepeatStartIn.Enabled = false;
                DTRepeatEndIn.Enabled = false;
                CBRepeatFreqIn.Enabled = false;
            }
        }

        private void BtnAddIn_Click(object sender, EventArgs e)
        {
            Transactions temp = new Transactions(TBInName.Text, CBInCategory.Text, Type.In.ToString(),
                NuInAmountPre.Value, (DTInDeadline.Checked == true? NuInAmountReal.Value : 0),
                DTInDeadline.Checked, TBInComment.Lines, DTInDeadline.Value, DTInReal.Value,
                CBInRepeat.Checked, DTRepeatStartIn.Value, DTRepeatEndIn.Value,
                CBRepeatFreqIn.Text);

            Income.Add(temp);
            
            if (sender.ToString().Contains("Update"))
            {
                Income.RemoveAt(LBIn.SelectedIndex);
                BtnAddIn.Text = "BtnAddIn";
            }

            PopulateTransLists();
            WriteToFile(sender, e);
        }

        private void InFmt(object sender, EventArgs e)
        {
            string Input = sender.ToString().Substring(sender.ToString().LastIndexOf(":") + 2);
            // MessageBox.Show(Input);
            LaIn.ForeColor = TxtFormat(TotalIncome);
            In.ForeColor = TxtFormat(TotalIncome);
        }

        private void InOnBudget(object sender, EventArgs e)
        {
            if (NuInAmountReal.Value < NuInAmountPre.Value && CBInCompleted.Checked == true)
                // Red if income < prediction
            {
                NuInAmountReal.BackColor = Color.Red;
                NuInAmountPre.BackColor = Color.Red;
            }
            else
            {
                NuInAmountPre.BackColor = Color.White;
                NuInAmountReal.BackColor = Color.White;
            }
        }
        
        private void LBIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBIn.SelectedIndex;
            if (index == -1)
                return;
            else
            {
                TBInName.Text = Income[index].Name;
                CBInCategory.Text = Income[index].Category;
                NuInAmountPre.Value = Income[index].AmountPre;
                DTInDeadline.Value = Income[index].Deadline;
                NuInAmountReal.Value = Income[index].AmountReal;
                DTInReal.Value = Income[index].ProcessedOn;
                CBInCompleted.Checked = Income[index].Completed;
                CBInRepeat.Checked = Income[index].Repeat;
                DTRepeatStartIn.Value = Income[index].RepeatStart;
                DTRepeatEndIn.Value = Income[index].RepeatEnd;
                CBRepeatFreqOut.Text = Income[index].RepeatFreq;
                TBInComment.Lines = Income[index].Comment;

                BtnAddIn.Text = "Update";
            }
        }

        private void ResetTabIn(object sender, EventArgs e)
        {
            TextBox[] TB = { TBInName, TBInComment};
            foreach (TextBox T in TB)
            {
                T.Clear();
            }

            ComboBox[] CB = { CBInCategory, CBRepeatFreqIn};
            foreach (ComboBox C in CB)
            {
                C.Text = "";
            }

            NumericUpDown[] Nu = { NuInAmountPre, NuInAmountReal};
            foreach (NumericUpDown N in Nu)
            {
                N.Value = 0;
            }

            CheckBox[] cb = { CBInCompleted, CBInRepeat};
            foreach (CheckBox c in cb)
            {
                c.Checked = false;
            }

            DateTimePicker[] DTP = { DTInDeadline, DTInReal};
            foreach (DateTimePicker D in DTP)
            {
                D.Value = DateTime.Today;
            }
            BtnAddIn.Text = "BtnAddIn";
            LBIn.SelectedIndex = -1;
        }

        #endregion

        #region Out
        public List<Transactions> Outcome = new List<Transactions>();

        private void GotoTabOut(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void CompletionToggleOut(object sender, EventArgs e)
        {
            if (CBOutCompleted.Checked == true)
            {
                NuOutAmountReal.Enabled = true;
                DTOutReal.Enabled = true;

                // Add check to avoid overwriting existing values.
                NuOutAmountReal.Value = NuOutAmountPre.Value;
                DTOutReal.Value = DateTime.Now;
            }
            else
            {
                NuOutAmountReal.Enabled = false;
                DTOutReal.Enabled = false;
            }
        }

        private void ToggleRepeatOut(object sender, EventArgs e)
        {
            if (CBOutRepeat.Checked == true)
            {
                DTRepeatStartOut.Enabled = true;
                DTRepeatEndOut.Enabled = true;
                CBRepeatFreqOut.Enabled = true;
            }
            else
            {
                DTRepeatStartOut.Enabled = false;
                DTRepeatEndOut.Enabled = false;
                CBRepeatFreqOut.Enabled = false;
            }
        }

        private void BtnAddOut_Click(object sender, EventArgs e)
        {
            Transactions temp = new Transactions(TBOutName.Text, CBOutCategory.Text, Type.Out.ToString(),
                NuOutAmountPre.Value, (CBOutCompleted.Checked == true ? NuOutAmountReal.Value : 0),
                CBOutRepeat.Checked, TBOutComment.Lines, DTOutDeadline.Value, DTOutReal.Value,
                CBOutRepeat.Checked, DTRepeatStartOut.Value, DTRepeatEndOut.Value,
                CBRepeatFreqIn.Text);

            if (sender.ToString().Contains("Update"))
            {
                Outcome.RemoveAt(LBOut.SelectedIndex);
                BtnAddOut.Text = "BtnAddOut";
            }

            Outcome.Add(temp);
            PopulateTransLists();
            WriteToFile(sender, e);
        }

        private void OutFmt(object sender, EventArgs e)
        {
            Color ColorCode;
            if (TotalOutcome > TotalIncome)
            {
                ColorCode = Color.Red;
            }
            else if (Balance > BreakEvenThreshold)
            {
                ColorCode = Color.Green;
            }
            else
            {
                ColorCode = Color.Black;
            }
            //MessageBox.Show(ColorCode.ToString());
            LaOut.ForeColor = ColorCode;
            Out.ForeColor = ColorCode;
        }

        private void ResultantFmt(object sender, EventArgs e)
        {
            string Input = sender.ToString().Substring(sender.ToString().LastIndexOf(":") + 2);
            Resultant.ForeColor = TxtFormat(Balance);
            OutFmt(sender, e);
        }

        private void OutOnBudget(object sender, EventArgs e)
        {
            if (NuOutAmountReal.Value > NuOutAmountPre.Value)
            {
                NuOutAmountReal.BackColor = Color.Red;
                NuOutAmountPre.BackColor = Color.Red;
            }
            else
            {
                NuOutAmountPre.BackColor = Color.White;
                NuOutAmountReal.BackColor = Color.White;
            }
        }
        
        private void LBOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBOut.SelectedIndex;
            if (index == -1)
                return;
            else
            {
                TBOutName.Text = Outcome[index].Name;
                CBOutCategory.Text = Outcome[index].Category;
                NuOutAmountPre.Value = Outcome[index].AmountPre;
                DTOutDeadline.Value = Outcome[index].Deadline;
                NuOutAmountReal.Value = Outcome[index].AmountReal;
                DTOutReal.Value = Outcome[index].ProcessedOn;
                CBOutCompleted.Checked = Outcome[index].Completed;
                CBOutRepeat.Checked = Outcome[index].Repeat;
                DTRepeatStartOut.Value = Outcome[index].RepeatStart;
                DTRepeatEndOut.Value = Outcome[index].RepeatEnd;
                CBRepeatFreqOut.Text = Outcome[index].RepeatFreq;
                TBOutComment.Lines = Outcome[index].Comment;

                BtnAddOut.Text = "Update";
            }
        }

        private void ResetTabOut(object sender, EventArgs e)
        {
            TextBox[] TB = { TBOutComment, TBOutName };
            foreach (TextBox T in TB)
            {
                T.Clear();
            }

            ComboBox[] CB = { CBOutCategory, CBRepeatFreqOut };
            foreach (ComboBox C in CB)
            {
                C.Text = "";
            }

            NumericUpDown[] Nu = { NuOutAmountPre, NuOutAmountReal };
            foreach (NumericUpDown N in Nu)
            {
                N.Value = 0;
            }

            CheckBox[] cb = { CBOutCompleted, CBOutRepeat };
            foreach (CheckBox c in cb)
            {
                c.Checked = false;
            }

            DateTimePicker[] DTP = { DTOutDeadline, DTOutReal };
            foreach (DateTimePicker D in DTP)
            {
                D.Value = DateTime.Today;
            }
            BtnAddOut.Text = "BtnAddOut";
            LBOut.SelectedIndex = -1;
        }

        #endregion

		#region Common
        private Color TxtFormat(decimal Input)
		{
            //if (Input < 0)
            //{
            //    return Color.Red;
            //}
            //else if (Input >= BreakEvenThreshold)
            //{
            //    return Color.Green;
            //}
            //else
            //{
            //    return Color.Black;
            //}
            return Input < 0 ? Color.Red : Input >= BreakEvenThreshold ? Color.Green : Color.Black;
        }

        private void Total() // Calculates Income, Outcome & balance && Updates GUI
        {
            TotalIncome = 0;
            TotalOutcome = 0;
            Food = 0;
            Accomodation = 0;
            Balance = 0;
            InMonthly.Current = 0;
            InMonthly.Previous = 0;
            OutMonthly.Current = 0;
            OutMonthly.Previous = 0;

            foreach (Transactions T in Income)
            {
                TotalIncome += (T.AmountReal == 0 ? T.AmountPre : T.AmountReal);

                if (T.Deadline.Month == DateTime.Today.Month)
                {
                    InMonthly.Current += (T.AmountReal == 0 ? T.AmountPre : T.AmountReal);
                }
                else if (T.Deadline.Month < DateTime.Today.Month)
                {
                    InMonthly.Previous += (T.AmountReal == 0 ? T.AmountPre : T.AmountReal);
                }
            }

            foreach (Transactions U in Outcome)
            {
                TotalOutcome += (U.AmountReal == 0 ? U.AmountPre : U.AmountReal);
                

                if (U.Deadline.Month == DateTime.Today.Month)
                {
                    OutMonthly.Current += (U.AmountReal == 0 ? U.AmountPre : U.AmountReal);
                    switch (U.Category)
                    {
                        case "Food":
                            Food += (U.AmountReal == 0 ? U.AmountPre : U.AmountReal);
                            break;
                        case "Accomodation":
                            Accomodation += (U.AmountReal == 0 ? U.AmountPre : U.AmountReal);
                            break;
                        default:
                            break;
                    }
                }
                else if (U.Deadline.Month < DateTime.Today.Month)
                {
                    OutMonthly.Previous += (U.AmountReal == 0 ? U.AmountPre : U.AmountReal);
                }
            }

            if (RF == RepeatFreq.Monthly)
            {
                TotalIncome = InMonthly.Current;
                TotalOutcome = OutMonthly.Current;
            }

            In.Text = "£ " + TotalIncome.ToString();
            LaIn.Text = "£ " + TotalIncome.ToString();

            Out.Text = "£ " + TotalOutcome.ToString();
            LaOut.Text = "£ " + TotalOutcome.ToString();
            LaFood.Text = "£ " + Food.ToString();
            LaAccomodation.Text = "£ " + Accomodation.ToString();

            Balance = TotalIncome - TotalOutcome;
            Resultant.Text = "£ " + Balance.ToString();
        }

        private void WriteToFile(object sender, EventArgs e)
        {
            SD = new StoredData(Income, Outcome);
                // Package data into one object for export
            XmlSerializer XSR = new XmlSerializer(typeof(StoredData));
            FileStream DataOut = new FileStream("Finances.xml", FileMode.Create);
            XSR.Serialize(DataOut, SD);
            DataOut.Close();

        }

        private void LoadData()
        {
            XmlSerializer XSR = new XmlSerializer(typeof(StoredData));
            PopulateList:
            if (File.Exists("Finances.xml"))
            {
                FileStream FS = new FileStream("Finances.xml", FileMode.Open);
                if (FS.Length > 0)
                {
                    SD = (StoredData)XSR.Deserialize(FS);
                }
                FS.Close();
                Income = SD.In;
                Outcome = SD.Out;
                PopulateTransLists();
            }
            else
            {
                FileStream FS = new FileStream("Finances.xml", FileMode.CreateNew);
                FS.Close();
                goto PopulateList;
            }
        }

        private void PopulateTransLists()
        {
            LBIn.Items.Clear();
            foreach (Transactions I in Income)
            {
                string ListElement = I.Name + " £" + (I.Completed ? I.AmountReal : I.AmountPre);
                LBIn.Items.Add(ListElement);
            }

            LBOut.Items.Clear();
            foreach (Transactions O in Outcome)
            {
                string ListElement = O.Name + " £" + (O.Completed ? O.AmountReal : O.AmountPre);
                LBOut.Items.Add(ListElement);
            }
            Total();
        }

        public void StoreConfig()
        {
            XmlSerializer XSR = new XmlSerializer(typeof(Configuration));
            FileStream ConfigStream = new FileStream("Finances.rc", FileMode.Create);
            XSR.Serialize(ConfigStream, RC);
            ConfigStream.Close();
        }

        public void LoadConfig()
        {
            XmlSerializer XSR = new XmlSerializer(typeof(Configuration));
            Load:
            if (File.Exists("Finances.rc"))
            {
                FileStream ConfigStream = new FileStream("Finances.rc", FileMode.Open);
                if (ConfigStream.Length > 0)
                {
                    RC = (Configuration)XSR.Deserialize(ConfigStream);
                }
                ConfigStream.Close();
            }
            else
            {
                FileStream FS = new FileStream("Finances.rc", FileMode.Create);
                FS.Close();
                goto Load;
            }
        }
		#endregion

        private void EditConfig(object sender, EventArgs e)
        {
            Config C = new Config();
            C.ShowDialog();
        }

        #region TransactionMode
        private void RCMAnual_Click(object sender, EventArgs e)
        {
            RF = RepeatFreq.Anualy;
            MessageBox.Show(RF.ToString());
            Total();
        }

        private void RCMTerm_Click(object sender, EventArgs e)
        {
            RF = RepeatFreq.Termly;
            MessageBox.Show(RF.ToString());
            Total();
        }

        private void RCMQuarter_Click(object sender, EventArgs e)
        {
            RF = RepeatFreq.Quarterly;
            MessageBox.Show(RF.ToString());
            Total();
        }

        private void RCMMonth_Click(object sender, EventArgs e)
        {
            RF = RepeatFreq.Monthly;
            MessageBox.Show(RF.ToString());
            Total();
        }

        private void RCMWeek_Click(object sender, EventArgs e)
        {
            RF = RepeatFreq.Weekly;
            MessageBox.Show(RF.ToString());
            Total();
        }
        #endregion
    }
}
