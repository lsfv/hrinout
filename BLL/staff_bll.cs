using System;
using System.Data;
using System.Collections.Generic;
using Model;
using DAL;
namespace BLL
{
    //t_AttendanceWebData
    public abstract class t_staff
    {
        private readonly static DAL.t_staff dal = new DAL.t_staff();
        public t_staff()
        { }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool Exists(string StaffName)
        {
            return dal.Exists(StaffName);
        }
    }
}