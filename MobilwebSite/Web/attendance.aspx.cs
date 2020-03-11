using MobilwebSite.Web.webhelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobilwebSite.Web
{
    public partial class attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitControls();
            }
        }


        protected void btn_in_Click(object sender, EventArgs e)
        {
            btn_inout("IN");
        }

        protected void btn_out_Click(object sender, EventArgs e)
        {
            btn_inout("OUT");
        }

        private void btn_inout(string type)
        {
            string errMsg = CheckFormData();
            if (string.IsNullOrWhiteSpace(errMsg))
            {
                string staffnumber = this.tb_staffnumber.Text;
                Model.t_AttendanceWebData newrecord = new Model.t_AttendanceWebData();
                newrecord.StaffNumber = staffnumber;
                newrecord.LogDate = System.DateTime.Now;
                newrecord.LogTime = System.DateTime.Now;
                newrecord.Type = type;


                BLL.t_AttendanceWebData.Add(newrecord);

               this.label_msg.InnerText = "success.";
                
            }
            else
            {
                this.label_msg.InnerText = errMsg;
            }
        }


        private string CheckFormData()
        {
            string msg = "";
            string staffNumber = this.tb_staffnumber.Text;
            if (string.IsNullOrWhiteSpace(staffNumber))
            {
                msg = "please input staff number.";
            }
            else
            {
                bool res= BLL.Attendance.CheckStaffName(staffNumber);
                if (!res)
                {
                    msg = "please check your staff Name";
                }
                else
                {
                }
            }
            return msg;
        }

        
        private void InitControls()
        {
            this.tb_data.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
            this.tb_time.Text = System.DateTime.Now.ToString("hh:mm:ss");
        }

        
    }
}