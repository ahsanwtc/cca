using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Customer_Complaint_Analysis
{
    public partial class Form1 : Form
    {
        private string xslLocation;
        private double lat;
        private double lon;
        private DBConnection dbConnection;
        public Form1()
        {
            string executableLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            xslLocation = System.IO.Path.Combine(executableLocation, "bts-database-Karrar.xlsx");
            dbConnection = new DBConnection();
            lat = lon = 0;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bt_addComplaints comp = new bt_addComplaints();
            this.Hide();
            comp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) {
            dbConnection.Connect();
            tb_lon.Text = "24.8873";
            tb_lat.Text = "67.159461";
            //DataEntry();
            //dataGridView1.DataSource = dbConnection.GetNearstStations(24.8873, 67.159461);
        }

        /**
         * Reading Sheet1 of the xlsx and saving into db
         * 
         */
        private void DataEntry()
        {
            System.IO.FileStream stream = System.IO.File.Open(xslLocation, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            Excel.IExcelDataReader excelReader = Excel.ExcelReaderFactory.CreateOpenXmlReader(stream);
            bool skip = true;
            int count = 0;
            DataSet result = excelReader.AsDataSet();
            while (excelReader.Read())
            {
                if (skip)
                {
                    skip = false;
                    continue;
                }
                string[] values = new string[65];
                #region Population of array with values from sheet
                values[0] = emptyStringToNA(excelReader.GetString(0)); // site
                values[1] = emptyStringToNA(excelReader.GetString(2)); // 3G SIte ID
                values[2] = emptyStringToNA(excelReader.GetString(1)); // CI
                values[3] = excelReader.GetString(8); // longitude
                values[4] = excelReader.GetString(9); // latitude
                values[5] = emptyStringToNA(excelReader.GetString(3)); // cell index
                values[6] = emptyStringToNA(excelReader.GetString(4)); // cell name
                values[7] = emptyStringToNA(excelReader.GetString(5)); // site name
                values[8] = emptyStringToNA(excelReader.GetString(6)); // site configuration
                values[9] = emptyStringToNA(excelReader.GetString(7)); // city
                for(int i = 10; i<65;i++)
                    values[i] = emptyStringToNA(excelReader.GetString(i));
                #endregion                
                dbConnection.Insert(values);
                count++;
            }
            excelReader.Close();
            MessageBox.Show(count.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_lat.Text.Length > 0 && tb_lat.Text.Length > 0)
            {
                double latt = Convert.ToDouble(tb_lat.Text);
                double lonn = Convert.ToDouble(tb_lon.Text);
                System.Data.DataTable result = dbConnection.GetNearstStations(latt, lonn);
                
                lb_ns_id_1.Text = result.Rows[0]["site"].ToString();
                lb_nc_id_1.Text = result.Rows[0]["ci_1"].ToString();
                CellIndex.CellIndexOne = Convert.ToInt32(result.Rows[0]["ci_1"].ToString());
                lb_ns_id_2.Text = result.Rows[1]["site"].ToString();
                lb_nc_id_2.Text = result.Rows[1]["ci_1"].ToString();
                CellIndex.CellIndexTwo = Convert.ToInt32(result.Rows[1]["ci_1"].ToString());
                lb_ns_id_3.Text = result.Rows[2]["site"].ToString();
                lb_nc_id_3.Text = result.Rows[2]["ci_1"].ToString();
                CellIndex.CellIndexThree = Convert.ToInt32(result.Rows[2]["ci_1"].ToString());

            }
            else
            {
                MessageBox.Show("Please enter lat and lon");
            }
        }

        private string emptyStringToNA(string str)
        {
            if (null != str && str.Length > 0)
                return str;
            return "N/A";
        }
    }
}
