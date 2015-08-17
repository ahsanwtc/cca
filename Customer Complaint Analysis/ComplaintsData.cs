using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;


namespace Customer_Complaint_Analysis
{
    #pragma warning disable 0169, 0414, 0649
    class ComplaintsData
    {
        [CsvColumn(Name = "Time", FieldIndex = 1)]
        public string Time { get; set; }

        [CsvColumn(Name = "CI", FieldIndex = 2)]
        public string CI { get; set; }

        [CsvColumn(Name = "Cell", FieldIndex = 3)]
        public string Cell { get; set; }

        [CsvColumn(Name = "CellIndex", FieldIndex = 4)]
        public string CellIndex { get; set; }

        [CsvColumn(Name = "SiteIndex", FieldIndex = 5)]
        public string SiteIndex { get; set; }

        [CsvColumn(Name = "Site Name", FieldIndex = 6)]
        public string SiteName { get; set; }

        [CsvColumn(Name = "GBSC", FieldIndex = 7)]
        public string GBSC { get; set; }

        [CsvColumn(Name = "Location", FieldIndex = 8)]
        public string Location { get; set; }

        [CsvColumn(Name = "Cluster", FieldIndex = 9)]
        public string Cluster { get; set; }

        [CsvColumn(Name = "Integrity", FieldIndex = 10)]
        public string Integrity { get; set; }

        [CsvColumn(Name = "TCH Availability Rate", FieldIndex = 11)]
        public string TCHAvailabilityRate { get; set; }

        [CsvColumn(Name = "CallSetup TCH GOS(%)", FieldIndex = 12)]
        public string CallSetupTCHGOS { get; set; }

        [CsvColumn(Name = "GOS-SDCCH(%)", FieldIndex = 13)]
        public string GOSSDCCH { get; set; }

        [CsvColumn(Name = "TRAU Error Rate%_South", FieldIndex = 14)]
        public string TRAUErrorRateSouth { get; set; }

        [CsvColumn(Name = "L9A05:Number of Sent Empty TRAU Frames", FieldIndex = 15)]
        public string L9A05 { get; set; }
        
        [CsvColumn(Name = "L9A02:Number of Received Out-of-Synchronization TRAU Frames", FieldIndex = 16)]
        public string L9A02 { get; set; }

        [CsvColumn(Name = "L9A03:Number of Received Check Error TRAU Frames", FieldIndex = 17)]
        public string L9A03 { get; set; }

        [CsvColumn(Name = "TCH MHT (s)", FieldIndex = 18)]
        public string TCHMHT { get; set; }

        [CsvColumn(Name = "Mean Number of TCH in Interference Band 4", FieldIndex = 19)]
        public string MeanNumberOfTCHInInterferenceBand4 { get; set; }

        [CsvColumn(Name = "Mean Number of TCH in Interference Band 5", FieldIndex = 20)]
        public string MeanNumberOfTCHInInterferenceBand5 { get; set; }

        [CsvColumn(Name = "RxQual Index DL(%)", FieldIndex = 21)]
        public string RxQualIndexDL { get; set; }

        [CsvColumn(Name = "RxQual Index UL(%)", FieldIndex = 22)]
        public string RxQualIndexUL { get; set; }

        [CsvColumn(Name = "DCR%_South", FieldIndex = 23)]
        public string DCRSouth { get; set; }

        [CsvColumn(Name = "CM333:Call Drops due to Abis Terrestrial Link Failure (Traffic Channel)", FieldIndex = 24)]
        public string CM333 { get; set; }

        [CsvColumn(Name = "CM334:Call Drops due to Equipment Failure (Traffic Channel)", FieldIndex = 25)]
        public string CM334 { get; set; }

        [CsvColumn(Name = "Packet data throughput (DL) (kbps)", FieldIndex = 26)]
        public string PacketDataThroughputDL { get; set; }

        [CsvColumn(Name = "Packet data throughput (UL) (kbps)", FieldIndex = 27)]
        public string PacketDataThroughputUL { get; set; }

        [CsvColumn(Name = "DL TBF Congestion Rate%(overall)", FieldIndex = 28)]
        public string DLTBFCongestionRate { get; set; }

        [CsvColumn(Name = "UL TBF Congestion Rate%(Overall)", FieldIndex = 29)]
        public string ULTBFCongestionRate { get; set; }

        [CsvColumn(Name = "Abis Blocking %", FieldIndex = 30)]
        public string AbisBlocking { get; set; }


    }
    #pragma warning restore 0169, 0414, 0649
}
