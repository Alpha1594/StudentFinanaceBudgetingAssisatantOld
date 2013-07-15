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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            LoadConfig();
            string[] DayOfWeek = { Day.Sunday.ToString(), 
                                     Day.Monday.ToString(), Day.Tuesday.ToString(),
                                     Day.Wednesday.ToString(), Day.Thursday.ToString(),
                                     Day.Friday.ToString(), Day.Saturday.ToString()};
            CBWeekStarts.Items.AddRange(DayOfWeek);
            CBWeekStarts.SelectedIndex = 1;
            NUYear.Maximum = YearRecords.Count > 0 ? YearRecords.Count : 1; //Max=1 if list !populated
        }

        private void BtnSaveConfig_Click(object sender, EventArgs e)
        {
            StoreConfig();
        }

		public struct TermData
		{
			public DateTime TermStart;
			public DateTime TermEnd;
			public decimal Grant;
			public decimal Loan;
			public DateTime SFPayment;
			public decimal Bursary;
			public DateTime BPayment;

			public TermData(DateTime TermStart, DateTime TermEnd, decimal Grant,
		        decimal Loan, DateTime SFPayment, decimal Bursary,
		        DateTime BPayment)
			{
				this.TermStart = TermStart;
				this.TermEnd = TermEnd;
				this.Grant = Grant;
				this.Loan = Loan;
				this.SFPayment = SFPayment;
				this.Bursary = Bursary;
				this.BPayment = BPayment;
			}
		}

        public struct YearInfo
        {
            public bool YearInIndustry;
            public TermData T1;
            public TermData T2;
            public TermData T3;

            public YearInfo(bool YearInIndustry, TermData T1, TermData T2, TermData T3)
            {
                this.YearInIndustry = YearInIndustry;
                this.T1 = T1;
                this.T2 = T2;
                this.T3 = T3;
            }
        }

        public List<YearInfo> YearRecords = new List<YearInfo>();

		public struct CompanyInfo
		{
			public string Name;
			public string Category;
			public string email;
			public string website;
			public int delay;
			public string[] Comments;

			public CompanyInfo(string Name, string Category, string email,
			    string website, int delay, string[] Comments)
			{
				this.Name = Name;
				this.Category = Category;
				this.email = email;
				this.website = website;
				this.delay = delay;
				this.Comments = Comments;
			}
		}

        public List<CompanyInfo> ComInfo = new List<CompanyInfo>();

		public struct Configuration
		{
			public DayOfWeek StartDay;
			public int CurrentYear;
			public List<YearInfo> YearInfo;

			public Configuration(int StartDay, decimal CurrentYear,
                List<YearInfo> YearInfo)
			{
				this.StartDay = (DayOfWeek) StartDay;
				this.CurrentYear = (int) CurrentYear;
				this.YearInfo = YearInfo;
			}
		}

        public Configuration RC;

        public void StoreConfig()
        {
            TermData T1 = new TermData(DTT1S.Value, DTT1E.Value, NuSFT1Grant.Value, NuSFT1Loan.Value,
                DTSFP1.Value, NUBT1.Value, DTBT1.Value);
            TermData T2 = new TermData(DTT2S.Value, DTT2E.Value, NuSFT2Grant.Value, NuSFT2Loan.Value,
                DTSFP2.Value, NUBT2.Value, DTBT2.Value);
            TermData T3 = new TermData(DTT3S.Value, DTT3E.Value, NuSFT3Grant.Value, NuSFT3Loan.Value,
                DTSFP3.Value, NUBT3.Value, DTBT3.Value);

            YearInfo YI = new YearInfo(CBYII.Checked, T1 , T2, T3);

            int year = (int) NUYear.Value - 1;  //0 based index
            if (YearRecords.Count > 0)
            {
                if (YearRecords.Count >= year)
                    YearRecords[year] = YI;
            }
            else YearRecords.Add(YI);

                RC = new Configuration(CBWeekStarts.SelectedIndex, NUYear.Value, YearRecords);
            XmlSerializer XSR = new XmlSerializer(typeof(Configuration));
            FileStream ConfigStream = new FileStream("Finances.rc", FileMode.Create);
            try
            {
                XSR.Serialize(ConfigStream, RC);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.GetBaseException().ToString());
            }
            ConfigStream.Close();
            LoadConfig();
            MessageBox.Show("Configurations recorded");
            MessageBox.Show(YearRecords.Count.ToString());
        }

        public void LoadConfig()
        {
            XmlSerializer XSR = new XmlSerializer(typeof(Configuration));
            if (File.Exists("Finances.rc"))
            {
                FileStream ConfigStream = new FileStream("Finances.rc", FileMode.Open);
                if (ConfigStream.Length > 0)
                {
                    RC = (Configuration)XSR.Deserialize(ConfigStream);

                    ConfigStream.Close();

                    NUYear.Value = RC.CurrentYear;
                    CBWeekStarts.Text = RC.StartDay.ToString();
                    // Rest of values set by NUYear eventhandler

                }
            }
            else
            {
                FileStream FS = new FileStream("Finances.rc", FileMode.Create);
                FS.Close();
                return;
            }
        }

        private void YearSelected(object sender, EventArgs e)
        {
            int year = (int) NUYear.Value-1;

            if (year < 0 || year > 10)
                return;

            /* TermDates */
            DTT1S.Value = RC.YearInfo[year].T1.TermStart;
            DTT1E.Value = RC.YearInfo[year].T1.TermEnd;
            DTT2S.Value = RC.YearInfo[year].T2.TermStart;
            DTT2E.Value = RC.YearInfo[year].T2.TermEnd;
            DTT3S.Value = RC.YearInfo[year].T3.TermStart;
            DTT3E.Value = RC.YearInfo[year].T3.TermEnd;

            /* SF */
            DTSFP1.Value = RC.YearInfo[year].T1.SFPayment;
            NuSFT1Grant.Value = RC.YearInfo[year].T1.Grant;
            NuSFT1Loan.Value = RC.YearInfo[year].T1.Loan;
            DTSFP2.Value = RC.YearInfo[year].T2.SFPayment;
            NuSFT2Grant.Value = RC.YearInfo[year].T2.Grant;
            NuSFT2Loan.Value = RC.YearInfo[year].T2.Loan;
            DTSFP3.Value = RC.YearInfo[year].T3.SFPayment;
            NuSFT3Grant.Value = RC.YearInfo[year].T3.Grant;
            NuSFT3Loan.Value = RC.YearInfo[year].T3.Loan;

            /* Bursary */
            NUBT1.Value = RC.YearInfo[year].T1.Bursary;
            DTBT1.Value = RC.YearInfo[year].T1.BPayment;
            NUBT2.Value = RC.YearInfo[year].T2.Bursary;
            DTBT2.Value = RC.YearInfo[year].T2.BPayment;
            NUBT3.Value = RC.YearInfo[year].T3.Bursary;
            DTBT3.Value = RC.YearInfo[year].T3.BPayment;

            CBYII.Checked = RC.YearInfo[year].YearInIndustry;
            string strDay =RC.StartDay.ToString();
            //MessageBox.Show(strDay);
            CBWeekStarts.Text = strDay;
            MessageBox.Show(CBWeekStarts.Text + "\n" + DayOfWeek.Sunday.ToString());
            MessageBox.Show(CBWeekStarts.Text.CompareTo(DayOfWeek.Sunday.ToString()).ToString());
                // The above are != (ret 0 (bool)=false) 

            // CBWeekStarts.SelectedIndex = 1+ (int)RC.StartDay;
        }
    }
}
