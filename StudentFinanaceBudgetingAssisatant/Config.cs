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
        }

        private void BtnSaveConfig_Click(object sender, EventArgs e)
        {
            StoreConfig();
        }

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

            public Configuration(DateTime ST1, DateTime ET1, DateTime ST2, DateTime ET2, DateTime ST3,
                DateTime ET3, DateTime Trans1Date, decimal Trans1Grant, decimal Trans1Loan,
             DateTime Trans2Date, decimal Trans2Grant, decimal Trans2Loan, DateTime Trans3Date,
             decimal Trans3Grant, decimal Trans3Loan, decimal BursaryAmount, string BursaryPaymentFrequency)
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
            }
        }

        public Configuration RC;// = new Configuration();

        public void StoreConfig()
        {
            RC = new Configuration(DTT1S.Value, DTT1E.Value, DTT2S.Value, DTT2E.Value, DTT3S.Value,
                DTT3E.Value, DTSFP1.Value, NuSFT1Grant.Value, NuSFT1Loan.Value, DTSFP2.Value,
                NuSFT2Grant.Value, NuSFT2Loan.Value, DTSFP3.Value, NuSFT3Grant.Value, NuSFT3Loan.Value,
                NuBA.Value, CBBF.Text);
            XmlSerializer XSR = new XmlSerializer(typeof(Configuration));
            FileStream ConfigStream = new FileStream("Finances.rc", FileMode.Create);
            XSR.Serialize(ConfigStream, RC);
            ConfigStream.Close();
            LoadConfig();
            MessageBox.Show("Configurations recorded");
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
                }
                ConfigStream.Close();
                DTT1S.Value = RC.StartT1;
                DTT1E.Value = RC.EndT1;
                DTT2S.Value = RC.StartT2;
                DTT2E.Value = RC.EndT2;
                DTT3S.Value = RC.StartT3;
                DTT3E.Value = RC.EndT3;
				DTSFP1.Value = RC.Trans1Date;
				NuSFT1Grant.Value = RC.Trans1Grant;
				NuSFT1Loan.Value = RC.Trans1Loan;
				DTSFP2.Value = RC.Trans2Date;
				NuSFT2Grant.Value = RC.Trans2Grant;
				NuSFT2Loan.Value = RC.Trans2Loan;
				DTSFP3.Value = RC.Trans3Date;
				NuSFT3Grant.Value = RC.Trans3Grant;
                NuSFT3Loan.Value = RC.Trans3Loan;
                NuBA.Value = RC.BursaryAmount;
                CBBF.Text = RC.BursaryPaymentFrequency;
            }
            else
            {
                FileStream FS = new FileStream("Finances.rc", FileMode.Create);
                FS.Close();
                return;
            }
        }
    }
}
