using System;
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
			if (HasData)
			{
				PopulateTransLists();
				Total();
			}
        }

        #region SharedVaribles
        public enum Type { In, Out };
        public enum RepeatFreq { Weekly, Monthly, Quarterly, Termly, Anualy, Everything};
        public RepeatFreq RF = RepeatFreq.Everything;

        string[] CategorieIn = { "Loan- Student Finance", "Grant -Student Finance", "Bursary", "Job" };
        string[] CategoriesOut = { "Food", "Accomodation" };
        public decimal BreakEvenThreshold = 20;    // Temp Val TODO replace with user set value.
        public decimal TotalIncome;
        public decimal TotalOutcome;
        public decimal Food;
        public decimal Accomodation;
        public decimal Balance;
        public int LimNextTranaction = 10;
        public int LimTransactionsToProcess = 10;

        public bool HasData = false;

        public struct Transactions{
            public string Name;
            public string Company;
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

            public Transactions(string Name, string Company, string Category, string Type, decimal AmountPre, decimal AmountReal,
                bool Completed, string[] Comment, DateTime Deadline, DateTime ProcessedOn, bool Repeat, 
                DateTime RepeatStart, DateTime RepeatEnd, string RepeatFreq)
            {
				this.Name = Name;
                this.Company = Company;
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
        public List<Transactions> Income = new List<Transactions>();
        public List<Transactions> Outcome = new List<Transactions>();

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
        public StoredData SD;

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
            public DateTime Trans1Date;
            public decimal Trans1Grant;
            public decimal Trans1Loan;
            public DateTime Trans2Date;
            public decimal Trans2Grant;
            public decimal Trans2Loan;
            public DateTime Trans3Date;
            public decimal Trans3Grant;
            public decimal Trans3Loan;
            public decimal BursaryAmount;
            public string BursaryPaymentFrequency;
            public DayOfWeek StartDay;

            public Configuration(DateTime ST1, DateTime ET1, DateTime ST2, DateTime ET2, DateTime ST3,
                DateTime ET3, DateTime Trans1Date, decimal Trans1Grant, decimal Trans1Loan,
             DateTime Trans2Date, decimal Trans2Grant, decimal Trans2Loan, DateTime Trans3Date,
             decimal Trans3Grant, decimal Trans3Loan, decimal BursaryAmount, string BursaryPaymentFrequency,
                int StartDay)
            {
                this.StartT1 = ST1;
                this.EndT1 = ET1;
                this.StartT2 = ST2;
                this.EndT2 = ET2;
                this.StartT3 = ST3;
                this.EndT3 = ET3;
                this.Trans1Date = Trans1Date;
                this.Trans1Grant = Trans1Grant;
                this.Trans1Loan = Trans1Loan;
                this.Trans2Date = Trans2Date;
                this.Trans2Grant = Trans2Grant;
                this.Trans2Loan = Trans2Loan;
                this.Trans3Date = Trans3Date;
                this.Trans3Grant = Trans3Grant;
                this.Trans3Loan = Trans3Loan;
                this.BursaryAmount = BursaryAmount;
                this.BursaryPaymentFrequency = BursaryPaymentFrequency;
                this.StartDay = (DayOfWeek)StartDay;
            }
        }
        public Configuration RC = new Configuration();

        public struct Company
        {
            public string Name;
            public string DefaultCategory;
            public int ProcessingTime;
            public string[] Comments;
        }
        #endregion

        #region In
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
            Transactions temp = new Transactions(
TBInName.Text,
CBInCompany.Text,
CBInCategory.Text,
Type.In.ToString(),
NuInAmountPre.Value,

(DTInDeadline.Checked == true? NuInAmountReal.Value : 0),

CBInCompleted.Checked,
TBInComment.Lines,
DTInDeadline.Value,
DTInReal.Value,
CBInRepeat.Checked,
DTRepeatStartIn.Value,
DTRepeatEndIn.Value,
CBRepeatFreqIn.Text);
            Income.Add(temp);

            if (sender.ToString().Contains("Update"))
            {
                Income.RemoveAt(LBIn.SelectedIndex);
                BtnAddIn.Text = "BtnAddIn";
            }
            ResetTabIn(sender, e);
            PopulateTransLists();
			Total();
            WriteToFile(sender, e);
        }

        private void InFmt(object sender, EventArgs e)
        {
            string Input = sender.ToString().Substring(sender.ToString().LastIndexOf(":") + 2);
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
                CBInCompany.Text = Income[index].Company;
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
            Transactions temp = new Transactions(TBOutName.Text, CBOutCompany.Text, CBOutCategory.Text,
                Type.Out.ToString(), NuOutAmountPre.Value, (CBOutCompleted.Checked ? NuOutAmountReal.Value : 0),
                CBOutCompleted.Checked, TBOutComment.Lines, DTOutDeadline.Value, DTOutReal.Value,
                CBOutRepeat.Checked, DTRepeatStartOut.Value, DTRepeatEndOut.Value, CBRepeatFreqOut.Text);
            Outcome.Add(temp);

            if (sender.ToString().Contains("Update"))
            {
                Outcome.RemoveAt(LBOut.SelectedIndex);
                BtnAddOut.Text = "BtnAddOut";
            }
            ResetTabOut(sender, e);
            PopulateTransLists();
			Total();
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
                CBOutCompany.Text = Outcome[index].Company;
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
            return Input < 0 ? Color.Red : Input >= BreakEvenThreshold ? Color.Green : Color.Black;
        }

        private void Total() // Calculates Income, Outcome & balance && Updates GUI
        {
            #region Reset Values
            TotalIncome = 0;
            TotalOutcome = 0;
            Food = 0;
            Accomodation = 0;
            Balance = 0;
            InWeekly.Current = 0;
            InWeekly.Previous = 0;
            InMonthly.Current = 0;
            InMonthly.Previous = 0;
            InTermly.Current = 0;
            InTermly.Previous = 0;
            InQuarterly.Current = 0;
            InQuarterly.Previous = 0;
            InAnualy.Current = 0;
            InAnualy.Previous = 0;
            OutWeekly.Current = 0;
            OutWeekly.Previous = 0;
            OutMonthly.Current = 0;
            OutMonthly.Previous = 0;
            OutQuarterly.Current = 0;
            OutQuarterly.Previous = 0;
            OutTermly.Current = 0;
            OutTermly.Previous = 0;
            OutAnualy.Current = 0;
            OutAnualy.Previous = 0;
			#endregion

            foreach (Transactions T in Income)
            {
                TotalIncome += (T.AmountReal == 0 ? T.AmountPre : T.AmountReal);

                QuarterTotal(T, true);
                TermTotal(T, true);
                MonthTotal(T, true);
                YearTotal(T, true);
            }

            foreach (Transactions U in Outcome)
            {
                TotalOutcome += (U.AmountReal == 0 ? U.AmountPre : U.AmountReal);

                QuarterTotal(U, false);
                TermTotal(U, false);
                MonthTotal(U, false);
                YearTotal(U, false);
            }

            SetTotal();
            In.Text = "£ " + TotalIncome.ToString();
            LaIn.Text = "£ " + TotalIncome.ToString();

            Out.Text = "£ " + TotalOutcome.ToString();
            LaOut.Text = "£ " + TotalOutcome.ToString();
            LaFood.Text = "£ " + Food.ToString();
            LaAccomodation.Text = "£ " + Accomodation.ToString();

            Balance = TotalIncome - TotalOutcome;
            Resultant.Text = "£ " + Balance.ToString();
            LBOverview();
        }

        private void LBOverview()
		{
            LBNextTransactions.Items.Clear();
            LBTransactionsToProcess.Items.Clear();
            if (HasData)
            {
				LBNextTransactions.Items.Add("##INCOME##");
				LBTransactionsToProcess.Items.Add("##INCOME##");
				foreach(Transactions I in Income)
				{
					if (I.Deadline > DateTime.Today)
						LBNextTransactions.Items.Add(I.Name);
                    if (I.Completed == false)
                        LBTransactionsToProcess.Items.Add(I.Name);
				}

				LBNextTransactions.Items.Add("##OUTCOME##");
				LBTransactionsToProcess.Items.Add("##OUTCOME##");
				foreach(Transactions O in Outcome)
				{
					if (O.Deadline > DateTime.Today)
						LBNextTransactions.Items.Add(O.Name);
                    if (O.Completed == false)
                        LBTransactionsToProcess.Items.Add(O.Name);
				}
			}
		}

		private void SetTotal()
		{
            switch (RF){
                case RepeatFreq.Weekly:
                TotalIncome = InWeekly.Current;
                TotalOutcome = OutWeekly.Current;
                return;

                case RepeatFreq.Monthly:
                TotalIncome = InMonthly.Current;
                TotalOutcome = OutMonthly.Current;
                return;

                case RepeatFreq.Termly:
                TotalIncome = InMonthly.Current;
                TotalOutcome = OutMonthly.Current;
                return;

                case RepeatFreq.Quarterly:
                TotalIncome = InQuarterly.Current;
                TotalOutcome = OutQuarterly.Current;
                return;

                case RepeatFreq.Anualy:
                TotalIncome = InAnualy.Current;
                TotalOutcome = OutAnualy.Current;
                return;

				case RepeatFreq.Everything:
				return;
             }
		}

        #region Week
        private void WeekTotal(Transactions LT, bool IsIn)
        {
            DateTime Start = GetStartOfWeek();
            DateTime End = Start.AddDays(7);
            if (IsIn)
            {
                if (Start < LT.Deadline && LT.Deadline < End)
                {
                    InWeekly.Current += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
                else if (LT.Deadline < Start)
                {
                    InWeekly.Previous += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
            }
            else
            {
                if (Start < LT.Deadline && LT.Deadline < End)
                {
                    OutWeekly.Current += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
                else if (LT.Deadline < Start)
                {
                    OutWeekly.Previous += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
            }
        }

        private DateTime GetStartOfWeek()
        {
            DayOfWeek Start = (DayOfWeek)RC.StartDay;
            DayOfWeek Today = DateTime.Today.DayOfWeek;
            if (Today == Start) // First day so previous 7 to be considered
            {
                return DateTime.Today.Subtract(TimeSpan.FromDays(7));
            }
            else if (Today > Start)
            {
                return DateTime.Today.Subtract(TimeSpan.FromDays(Start - Today));
            }
            else return DateTime.Today.Subtract(TimeSpan.FromDays(Today - Start));
        }
        #endregion

        #region Month
        private void MonthTotal(Transactions LT, bool IsIn)
        {
            if (IsIn)
            {
                if (LT.Deadline.Month == DateTime.Today.Month)
                {
                    InMonthly.Current += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
                else if (LT.Deadline.Month < DateTime.Today.Month)
                {
                    InMonthly.Previous += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
            }
            else
            {
                if (LT.Deadline.Month == DateTime.Today.Month)
                {
                    OutMonthly.Current += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                    switch (LT.Category)
                    {
                        case "Food":
                            Food += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                            break;
                        case "Accomodation":
                            Accomodation += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                            break;
                        default:
                            break;
                    }
                }
                else if (LT.Deadline.Month < DateTime.Today.Month)
                {
                    OutMonthly.Previous += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
            }
        }

        #endregion

        #region Term
        private void TermTotal(Transactions LT, bool IsIn)
        {
            if (IsIn)
            {
                if (GetTerm() == GetTerm(LT.Deadline))
                {
                    InTermly.Current += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
                else if (GetTerm() > GetTerm(LT.Deadline))
                {
                    InTermly.Previous += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
            }
            else
            {
                if (GetTerm() == GetTerm(LT.Deadline))
                {
                    OutTermly.Current += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
                else if (GetTerm() > GetTerm(LT.Deadline))
                {
                    OutTermly.Previous += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
            }
        }

        private int GetTerm()
        {
            DateTime Today = DateTime.Today;

            if (Today < RC.StartT2) return 0;
            else if (Today < RC.StartT3) return 1;
            else return 2;
        }

        private int GetTerm(DateTime Given)
        {
            if (Given < RC.StartT2) return 0;
            else if (Given < RC.StartT3) return 1;
            else return 2;
        }
        #endregion

        #region Quarter
        private void QuarterTotal(Transactions LT, bool IsIn)
        {
            if (IsIn)
            {
                if (GetQuarter() == GetQuarter(LT.Deadline))
                {
                    InQuarterly.Current += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
                else if (GetQuarter() > GetQuarter(LT.Deadline))
                {
                    InQuarterly.Previous += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
            }
            else
            {
                if (GetQuarter() == GetQuarter(LT.Deadline))
                {
                    OutQuarterly.Current += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
                else if (GetQuarter() > GetQuarter(LT.Deadline))
                    OutQuarterly.Previous += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
            }
        }

        private int GetQuarter()
        {
            int ThisMonth = DateTime.Today.Month;
            switch (ThisMonth)
            {
                case 1:
                case 2:
                case 3:
                    return 0;
                case 4:
                case 5:
                case 6:
                    return 1;
                case 7:
                case 8:
                case 9:
                    return 2;
                case 10:
                case 11:
                case 12:
                    return 3;
                default:
                    return -1;
            }
        }

        private int GetQuarter(DateTime Given)
        {
            int Month = Given.Month;
            switch (Month)
            {
                case 1:
                case 2:
                case 3:
                    return 0;
                case 4:
                case 5:
                case 6:
                    return 1;
                case 7:
                case 8:
                case 9:
                    return 2;
                case 10:
                case 11:
                case 12:
                    return 3;
                default:
                    return -1;
            }
        }
        #endregion

        #region Year
        private void YearTotal(Transactions LT, bool IsIn)
        {
            if (IsIn)
            {
                if (GetYear() == GetYear(LT.Deadline))
                {
                    InAnualy.Current += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
                else if (GetYear() > GetYear(LT.Deadline))
                {
                    InAnualy.Previous += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
            }
            else
            {
                if (GetYear() == GetYear(LT.Deadline))
                {
                    OutAnualy.Current += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
                else if (GetYear() > GetYear(LT.Deadline))
                {
                    OutAnualy.Previous += (LT.AmountReal == 0 ? LT.AmountPre : LT.AmountReal);
                }
            }
        }
        
        private int GetYear()
        {
            return DateTime.Today.Year;
        }

        private int GetYear(DateTime Given)
        {
            return Given.Year;
        }

        #endregion

        private void WriteToFile(object sender, EventArgs e)
        {
            SD = new StoredData(Income, Outcome);
                // Package data into one object for export
            XmlSerializer XSR = new XmlSerializer(typeof(StoredData));
            FileStream DataOut = new FileStream("Finances.xml", FileMode.Create);
            XSR.Serialize(DataOut, SD);
            DataOut.Close();
			HasData = true;
        }

        private void LoadData()
        {
            XmlSerializer XSR = new XmlSerializer(typeof(StoredData));
            //PopulateList:
            if (File.Exists("Finances.xml"))
            {
                FileStream FS = new FileStream("Finances.xml", FileMode.Open);
                if (FS.Length > 0)
                {
                    SD = (StoredData)XSR.Deserialize(FS);
                    HasData =true;
                }
                FS.Close();
                Income = SD.In;
                Outcome = SD.Out;
            }
            else
            {
                FileStream FS = new FileStream("Finances.xml", FileMode.CreateNew);
                FS.Close();
                //goto PopulateList;
            }
        }

        private void PopulateTransLists()
        {
            Sort();
            LBIn.Items.Clear();
            LBOut.Items.Clear();
            foreach (Transactions I in Income)
            {
                string ListElement = I.Name + " £" + (I.Completed ? I.AmountReal : I.AmountPre);
                LBIn.Items.Add(ListElement);
            }

            foreach (Transactions O in Outcome)
            {
                string ListElement = O.Name + " £" + (O.Completed ? O.AmountReal : O.AmountPre);
                LBOut.Items.Add(ListElement);
            }
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

        private void SetUp()
        {
            FileStream FS = new FileStream("Finances.xml", FileMode.Open);
            if (FS.Length > 0)
            {
                return;
            }
            else
            {
                FileStream ConfigStream = new FileStream("Finances.rc", FileMode.Open);
                if (ConfigStream.Length > 0)
                {
                    //Transactions GT1 = new Transactions("Grant Term 1", "Student Finance", "",
                    //    Type.In.ToString(), RC.Trans1Grant, RC.Trans1Grant, false, pseudonullStringArray, RC.Trans1Date,
                    //    RC.Trans1Date, false, DateTime.Today, DateTime.Today, "");
                    //Income.Add(GT1);
                }
            }
            FS.Close();
        }

        private void Sort()
        {
                if (HasData)
				{
					Income.Sort((X, Y) => X.Deadline.CompareTo(Y.Deadline));
					Outcome.Sort((X, Y) => X.Deadline.CompareTo(Y.Deadline));
				}
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

        private void RCMReset_Click(object sender, EventArgs e)
        {
            RF = RepeatFreq.Everything;
            MessageBox.Show(RF.ToString());
            Total();
        }
        #endregion
    }
}
