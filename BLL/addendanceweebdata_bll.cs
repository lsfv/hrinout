using System;
using System.Data;
using System.Collections.Generic;
using Model;
using DAL;
namespace BLL
{
    //t_AttendanceWebData
    public abstract class t_AttendanceWebData
    {
        private readonly static DAL.t_AttendanceWebData dal = new DAL.t_AttendanceWebData();
        public t_AttendanceWebData()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool  Exists(string StaffName)
        {
            return dal.Exists(StaffName);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static void Add(Model.t_AttendanceWebData model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(Model.t_AttendanceWebData model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool Delete(string StaffName)
        {
            return dal.Delete(StaffName);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Model.t_AttendanceWebData GetModel(string StaffName)
        {
            return dal.GetModel(StaffName);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataTable GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public static DataTable GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static List<Model.t_AttendanceWebData> GetModelList(string strWhere)
        {
            DataTable dt = dal.GetList(strWhere);
            return DataTableToList(dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static List<Model.t_AttendanceWebData> DataTableToList(DataTable dt)
        {
            List<Model.t_AttendanceWebData> modelList = new List<Model.t_AttendanceWebData>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.t_AttendanceWebData model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.t_AttendanceWebData();
                    if (dt.Rows[n]["LogDate"].ToString() != "")
                    {
                        model.LogDate = DateTime.Parse(dt.Rows[n]["LogDate"].ToString());
                    }
                    model.DeviceID = dt.Rows[n]["DeviceID"].ToString();
                    model.DeviceName = dt.Rows[n]["DeviceName"].ToString();
                    model.Zone = dt.Rows[n]["Zone"].ToString();
                    model.Department = dt.Rows[n]["Department"].ToString();
                    if (dt.Rows[n]["OTMinute"].ToString() != "")
                    {
                        model.OTMinute = int.Parse(dt.Rows[n]["OTMinute"].ToString());
                    }
                    if (dt.Rows[n]["LateMinute"].ToString() != "")
                    {
                        model.LateMinute = int.Parse(dt.Rows[n]["LateMinute"].ToString());
                    }
                    if (dt.Rows[n]["EarlyLeaveMinute"].ToString() != "")
                    {
                        model.EarlyLeaveMinute = int.Parse(dt.Rows[n]["EarlyLeaveMinute"].ToString());
                    }
                    if (dt.Rows[n]["PairNo"].ToString() != "")
                    {
                        model.PairNo = int.Parse(dt.Rows[n]["PairNo"].ToString());
                    }
                    if (dt.Rows[n]["ImportID"].ToString() != "")
                    {
                        model.ImportID = int.Parse(dt.Rows[n]["ImportID"].ToString());
                    }
                    if (dt.Rows[n]["CreateDate"].ToString() != "")
                    {
                        model.CreateDate = DateTime.Parse(dt.Rows[n]["CreateDate"].ToString());
                    }
                    if (dt.Rows[n]["LogTime"].ToString() != "")
                    {
                        model.LogTime = DateTime.Parse(dt.Rows[n]["LogTime"].ToString());
                    }
                    if (dt.Rows[n]["CreateUser"].ToString() != "")
                    {
                        model.CreateUser = int.Parse(dt.Rows[n]["CreateUser"].ToString());
                    }
                    model.GpsLocation = dt.Rows[n]["GpsLocation"].ToString();
                    model.GpsLocationName = dt.Rows[n]["GpsLocationName"].ToString();
                    if (dt.Rows[n]["PositionID"].ToString() != "")
                    {
                        model.PositionID = int.Parse(dt.Rows[n]["PositionID"].ToString());
                    }
                    model.Type = dt.Rows[n]["Type"].ToString();
                    model.ExternalRef = dt.Rows[n]["ExternalRef"].ToString();
                    if (dt.Rows[n]["InterfaceID"].ToString() != "")
                    {
                        model.InterfaceID = int.Parse(dt.Rows[n]["InterfaceID"].ToString());
                    }
                    if (dt.Rows[n]["AttendanceInterfaceCenterID"].ToString() != "")
                    {
                        model.AttendanceInterfaceCenterID = int.Parse(dt.Rows[n]["AttendanceInterfaceCenterID"].ToString());
                    }
                    if (dt.Rows[n]["RemoteIdent"].ToString() != "")
                    {
                        model.RemoteIdent = int.Parse(dt.Rows[n]["RemoteIdent"].ToString());
                    }
                    model.StaffName = dt.Rows[n]["StaffName"].ToString();
                    model.StaffNumber = dt.Rows[n]["StaffNumber"].ToString();


                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataTable GetAllList()
        {
            return GetList("");
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
        public static DataTable GetPage(string Where, string IndexField, string OrderFields, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            return dal.GetPage(Where, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
        }
        #endregion

    }
}