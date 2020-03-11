using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public abstract class Attendance
    {
        public static DBUtilityLB.DbHelperSQL dbHelper = new DBUtilityLB.DbHelperSQL("hrdb");

        public static bool CheckStaffName(string staffid)
        {
            staffid = staffid.Replace('\'', ' ');
            string sql = "select * from t_staff where StaffNumber='" + staffid + "'";

            DataTable dt = dbHelper.ExecuteTable(CommandType.Text,sql, null);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}