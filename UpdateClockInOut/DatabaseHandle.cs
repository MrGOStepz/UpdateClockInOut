using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateClockInOut
{
    public class DatabaseHandle
    {
        private MySqlConnection _conn;

        private const string TABLE_EMPOLYEE_TIME_SHEET = "tb_employee_time_sheet";

        private void DatabaseOpen()
        {
            string connectionPath = ConfigurationManager.ConnectionStrings["SmoothDB"].ConnectionString;
            _conn = new MySqlConnection(connectionPath);
            _conn.Open();
        }

        private void DatabaseClose()
        {
            _conn.Close();
        }

        public DataTable ListOfStaff()
        {
            try
            {
                StringBuilder stringSQL = new StringBuilder();

                DatabaseOpen();

                stringSQL.Append("SELECT *");
                stringSQL.Append(" FROM ");
                stringSQL.Append(TABLE_EMPOLYEE_TIME_SHEET);
                stringSQL.Append("  LIMIT 100");

                MySqlCommand cmd = new MySqlCommand(stringSQL.ToString(), _conn);
                //cmd.Parameters.AddWithValue("@PopupID", PopupID);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                cmd.Dispose();
                DatabaseClose();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public DataTable ListOfStaffByFirstName(String firstName, String startTime, String endTime)
        {
            try
            {
                StringBuilder stringSQL = new StringBuilder();

                DatabaseOpen();

                stringSQL.Append("SELECT *");
                stringSQL.Append(" FROM ");
                stringSQL.Append(TABLE_EMPOLYEE_TIME_SHEET);
                stringSQL.AppendFormat(" WHERE first_name LIKE \"%{0}%\" AND clockin_time BETWEEN \"{1}\" AND \"{2}\"", firstName, startTime, endTime);
                stringSQL.Append(" ORDER BY clockin_time DESC LIMIT 100 ");

                MySqlCommand cmd = new MySqlCommand(stringSQL.ToString(), _conn);
                //cmd.Parameters.AddWithValue("@PopupID", PopupID);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                cmd.Dispose();
                DatabaseClose();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public int UpdateStaffTimeSheet(int timeSheetID, String startTime, String endTime)
        {
            try
            {
                StringBuilder stringSQL = new StringBuilder();

                DatabaseOpen();

                stringSQL.Append("UPDATE tb_employee_time_sheet");
                stringSQL.AppendFormat(" SET clockin_time = \"{0}\", clockout_time = \"{1}\"", startTime, endTime);
                stringSQL.AppendFormat(" WHERE employee_time_sheet_id = {0}", timeSheetID);

                MySqlCommand cmd = new MySqlCommand(stringSQL.ToString(), _conn);
                //cmd.Parameters.AddWithValue("@PopupID", PopupID);

                cmd.ExecuteNonQuery();
                DatabaseClose();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }

    }
}
