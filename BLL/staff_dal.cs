using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using DBUtilityLB;
namespace DAL
{
    //t_AttendanceWebData
    public  class t_staff
    {
        public DbHelperSQL DbHelper = new DbHelperSQL("hrdb");
        public bool Exists(string StaffName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_staff");
            strSql.Append(" where ");
            strSql.Append(" StaffNumber = @StaffName  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@StaffName", SqlDbType.NVarChar,30)          };
            parameters[0].Value = StaffName;

            object ret = DbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), parameters);
            return (int)ret == 0 ? false : true;
        }
    }
}