using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Customer_Complaint_Analysis
{
    public partial class Graphs : Form
    {
        string complaintType;
        string subComplaintType;
        private DBConnection dbConnection;

        public Graphs()
        {
            InitializeComponent();
            dbConnection = new DBConnection();

        }

        public string ComplaintType
        {
            set { complaintType = value; }
        }

        public string SubComplaintType
        {
            set { subComplaintType = value; }
        }

        private void Graphs_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            switch (subComplaintType)
            {
                case "Voice Distortion":
                    lb_kpis.Items.Add("TCH Availability Rate");
                    lb_kpis.Items.Add("TRAU Error Rate%_South");
                    lb_kpis.Items.Add("L9A05:Number of Sent Empty TRAU Frames");
                    lb_kpis.Items.Add("Mean Number of TCH in Interference Band 4");
                    lb_kpis.Items.Add("Mean Number of TCH in Interference Band 5");
                    lb_kpis.Items.Add("RxQual Index DL(%)");
                    lb_kpis.Items.Add("RxQual Index UL(%)");
                    lb_kpis.Items.Add("TCH MHT (s)");
                    break;
                case "Call Drops":
                    lb_kpis.Items.Add("TCH Availability Rate");
                    lb_kpis.Items.Add("Mean Number of TCH in Interference Band 4");
                    lb_kpis.Items.Add("Mean Number of TCH in Interference Band 5");
                    lb_kpis.Items.Add("DCR%_South");
                    lb_kpis.Items.Add("CM333:Call Drops due to Abis Terrestrial Link Failure (Traffic Channel)");
                    lb_kpis.Items.Add("CM334:Call Drops due to Equipment Failure (Traffic Channel)");
                    break;
                case "Call Muting":
                    lb_kpis.Items.Add("TCH Availability Rate");
                    lb_kpis.Items.Add("Mean Number of TCH in Interference Band 4");
                    lb_kpis.Items.Add("Mean Number of TCH in Interference Band 5");
                    lb_kpis.Items.Add("TRAU Error Rate%_South");
                    lb_kpis.Items.Add("L9A05:Number of Sent Empty TRAU Frames");
                    lb_kpis.Items.Add("TCH MHT (s)");
                    break;
                case "Echo":
                    lb_kpis.Items.Add("TRAU Error Rate%_South");
                    lb_kpis.Items.Add("L9A05:Number of Sent Empty TRAU Frames");
                    lb_kpis.Items.Add("L9A02:Number of Received Out-of-Synchronization TRAU Frames");
                    lb_kpis.Items.Add("L9A03:Number of Received Check Error TRAU Frames");
                    break;
                case "Error In Connection":
                    lb_kpis.Items.Add("TCH Availability Rate");
                    lb_kpis.Items.Add("CallSetup TCH GOS(%)");
                    break;
                case "Network Busy":
                    lb_kpis.Items.Add("TCH Availability Rate");
                    lb_kpis.Items.Add("GOS-SDCCH(%)");
                    break;
                case "Weak Coverage":
                    lb_kpis.Items.Add("TCH Availability Rate");
                    break;
                case "GPRS Slow Browsing":
                    lb_kpis.Items.Add("TCH Availability Rate");
                    lb_kpis.Items.Add("TRAU Error Rate%_South");
                    lb_kpis.Items.Add("Packet data throughput (DL) (kbps)");
                    lb_kpis.Items.Add("Packet data throughput (UL) (kbps)");
                    lb_kpis.Items.Add("DL TBF Congestion Rate%(overall)");
                    lb_kpis.Items.Add("UL TBF Congestion Rate%(Overall)");
                    lb_kpis.Items.Add("Abis Blocking %");
                    break;
            }

            List<String> dateList1 = dbConnection.GetDates();
            List<String> dateList2 = dbConnection.GetDates();
            cb_endDate.DataSource = dateList1;
            cb_startDate.DataSource = dateList2;

        }

        private void Graphs_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.Disconnect();
        }

        private void bt_Generate_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (CellIndex.CellIndexOne == 0 || CellIndex.CellIndexTwo == 0 || CellIndex.CellIndexThree == 0)
            {
                MessageBox.Show("Calculate CI first");
                error = true;
            }

            if (lb_kpis.Text.Length < 1)
            {
                MessageBox.Show("Select a KPI...");
                error = true;
            }

            if (!error)
            {
                String kpi = "";
                switch (lb_kpis.Text)
                {
                    case "TCH Availability Rate":
                        kpi = "tch_availablity_rate";
                        break;
                    case "TRAU Error Rate%_South":
                        kpi = "trau_error_rate_south";
                        break;
                    case "L9A05:Number of Sent Empty TRAU Frames":
                        kpi = "l9a05";
                        break;
                    case "Mean Number of TCH in Interference Band 4":
                        kpi = "mean_tch_i_band_4";
                        break;
                    case "Mean Number of TCH in Interference Band 5":
                        kpi = "mean_tch_i_band_5";
                        break;
                    case "RxQual Index DL(%)":
                        kpi = "rx_qual_index_dl";
                        break;
                    case "TCH MHT (s)":
                        kpi = "tch_mht";
                        break;
                    case "DCR%_South":
                        kpi = "dcr_south";
                        break;
                    case "CM333:Call Drops due to Abis Terrestrial Link Failure (Traffic Channel)":
                        kpi = "cm333";
                        break;
                    case "CM334:Call Drops due to Equipment Failure (Traffic Channel)":
                        kpi = "cm334";
                        break;
                    case "L9A02:Number of Received Out-of-Synchronization TRAU Frames":
                        kpi = "l9a02";
                        break;
                    case "L9A03:Number of Received Check Error TRAU Frames":
                        kpi = "l9a03";
                        break;
                    case "CallSetup TCH GOS(%)":
                        kpi = "call_setup_tch_gos";
                        break;
                    case "GOS-SDCCH(%)":
                        kpi = "gos_sdcch";
                        break;
                    case "Packet data throughput (DL) (kbps)":
                        kpi = "packet_data_throughput_dl";
                        break;
                    case "Packet data throughput (UL) (kbps)":
                        kpi = "packet_data_throughput_ul";
                        break;
                    case "DL TBF Congestion Rate%(overall)":
                        kpi = "dl_tbf_congestion_rate";
                        break;
                    case "UL TBF Congestion Rate%(Overall)":
                        kpi = "ul_tbf_congestion_rate";
                        break;
                    case "Abis Blocking %":
                        kpi = "abis_blocking";
                        break;
                    
                }

                System.Data.DataTable graphDataOne = dbConnection.GetGraphData(kpi, cb_startDate.Text, cb_endDate.Text, CellIndex.CellIndexOne);
                System.Data.DataTable graphDataTwo = dbConnection.GetGraphData(kpi, cb_startDate.Text, cb_endDate.Text, CellIndex.CellIndexTwo);
                System.Data.DataTable graphDataThree = dbConnection.GetGraphData(kpi, cb_startDate.Text, cb_endDate.Text, CellIndex.CellIndexThree);
                //dataGridView1.DataSource = graphData;
                chart.Series.Clear();
                lb_chartTitle.Text = lb_kpis.Text;
                chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = CellIndex.CellIndexOne.ToString(),
                    Color = System.Drawing.Color.Green,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line                    
                };
                var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = CellIndex.CellIndexTwo.ToString(),
                    Color = System.Drawing.Color.Navy,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line
                };

                var series3 = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = CellIndex.CellIndexThree.ToString(),
                    Color = System.Drawing.Color.Pink,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line
                };

                this.chart.Series.Add(series1);
                this.chart.Series.Add(series2);
                this.chart.Series.Add(series3);

                foreach (DataRow row in graphDataOne.Rows)
                {
                    series1.Points.AddXY(row["time"].ToString(), row[kpi].ToString());
                }
                foreach (DataRow row in graphDataTwo.Rows)
                {
                    series2.Points.AddXY(row["time"].ToString(), row[kpi].ToString());
                }
                foreach (DataRow row in graphDataThree.Rows)
                {
                    series3.Points.AddXY(row["time"].ToString(), row[kpi].ToString());
                }





            }

        }

        private void SetSize()
        { }

        private void lb_chartTitle_Click(object sender, EventArgs e)
        {

        }







    }
}
