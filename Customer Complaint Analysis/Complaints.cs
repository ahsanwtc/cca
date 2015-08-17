using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LINQtoCSV;

namespace Customer_Complaint_Analysis
{
    public partial class bt_addComplaints : Form
    {
        private DBConnection dbConnection;
        public bt_addComplaints()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "RFO Complaints")

            {
                comboBox2.Show();
                comboBox3.Hide();
               
            }
            else if (comboBox1.Text == "RFP Complaints")
            {
                
                comboBox2.Hide();
               
                comboBox3.Show();
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV|*.csv";

            if (dlg.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Opearation Cancelled");
            }
            else 
            {
                string fileName;
                fileName = dlg.FileName;
                DataEntry(fileName);
            }
        }

        /**
        * Reading Sheet1 of the xlsx and saving into db
        * 
        */
        private void DataEntry(String csvLocation)
        {
            int count = 0;
            bool alreadyExist = false;
            CsvContext cc = new CsvContext();
            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true,
                FileCultureName = "en-US"//,
                //IgnoreUnknownColumns = true
            };
            IEnumerable<ComplaintsData> complaintsDataAll =
                cc.Read<ComplaintsData>(csvLocation, inputFileDescription);

            var complaintsData =
                from c in complaintsDataAll
                select new { 
                    c.Time, c.TCHAvailabilityRate, c.CallSetupTCHGOS, c.GOSSDCCH, c.TRAUErrorRateSouth, c.L9A05, c.L9A02, c.L9A03, c.TCHMHT, c.MeanNumberOfTCHInInterferenceBand4, 
                    c.MeanNumberOfTCHInInterferenceBand5, c.RxQualIndexDL, c.RxQualIndexUL, c.DCRSouth, c.CM333, c.CM334, c.PacketDataThroughputDL, c.PacketDataThroughputUL,
                    c.DLTBFCongestionRate, c.ULTBFCongestionRate, c.AbisBlocking, c.CI
                };

            foreach (var item in complaintsData)
            {
                if (dbConnection.ComplaintsDataExists(item.Time))
                    alreadyExist = true;
                break;
            }

            #region instersion of data
            foreach (var item in complaintsData) 
            {
                if (!alreadyExist)
                {
                    /*
                     * Insertion of new data!!!
                     */
                    Dictionary<String, String> values = new Dictionary<string, string>();
                    values.Add("Time", item.Time);
                    values.Add("TCHAvailabilityRate", item.TCHAvailabilityRate);
                    values.Add("CallSetupTCHGOS", item.CallSetupTCHGOS);
                    values.Add("GOSSDCCH", item.GOSSDCCH);
                    values.Add("TRAUErrorRateSouth", item.TRAUErrorRateSouth);
                    values.Add("L9A05", item.L9A05);
                    values.Add("L9A02", item.L9A02);
                    values.Add("L9A03", item.L9A03);
                    values.Add("TCHMHT", item.TCHMHT);
                    values.Add("MeanNumberOfTCHInInterferenceBand4", item.MeanNumberOfTCHInInterferenceBand4);
                    values.Add("MeanNumberOfTCHInInterferenceBand5", item.MeanNumberOfTCHInInterferenceBand5);
                    values.Add("RxQualIndexDL", item.RxQualIndexDL);
                    values.Add("RxQualIndexUL", item.RxQualIndexUL);
                    values.Add("DCRSouth", item.DCRSouth);
                    values.Add("CM333", item.CM333);
                    values.Add("CM334", item.CM334);
                    values.Add("PacketDataThroughputDL", item.PacketDataThroughputDL);
                    values.Add("PacketDataThroughputUL", item.PacketDataThroughputUL);
                    values.Add("DLTBFCongestionRate", item.DLTBFCongestionRate);
                    values.Add("ULTBFCongestionRate", item.ULTBFCongestionRate);
                    values.Add("AbisBlocking", item.AbisBlocking);
                    values.Add("CI", item.CI);
                    dbConnection.InsertToComplaints(values);
                    count++;
                }
                else
                {
                    MessageBox.Show("Record already exist!");
                    break;
                }
            }
            #endregion

            MessageBox.Show("Records added: " + count.ToString());
        }

        private void bt_addComplaints_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.Disconnect();
        }

        private void bt_addComplaints_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }

        private void bt_showGraph_Click(object sender, EventArgs e)
        {
            Graphs graphsForms = new Graphs();
            if (comboBox1.Text.Length > 0)
            {
                string str = comboBox1.Text;
                switch (str)
                {
                    case "RFO Complaints":
                        if (comboBox2.Text.Length > 0)
                        {
                            String cType = comboBox2.Text;
                            graphsForms.ComplaintType = str;
                            graphsForms.SubComplaintType = cType;
                            graphsForms.ShowDialog();
                        }
                        break;
                    case "RFP Complaints":
                        if (comboBox3.Text.Length > 0)
                        {
                            String cType = comboBox3.Text;
                            graphsForms.ComplaintType = str;
                            graphsForms.SubComplaintType = cType;
                            graphsForms.ShowDialog();
                        }
                        break;
                }
            }
            //MessageBox.Show(str);
            //graphsForms.ComplaintType()
        }

        




    }
}
