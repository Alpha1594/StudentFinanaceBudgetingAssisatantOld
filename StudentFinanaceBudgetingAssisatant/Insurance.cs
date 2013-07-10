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
    public partial class Insurance : Form
    {
        public Insurance()
        {
            InitializeComponent();
            foreach (string S in Category)
            {
                CBCategory.Items.Add(S.ToString());
            }
            Readfile();
            LoadList();
        }

        string[] Category = { "Electrical", "Clothes", "Household", "Misc" };
        public List<Insured> InsuranceList = new List<Insured>();
        public struct Insured
        {
            public string Name;
            public decimal Value;
            public DateTime PurchasedOn;
            public string Category;
            public string[] Comments;

            public Insured(string Name, decimal Value, DateTime PurchasedOn, string Category, string[] Comments)
            {
				this.Name = Name;
				this.Value = Value;
				this.PurchasedOn = PurchasedOn;
				this.Category = Category;
				this.Comments = Comments;
            }
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            Insured temp = new Insured(TBName.Text, NUValue.Value, DTPurchased.Value, CBCategory.Text,
                TBComments.Lines);
            if (BTNSave.Text.Equals("Update"))
            {
                InsuranceList.RemoveAt(LBIns.SelectedIndex);
                BTNSave.Text = "BTNSave";
            }
            InsuranceList.Add(temp);
            WriteToFile();
            LoadList();
            FormReset();
        }

        private void WriteToFile()
        {
            FileStream FS = new FileStream("Insurance.xml", FileMode.Create);
            XmlSerializer XSR = new XmlSerializer(typeof(List<Insured>));
            XSR.Serialize(FS, InsuranceList);

            FS.Close();
            FS.Dispose();
            //MessageBox.Show("Data saved");
        }

        private void Readfile()
        {
            FileStream FS = new FileStream("Insurance.xml", FileMode.Open);
            XmlSerializer XSR = new XmlSerializer(typeof(List<Insured>));

            if (FS.Length > 0)
            {
                InsuranceList = (List<Insured>)XSR.Deserialize(FS);
            }
            FS.Close();
            FS.Dispose();
        }

        private void LoadList()
        {
            try
            {
                LBIns.Items.Clear();
                decimal Total = 0;
                foreach (Insured I in InsuranceList)
                {
                    LBIns.Items.Add(I.Name);
                    Total += I.Value;
                }
                LBLTotal.Text = "Total: " + Total.ToString();
            }
            catch
            {
                MessageBox.Show("Empty list?");
            }
        }

        private void LBIns_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = LBIns.SelectedIndex;
            TBName.Text = InsuranceList[Index].Name;
            NUValue.Value = InsuranceList[Index].Value;
            DTPurchased.Value = InsuranceList[Index].PurchasedOn;
            CBCategory.Text = InsuranceList[Index].Category;
            TBComments.Lines = InsuranceList[Index].Comments;

            BTNSave.Text = "Update";
        }

        private void FormReset()
        {
            TBName.Text = "";
            TBComments.Text = "";
            CBCategory.Text = "";
            DTPurchased.Value = DateTime.Today;
            NUValue.Value = 0;
        }
    }
}
