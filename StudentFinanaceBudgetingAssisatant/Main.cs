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
            foreach (string str in Categories)
            {
                CBInCategory.Items.Add(str);
                CBOutCategory.Items.Add(str);
            }
            LoadData();
        }

        #region SharedVaribles
        public enum Type { In, Out };
        enum RepeatFreq { Weekly, Monthly, Quarterly, Termly, Anualy };
        string[] Categories = { "Food", "Accomodation" };
        decimal BreakEvenThreshold = 20;    // Temp Val TODO replace with user set value.
        public decimal TotalIncome;
        public decimal TotalOutcome;
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
                NuInAmountPre.Value, (CBInCompleted.Checked == true? NuInAmountReal.Value : 0),
                CBInCompleted.Checked, TBInComment.Lines, DTInDeadline.Value, DTInReal.Value,
                CBInRepeat.Checked, DTRepeatStartIn.Value, DTRepeatEndIn.Value,
                CBRepeatFreqIn.Text);

            Income.Add(temp);
            PopulateTransLists();
            WriteToFile(sender, e);
        }

        private void InFmt(object sender, EventArgs e)
        {
            string Input = sender.ToString().Substring(sender.ToString().LastIndexOf(":") + 2);
            // MessageBox.Show(Input);
            LaIn.ForeColor = TxtFormat(Input);
            In.ForeColor = TxtFormat(Input);
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
            Resultant.ForeColor = TxtFormat(Input);
            OutFmt(sender, e);
        }

        #endregion

		#region Common
        private Color TxtFormat(string Input)
		{
            try {
                decimal TempCash = decimal.Parse(Input);
                if (TempCash < 0)
                {
                    return Color.Red;
                }
				else if (TempCash >= BreakEvenThreshold)
				{
                    return Color.Green;
				}
				else
				{
                    return Color.Black;
				}
            }
            catch { 
                MessageBox.Show("This is not a number");
                return Color.Black;
            }
        }

        private void Total() // Calculates Income, Outcome & balance && Updates GUI
        {
            TotalIncome = 0;
            TotalOutcome = 0;
            Balance = 0;

            foreach (Transactions T in Income)
            {
                TotalIncome += (T.AmountReal == 0 ? T.AmountPre : T.AmountReal);
            }
            In.Text = TotalIncome.ToString();
            LaIn.Text = TotalIncome.ToString();

            foreach (Transactions U in Outcome)
            {
                TotalOutcome += (U.AmountReal == 0 ? U.AmountPre : U.AmountReal);
            }
            
            Out.Text = TotalOutcome.ToString();
            LaOut.Text = TotalOutcome.ToString();

            Balance = TotalIncome - TotalOutcome;
            Resultant.Text = Balance.ToString();
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
		#endregion
    }
}
