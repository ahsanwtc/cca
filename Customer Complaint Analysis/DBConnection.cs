using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace Customer_Complaint_Analysis
{
    class DBConnection
    {
        private System.Data.SqlServerCe.SqlCeConnection conn;
        string path;

        public DBConnection()
        {
            path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf(@"\bin\Debug"));
        }

        public void Disconnect()
        {
            conn.Close();
        }

        public bool Connect()
        {
            try
            {
                //conn = new System.Data.SqlServerCe.SqlCeConnection(@"Data Source=|DataDirectory|\Database.sdf");
                
                conn = new System.Data.SqlServerCe.SqlCeConnection(@"Data Source=" + path + @"\Database.sdf");
                conn.Open();
                return true;
            }
            catch (System.Data.SqlServerCe.SqlCeException e)
            {
                conn = null;
                return false;
            }
        }

        public bool Insert(string[] values)
        {
            //try 
            //{
                string sql = @"insert into bts_table 
                    (site, three_g_site_id, ci_1, lon_1_deg, lat_1_deg, cell_index, cell_name, site_name, site_configuration, city, 
                        tower_owner, cu2, cu3, cu4, cu5, cu6, cu7, cu8, cu9, cu10, cu11, cu12, cu13, cu14, cu15, cu16, cu17, cu18, size, 
                        bore, bsic, bcch, hsn, mal0, planning_region, sub_region, cell_type_mm, cell_type_ru, cell_type_dlf, lac, cgi, vendor, 
                        band, ant_height, height_ant_900, height_ant_1800, height_ant_dual_band, no_of_ant_900, ant_type_900, elect_tilt_900, 
                        mech_tilt_900, no_of_ant_1800, ant_type_1800, elect_tilt_1800, mech_tilt_1800, num_of_dual_band_ant, cluster_name, bsc_new, 
                        msc, qos_engineer, wcms_engineer, prs_cluster_definition, phase, status, on_air_date) 
                    values(@site, @three_g_site_id, @ci_1, @lon_1_deg, @lat_1_deg, @cell_index, @cell_name, @site_name, @site_configuration, @city, 
                        @tower_owner, @cu2, @cu3, @cu4, @cu5, @cu6, @cu7, @cu8, @cu9, @cu10, @cu11, @cu12, @cu13, @cu14, @cu15, @cu16, @cu17, @cu18, 
                        @size, @bore, @bsic, @bcch, @hsn, @mal0, @planning_region, @sub_region, @cell_type_mm, @cell_type_ru, @cell_type_dlf, @lac, @cgi, 
                        @vendor, @band, @ant_height, @height_ant_900, @height_ant_1800, @height_ant_dual_band, @no_of_ant_900, @ant_type_900, @elect_tilt_900, 
                        @mech_tilt_900, @no_of_ant_1800, @ant_type_1800, @elect_tilt_1800, @mech_tilt_1800, @num_of_dual_band_ant, @cluster_name, @bsc_new, 
                        @msc, @qos_engineer, @wcms_engineer, @prs_cluster_definition, @phase, @status, @on_air_date)";
                using (System.Data.SqlServerCe.SqlCeCommand com = new System.Data.SqlServerCe.SqlCeCommand(sql, conn))
                {
                    #region Parameters
                    com.Parameters.AddWithValue("@site", values[0]);
                    com.Parameters.AddWithValue("@three_g_site_id", values[1]);
                    com.Parameters.AddWithValue("@ci_1", values[2]);
                    com.Parameters.AddWithValue("@lon_1_deg", Convert.ToDouble(values[3]));
                    com.Parameters.AddWithValue("@lat_1_deg", Convert.ToDouble(values[4]));
                    com.Parameters.AddWithValue("@cell_index", values[5]);
                    com.Parameters.AddWithValue("@cell_name", values[6]);
                    com.Parameters.AddWithValue("@site_name", values[7]);
                    com.Parameters.AddWithValue("@site_configuration", values[8]);
                    com.Parameters.AddWithValue("@city", values[9]);
                    com.Parameters.AddWithValue("@tower_owner", values[10]);
                    com.Parameters.AddWithValue("@cu2", values[11]);
                    com.Parameters.AddWithValue("@cu3", values[12]);
                    com.Parameters.AddWithValue("@cu4", values[13]);
                    com.Parameters.AddWithValue("@cu5", values[14]);
                    com.Parameters.AddWithValue("@cu6", values[15]);
                    com.Parameters.AddWithValue("@cu7", values[16]);
                    com.Parameters.AddWithValue("@cu8", values[17]);
                    com.Parameters.AddWithValue("@cu9", values[18]);
                    com.Parameters.AddWithValue("@cu10", values[19]);
                    com.Parameters.AddWithValue("@cu11", values[20]);
                    com.Parameters.AddWithValue("@cu12", values[21]);
                    com.Parameters.AddWithValue("@cu13", values[22]);
                    com.Parameters.AddWithValue("@cu14", values[23]);
                    com.Parameters.AddWithValue("@cu15", values[24]);
                    com.Parameters.AddWithValue("@cu16", values[25]);
                    com.Parameters.AddWithValue("@cu17", values[26]);
                    com.Parameters.AddWithValue("@cu18", values[27]);
                    com.Parameters.AddWithValue("@size", values[28]);
                    com.Parameters.AddWithValue("@bore", values[29]);
                    com.Parameters.AddWithValue("@bsic", values[30]);
                    com.Parameters.AddWithValue("@bcch", values[31]);
                    com.Parameters.AddWithValue("@hsn", values[32]);
                    com.Parameters.AddWithValue("@mal0", values[33]);
                    com.Parameters.AddWithValue("@planning_region", values[34]);
                    com.Parameters.AddWithValue("@sub_region", values[35]);
                    com.Parameters.AddWithValue("@cell_type_mm", values[36]);
                    com.Parameters.AddWithValue("@cell_type_ru", values[37]);
                    com.Parameters.AddWithValue("@cell_type_dlf", values[38]);
                    com.Parameters.AddWithValue("@lac", values[39]);
                    com.Parameters.AddWithValue("@cgi", values[40]);
                    com.Parameters.AddWithValue("@vendor", values[41]);
                    com.Parameters.AddWithValue("@band", values[42]);
                    com.Parameters.AddWithValue("@ant_height", values[43]);
                    com.Parameters.AddWithValue("@height_ant_900", values[44]);
                    com.Parameters.AddWithValue("@height_ant_1800", values[45]);
                    com.Parameters.AddWithValue("@height_ant_dual_band", values[46]);
                    com.Parameters.AddWithValue("@no_of_ant_900", values[47]);
                    com.Parameters.AddWithValue("@ant_type_900", values[48]);
                    com.Parameters.AddWithValue("@elect_tilt_900", values[49]);
                    com.Parameters.AddWithValue("@mech_tilt_900", values[50]);
                    com.Parameters.AddWithValue("@no_of_ant_1800", values[51]);
                    com.Parameters.AddWithValue("@ant_type_1800", values[52]);
                    com.Parameters.AddWithValue("@elect_tilt_1800", values[53]);
                    com.Parameters.AddWithValue("@mech_tilt_1800", values[54]);
                    com.Parameters.AddWithValue("@num_of_dual_band_ant", values[55]);
                    com.Parameters.AddWithValue("@cluster_name", values[56]);
                    com.Parameters.AddWithValue("@bsc_new", values[57]);
                    com.Parameters.AddWithValue("@msc", values[58]);
                    com.Parameters.AddWithValue("@qos_engineer", values[59]);
                    com.Parameters.AddWithValue("@wcms_engineer", values[60]);
                    com.Parameters.AddWithValue("@prs_cluster_definition", values[61]);
                    com.Parameters.AddWithValue("@phase", values[62]);
                    com.Parameters.AddWithValue("@status", values[63]);
                    com.Parameters.AddWithValue("@on_air_date", values[64]);
                    #endregion
                    com.ExecuteNonQuery();
                }
           // }
            //catch(Exception exp) 
          //  {
           //     return false;
          //  }
            return true;
        }

        /**
         * Returns the nearst bts to the location passed
         * 
         */
        public System.Data.DataTable GetNearstStations(double lat, double lon)
        {
            string connString = @"Data Source=" + path + @"\Database.sdf";
            String[] result = new String[6];
            // To radians
            lat *= 0.01745;
            lon *= 0.01745;
//            string sql = @" SELECT top(12)  site, ci_1,
//                                (6378.388 * acos(sin(@latitude) * sin(lat_1_deg*0.01745) + cos(@latitude) * cos(lat_1_deg*0.01745) * cos(lon_1_deg*0.01745 - @longitude))) as distance,
//                                lon_1_deg, lat_1_deg, bore
//                            FROM bts_table
//                            ORDER BY distance ASC";
            string sql = @" select t1.site, t1.ci_1, t1.bore, t1.lat_1_deg, t1.lon_1_deg from bts_table t1 
                                            inner join (
                                                            SELECT distinct top(3)  site, 
                                                            (6378.388 * acos(sin(@latitude) * sin(lat_1_deg*0.01745) + cos(@latitude) * cos(lat_1_deg*0.01745) * 
                                                                    cos(lon_1_deg*0.01745 - @longitude))) as distance
                                                            FROM bts_table
                                                            ORDER BY distance ASC
                                                        ) t2
                                            on t1.site = t2.site";

            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.DataTable endTable = new System.Data.DataTable();
            endTable.Columns.Add("site", typeof(String));
            endTable.Columns.Add("ci_1", typeof(String));
            endTable.Columns.Add("distance", typeof(double));

            using (System.Data.SqlServerCe.SqlCeCommand com = new System.Data.SqlServerCe.SqlCeCommand(sql, conn))
            {
                com.Parameters.AddWithValue("@latitude", lat);
                com.Parameters.AddWithValue("@longitude", lon);
                System.Data.SqlServerCe.SqlCeDataAdapter da = new System.Data.SqlServerCe.SqlCeDataAdapter(com);
                
                da.Fill(dt);
                //foreach (System.Data.DataRow row in dt.Rows)
                //{
                //    string site = row["site"].ToString();
                //    string cellIndex = row["ci_1"].ToString();
                //    result[i] = site;
                //    result[i + 1] = cellIndex;
                //    i += 2;
                //}

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    string site = row["site"].ToString();
                    string cell = row["ci_1"].ToString();
                    double bore = Convert.ToDouble(row["bore"].ToString());
                    double latitude = Convert.ToDouble(row["lat_1_deg"].ToString());
                    double longitude = Convert.ToDouble(row["lon_1_deg"].ToString());
                    bore *= 0.01745;
                    latitude *= 0.01745;
                    longitude *= 0.01745;
                    double latNew = NewLatitude(bore, latitude);
                    double lonNew = NewLongitude(bore, longitude, latitude, latNew);
                    double distance = CalculateDistance(latNew, lonNew, lat, lon);
                    endTable = AddToTable(endTable, distance, site, cell); 
                }
            }
            
            return endTable;
        }

        private double NewLatitude(double bore, double lat)
        {
            double latitude = 0;
            double seed = 0.1 / 6371;
            latitude = Math.Asin(Math.Sin(lat) * Math.Cos(seed) + Math.Cos(lat) * Math.Sin(seed) * Math.Cos(bore));
            return latitude;
        }

        private double NewLongitude(double bore, double lon, double lat1, double lat2)
        {
            double longitude = 0;
            double seed = 0.1 / 6371;
            longitude = lon + Math.Atan2(Math.Sin(bore) * Math.Sin(seed) * Math.Cos(lat1), Math.Cos(seed) - Math.Sin(lat1) * Math.Sin(lat2));
            return longitude;
        }

        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            double distance = 6378.388 * Math.Acos(Math.Sin(lat1) * Math.Sin(lat2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Cos(lon2 - lon1));
            return distance;
        }

        private System.Data.DataTable AddToTable(System.Data.DataTable table, double distance, string site, string cell)
        {
            System.Data.DataRow foundRow = table.Select("site = '" + site + "'").FirstOrDefault();
            if (foundRow != null)
            {
                double d = Convert.ToDouble(foundRow["distance"]);
                if (d > distance)
                {
                    foundRow["ci_1"] = cell;
                    foundRow["distance"] = distance;
                }
            }
            else
            {
                System.Data.DataRow row = table.NewRow();
                row["site"] = site;
                row["ci_1"] = cell;
                row["distance"] = distance;
                table.Rows.Add(row);
            }
            return table;
        }

        public bool InsertToComplaints(Dictionary<string, string> values)
        {
            //try 
            //{
            string sql = @"insert into complaints 
                    (time, tch_availablity_rate, call_setup_tch_gos, gos_sdcch, trau_error_rate_south, l9a05, l9a02, l9a03, tch_mht, mean_tch_i_band_4, mean_tch_i_band_5,
                    rx_qual_index_dl, rx_qual_index_ul, dcr_south, cm333, cm334, packet_data_throughput_dl, packet_data_throughput_ul, dl_tbf_congestion_rate, 
                    ul_tbf_congestion_rate, abis_blocking, ci) 
                    values
                    (@time, @tch_availablity_rate, @call_setup_tch_gos, @gos_sdcch, @trau_error_rate_south, @l9a05, @l9a02, @l9a03, @tch_mht, @mean_tch_i_band_4, @mean_tch_i_band_5,
                    @rx_qual_index_dl, @rx_qual_index_ul, @dcr_south, @cm333, @cm334, @packet_data_throughput_dl, @packet_data_throughput_ul, @dl_tbf_congestion_rate, 
                    @ul_tbf_congestion_rate, @abis_blocking, @ci)";
            using (System.Data.SqlServerCe.SqlCeCommand com = new System.Data.SqlServerCe.SqlCeCommand(sql, conn))
            {
                #region Parameters
                com.Parameters.AddWithValue("@time", values["Time"]);
                com.Parameters.AddWithValue("@tch_availablity_rate", ConvertToDouble(values["TCHAvailabilityRate"]));
                com.Parameters.AddWithValue("@call_setup_tch_gos", ConvertToDouble(values["CallSetupTCHGOS"]));
                com.Parameters.AddWithValue("@gos_sdcch", ConvertToDouble(values["GOSSDCCH"]));
                com.Parameters.AddWithValue("@trau_error_rate_south", ConvertToDouble(values["TRAUErrorRateSouth"]));
                com.Parameters.AddWithValue("@l9a05", ConvertToDouble(values["L9A05"]));
                com.Parameters.AddWithValue("@l9a02", ConvertToDouble(values["L9A02"]));
                com.Parameters.AddWithValue("@l9a03", ConvertToDouble(values["L9A03"]));
                com.Parameters.AddWithValue("@tch_mht", ConvertToDouble(values["TCHMHT"]));
                com.Parameters.AddWithValue("@mean_tch_i_band_4", ConvertToDouble(values["MeanNumberOfTCHInInterferenceBand4"]));
                com.Parameters.AddWithValue("@mean_tch_i_band_5", ConvertToDouble(values["MeanNumberOfTCHInInterferenceBand5"]));
                com.Parameters.AddWithValue("@rx_qual_index_dl", ConvertToDouble(values["RxQualIndexDL"]));
                com.Parameters.AddWithValue("@rx_qual_index_ul", ConvertToDouble(values["RxQualIndexUL"]));
                com.Parameters.AddWithValue("@dcr_south", ConvertToDouble(values["DCRSouth"]));
                com.Parameters.AddWithValue("@cm333", ConvertToDouble(values["CM333"]));
                com.Parameters.AddWithValue("@cm334", ConvertToDouble(values["CM334"]));
                com.Parameters.AddWithValue("@packet_data_throughput_dl", ConvertToDouble(values["PacketDataThroughputDL"]));
                com.Parameters.AddWithValue("@packet_data_throughput_ul", ConvertToDouble(values["PacketDataThroughputUL"]));
                com.Parameters.AddWithValue("@dl_tbf_congestion_rate", ConvertToDouble(values["DLTBFCongestionRate"]));
                com.Parameters.AddWithValue("@ul_tbf_congestion_rate", ConvertToDouble(values["ULTBFCongestionRate"]));
                com.Parameters.AddWithValue("@abis_blocking", ConvertToDouble(values["AbisBlocking"]));
                com.Parameters.AddWithValue("@ci", values["CI"]);
                #endregion
                com.ExecuteNonQuery();
            }
            return true;
        }

        public bool ComplaintsDataExists(string time) 
        {
            bool result = false;
            string sql = "select count(*) from complaints where (time = '" + time + "')";
            SqlCeCommand cmd = new SqlCeCommand(sql,conn);
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine(reader[0].ToString());
                // or, if your listid is an integer  
                int count = reader.GetInt32(0);
                if (count > 0)
                    result = true;
            }
            return result;
        }

        public List<string> GetDates()
        {
            List<string> list = new List<string>();
            string sql = "select distinct(time) from complaints";
            SqlCeCommand cmd = new SqlCeCommand(sql, conn);
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader[0].ToString());
            }
            return list;
        }

        public System.Data.DataTable GetGraphData(String kpi, String startDate, String endDate, int ci)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            string sql = "select time, " + kpi + " from complaints Where (CAST(time AS DATETIME) >= CAST('" + startDate + "' AS DATETIME)) and (CAST(time AS DATETIME) <= CAST('"+ endDate + @"' AS DATETIME)) and (ci = " + ci +  " ) ";

            using (System.Data.SqlServerCe.SqlCeCommand com = new System.Data.SqlServerCe.SqlCeCommand(sql, conn))
            {
                System.Data.SqlServerCe.SqlCeDataAdapter da = new System.Data.SqlServerCe.SqlCeDataAdapter(com);
                da.Fill(table);
            }
            return table;
        }

        private Double ConvertToDouble(string num)
        {
            double result = 0;
            try
            {
                result = Convert.ToDouble(num);
            }
            catch (Exception e)
            { }
            return result;
        }
    }
}
