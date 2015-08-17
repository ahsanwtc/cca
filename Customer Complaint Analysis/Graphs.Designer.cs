namespace Customer_Complaint_Analysis
{
    partial class Graphs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_kpis = new System.Windows.Forms.ComboBox();
            this.bt_Generate = new System.Windows.Forms.Button();
            this.cb_endDate = new System.Windows.Forms.ComboBox();
            this.cb_startDate = new System.Windows.Forms.ComboBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_chartTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_kpis);
            this.groupBox1.Controls.Add(this.bt_Generate);
            this.groupBox1.Controls.Add(this.cb_endDate);
            this.groupBox1.Controls.Add(this.cb_startDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // lb_kpis
            // 
            this.lb_kpis.FormattingEnabled = true;
            this.lb_kpis.Location = new System.Drawing.Point(6, 19);
            this.lb_kpis.Name = "lb_kpis";
            this.lb_kpis.Size = new System.Drawing.Size(364, 21);
            this.lb_kpis.TabIndex = 4;
            // 
            // bt_Generate
            // 
            this.bt_Generate.Location = new System.Drawing.Point(444, 117);
            this.bt_Generate.Name = "bt_Generate";
            this.bt_Generate.Size = new System.Drawing.Size(75, 23);
            this.bt_Generate.TabIndex = 3;
            this.bt_Generate.Text = "Generate";
            this.bt_Generate.UseVisualStyleBackColor = true;
            this.bt_Generate.Click += new System.EventHandler(this.bt_Generate_Click);
            // 
            // cb_endDate
            // 
            this.cb_endDate.FormattingEnabled = true;
            this.cb_endDate.Location = new System.Drawing.Point(398, 62);
            this.cb_endDate.Name = "cb_endDate";
            this.cb_endDate.Size = new System.Drawing.Size(121, 21);
            this.cb_endDate.TabIndex = 2;
            // 
            // cb_startDate
            // 
            this.cb_startDate.FormattingEnabled = true;
            this.cb_startDate.Location = new System.Drawing.Point(398, 19);
            this.cb_startDate.Name = "cb_startDate";
            this.cb_startDate.Size = new System.Drawing.Size(121, 21);
            this.cb_startDate.TabIndex = 1;
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(12, 217);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(1080, 518);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // lb_chartTitle
            // 
            this.lb_chartTitle.AutoSize = true;
            this.lb_chartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chartTitle.Location = new System.Drawing.Point(12, 174);
            this.lb_chartTitle.Name = "lb_chartTitle";
            this.lb_chartTitle.Size = new System.Drawing.Size(0, 31);
            this.lb_chartTitle.TabIndex = 2;
            this.lb_chartTitle.Click += new System.EventHandler(this.lb_chartTitle_Click);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 747);
            this.Controls.Add(this.lb_chartTitle);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.groupBox1);
            this.Name = "Graphs";
            this.Text = "Graphs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Graphs_FormClosing);
            this.Load += new System.EventHandler(this.Graphs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Generate;
        private System.Windows.Forms.ComboBox cb_endDate;
        private System.Windows.Forms.ComboBox cb_startDate;
        private System.Windows.Forms.ComboBox lb_kpis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label lb_chartTitle;

    }
}