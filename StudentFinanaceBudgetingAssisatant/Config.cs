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

        public Configuration RC;// = new Configuration();

        public void StoreConfig()
        {
            RC = new Configuration(DTT1S.Value, DTT1E.Value, DTT2S.Value, DTT2E.Value, DTT3S.Value, DTT3E.Value);
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
