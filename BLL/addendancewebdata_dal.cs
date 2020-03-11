using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using DBUtilityLB;
namespace DAL
{
    //t_AttendanceWebData
    public partial class t_AttendanceWebData
    {
        public DbHelperSQL DbHelper = new DbHelperSQL("mobilwebdb");
        public bool Exists(string StaffName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_AttendanceWebData");
            strSql.Append(" where ");
            strSql.Append(" StaffName = @StaffName  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@StaffName", SqlDbType.NVarChar,200)          };
            parameters[0].Value = StaffName;

            object ret = DbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), parameters);
            return (int)ret == 0 ? false : true;
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.t_AttendanceWebData model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_AttendanceWebData(");
            strSql.Append("LogDate,DeviceID,DeviceName,Zone,Department,OTMinute,LateMinute,EarlyLeaveMinute,PairNo,ImportID,CreateDate,LogTime,CreateUser,GpsLocation,GpsLocationName,PositionID,Type,ExternalRef,InterfaceID,AttendanceInterfaceCenterID,RemoteIdent,StaffName,StaffNumber");
            strSql.Append(") values (");
            strSql.Append("@LogDate,@DeviceID,@DeviceName,@Zone,@Department,@OTMinute,@LateMinute,@EarlyLeaveMinute,@PairNo,@ImportID,@CreateDate,@LogTime,@CreateUser,@GpsLocation,@GpsLocationName,@PositionID,@Type,@ExternalRef,@InterfaceID,@AttendanceInterfaceCenterID,@RemoteIdent,@StaffName,@StaffNumber");
            strSql.Append(") ");

            SqlParameter[] parameters = {
                        new SqlParameter("@LogDate", SqlDbType.DateTime) ,
                        new SqlParameter("@DeviceID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@DeviceName", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Zone", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Department", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@OTMinute", SqlDbType.Int,4) ,
                        new SqlParameter("@LateMinute", SqlDbType.Int,4) ,
                        new SqlParameter("@EarlyLeaveMinute", SqlDbType.Int,4) ,
                        new SqlParameter("@PairNo", SqlDbType.Int,4) ,
                        new SqlParameter("@ImportID", SqlDbType.Int,4) ,
                        new SqlParameter("@CreateDate", SqlDbType.DateTime) ,
                        new SqlParameter("@LogTime", SqlDbType.DateTime) ,
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,
                        new SqlParameter("@GpsLocation", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@GpsLocationName", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@PositionID", SqlDbType.Int,4) ,
                        new SqlParameter("@Type", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ExternalRef", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@InterfaceID", SqlDbType.Int,4) ,
                        new SqlParameter("@AttendanceInterfaceCenterID", SqlDbType.Int,4) ,
                        new SqlParameter("@RemoteIdent", SqlDbType.Int,4) ,
                        new SqlParameter("@StaffName", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@StaffNumber", SqlDbType.NVarChar,50)

            };

            parameters[0].Value = model.LogDate;
            parameters[1].Value = model.DeviceID;
            parameters[2].Value = model.DeviceName;
            parameters[3].Value = model.Zone;
            parameters[4].Value = model.Department;
            parameters[5].Value = model.OTMinute;
            parameters[6].Value = model.LateMinute;
            parameters[7].Value = model.EarlyLeaveMinute;
            parameters[8].Value = model.PairNo;
            parameters[9].Value = model.ImportID;
            parameters[10].Value = model.CreateDate;
            parameters[11].Value = model.LogTime;
            parameters[12].Value = model.CreateUser;
            parameters[13].Value = model.GpsLocation;
            parameters[14].Value = model.GpsLocationName;
            parameters[15].Value = model.PositionID;
            parameters[16].Value = model.Type;
            parameters[17].Value = model.ExternalRef;
            parameters[18].Value = model.InterfaceID;
            parameters[19].Value = model.AttendanceInterfaceCenterID;
            parameters[20].Value = model.RemoteIdent;
            parameters[21].Value = model.StaffName;
            parameters[22].Value = model.StaffNumber;
            DbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.t_AttendanceWebData model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update t_AttendanceWebData set ");

            strSql.Append(" LogDate = @LogDate , ");
            strSql.Append(" DeviceID = @DeviceID , ");
            strSql.Append(" DeviceName = @DeviceName , ");
            strSql.Append(" Zone = @Zone , ");
            strSql.Append(" Department = @Department , ");
            strSql.Append(" OTMinute = @OTMinute , ");
            strSql.Append(" LateMinute = @LateMinute , ");
            strSql.Append(" EarlyLeaveMinute = @EarlyLeaveMinute , ");
            strSql.Append(" PairNo = @PairNo , ");
            strSql.Append(" ImportID = @ImportID , ");
            strSql.Append(" CreateDate = @CreateDate , ");
            strSql.Append(" LogTime = @LogTime , ");
            strSql.Append(" CreateUser = @CreateUser , ");
            strSql.Append(" GpsLocation = @GpsLocation , ");
            strSql.Append(" GpsLocationName = @GpsLocationName , ");
            strSql.Append(" PositionID = @PositionID , ");
            strSql.Append(" Type = @Type , ");
            strSql.Append(" ExternalRef = @ExternalRef , ");
            strSql.Append(" InterfaceID = @InterfaceID , ");
            strSql.Append(" AttendanceInterfaceCenterID = @AttendanceInterfaceCenterID , ");
            strSql.Append(" RemoteIdent = @RemoteIdent , ");
            strSql.Append(" StaffName = @StaffName , ");
            strSql.Append(" StaffNumber = @StaffNumber  ");
            strSql.Append(" where StaffName=@StaffName  ");

            SqlParameter[] parameters = {
                        new SqlParameter("@LogDate", SqlDbType.DateTime) ,
                        new SqlParameter("@DeviceID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@DeviceName", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Zone", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Department", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@OTMinute", SqlDbType.Int,4) ,
                        new SqlParameter("@LateMinute", SqlDbType.Int,4) ,
                        new SqlParameter("@EarlyLeaveMinute", SqlDbType.Int,4) ,
                        new SqlParameter("@PairNo", SqlDbType.Int,4) ,
                        new SqlParameter("@ImportID", SqlDbType.Int,4) ,
                        new SqlParameter("@CreateDate", SqlDbType.DateTime) ,
                        new SqlParameter("@LogTime", SqlDbType.DateTime) ,
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,
                        new SqlParameter("@GpsLocation", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@GpsLocationName", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@PositionID", SqlDbType.Int,4) ,
                        new SqlParameter("@Type", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ExternalRef", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@InterfaceID", SqlDbType.Int,4) ,
                        new SqlParameter("@AttendanceInterfaceCenterID", SqlDbType.Int,4) ,
                        new SqlParameter("@RemoteIdent", SqlDbType.Int,4) ,
                        new SqlParameter("@StaffName", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@StaffNumber", SqlDbType.NVarChar,50)

            };

            parameters[0].Value = model.LogDate;
            parameters[1].Value = model.DeviceID;
            parameters[2].Value = model.DeviceName;
            parameters[3].Value = model.Zone;
            parameters[4].Value = model.Department;
            parameters[5].Value = model.OTMinute;
            parameters[6].Value = model.LateMinute;
            parameters[7].Value = model.EarlyLeaveMinute;
            parameters[8].Value = model.PairNo;
            parameters[9].Value = model.ImportID;
            parameters[10].Value = model.CreateDate;
            parameters[11].Value = model.LogTime;
            parameters[12].Value = model.CreateUser;
            parameters[13].Value = model.GpsLocation;
            parameters[14].Value = model.GpsLocationName;
            parameters[15].Value = model.PositionID;
            parameters[16].Value = model.Type;
            parameters[17].Value = model.ExternalRef;
            parameters[18].Value = model.InterfaceID;
            parameters[19].Value = model.AttendanceInterfaceCenterID;
            parameters[20].Value = model.RemoteIdent;
            parameters[21].Value = model.StaffName;
            parameters[22].Value = model.StaffNumber;
            int rows = DbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
            return rows > 0 ? true : false;
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string StaffName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_AttendanceWebData ");
            strSql.Append(" where StaffName=@StaffName ");
            SqlParameter[] parameters = {
                    new SqlParameter("@StaffName", SqlDbType.NVarChar,200)          };
            parameters[0].Value = StaffName;


            int rows = DbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
            return rows > 0 ? true : false;
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.t_AttendanceWebData GetModel(string StaffName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LogDate, DeviceID, DeviceName, Zone, Department, OTMinute, LateMinute, EarlyLeaveMinute, PairNo, ImportID, CreateDate, LogTime, CreateUser, GpsLocation, GpsLocationName, PositionID, Type, ExternalRef, InterfaceID, AttendanceInterfaceCenterID, RemoteIdent, StaffName, StaffNumber  ");
            strSql.Append("  from t_AttendanceWebData ");
            strSql.Append(" where StaffName=@StaffName ");
            SqlParameter[] parameters = {
                    new SqlParameter("@StaffName", SqlDbType.NVarChar,200)          };
            parameters[0].Value = StaffName;


            Model.t_AttendanceWebData model = null;
            DataTable dt = DbHelper.ExecuteTable(CommandType.Text, strSql.ToString(), parameters);

            if (dt.Rows.Count > 0)
            {
                model = new Model.t_AttendanceWebData();
                if (dt.Rows[0]["LogDate"].ToString() != "")
                {
                    model.LogDate = DateTime.Parse(dt.Rows[0]["LogDate"].ToString());
                }
                model.DeviceID = dt.Rows[0]["DeviceID"].ToString();
                model.DeviceName = dt.Rows[0]["DeviceName"].ToString();
                model.Zone = dt.Rows[0]["Zone"].ToString();
                model.Department = dt.Rows[0]["Department"].ToString();
                if (dt.Rows[0]["OTMinute"].ToString() != "")
                {
                    model.OTMinute = int.Parse(dt.Rows[0]["OTMinute"].ToString());
                }
                if (dt.Rows[0]["LateMinute"].ToString() != "")
                {
                    model.LateMinute = int.Parse(dt.Rows[0]["LateMinute"].ToString());
                }
                if (dt.Rows[0]["EarlyLeaveMinute"].ToString() != "")
                {
                    model.EarlyLeaveMinute = int.Parse(dt.Rows[0]["EarlyLeaveMinute"].ToString());
                }
                if (dt.Rows[0]["PairNo"].ToString() != "")
                {
                    model.PairNo = int.Parse(dt.Rows[0]["PairNo"].ToString());
                }
                if (dt.Rows[0]["ImportID"].ToString() != "")
                {
                    model.ImportID = int.Parse(dt.Rows[0]["ImportID"].ToString());
                }
                if (dt.Rows[0]["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(dt.Rows[0]["CreateDate"].ToString());
                }
                if (dt.Rows[0]["LogTime"].ToString() != "")
                {
                    model.LogTime = DateTime.Parse(dt.Rows[0]["LogTime"].ToString());
                }
                if (dt.Rows[0]["CreateUser"].ToString() != "")
                {
                    model.CreateUser = int.Parse(dt.Rows[0]["CreateUser"].ToString());
                }
                model.GpsLocation = dt.Rows[0]["GpsLocation"].ToString();
                model.GpsLocationName = dt.Rows[0]["GpsLocationName"].ToString();
                if (dt.Rows[0]["PositionID"].ToString() != "")
                {
                    model.PositionID = int.Parse(dt.Rows[0]["PositionID"].ToString());
                }
                model.Type = dt.Rows[0]["Type"].ToString();
                model.ExternalRef = dt.Rows[0]["ExternalRef"].ToString();
                if (dt.Rows[0]["InterfaceID"].ToString() != "")
                {
                    model.InterfaceID = int.Parse(dt.Rows[0]["InterfaceID"].ToString());
                }
                if (dt.Rows[0]["AttendanceInterfaceCenterID"].ToString() != "")
                {
                    model.AttendanceInterfaceCenterID = int.Parse(dt.Rows[0]["AttendanceInterfaceCenterID"].ToString());
                }
                if (dt.Rows[0]["RemoteIdent"].ToString() != "")
                {
                    model.RemoteIdent = int.Parse(dt.Rows[0]["RemoteIdent"].ToString());
                }
                model.StaffName = dt.Rows[0]["StaffName"].ToString();
                model.StaffNumber = dt.Rows[0]["StaffNumber"].ToString();
            }
            return model;
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM t_AttendanceWebData ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelper.ExecuteTable(CommandType.Text, strSql.ToString(), null);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataTable GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM t_AttendanceWebData ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelper.ExecuteTable(CommandType.Text, strSql.ToString(), null);
        }

        /// <summary>
        /// GetPage("gs_id>3", "gs_id", "order by gs_id", 2, 3, out recordCount, out pageCount);
        /// </summary>
        /// <param name="Where">"" or "gs_id>3"</param>
        /// <param name="IndexField">"gs_id"</param>
        /// <param name="OrderFields">"order by gs_id" or "order by gs_id desc"</param>
        /// <param name="PageIndex">2</param>
        /// <param name="PageSize">3</param>
        /// <param name="RecordCount">out recordCount</param>
        /// <param name="PageCount">out pageCount</param>
        /// <returns></returns>
        public DataTable GetPage(string Where, string IndexField, string OrderFields, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string SqlTablesAndWhere = string.IsNullOrEmpty(Where.Trim()) ? "t_AttendanceWebData" : "t_AttendanceWebData where " + Where;
            return DbHelper.ExecutePage("*", SqlTablesAndWhere, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount, null);
        }
    }
}
