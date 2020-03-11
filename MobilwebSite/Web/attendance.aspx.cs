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
        //todo check name's dal?
        //todo db password
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
                DateTime dateTime_now = System.DateTime.Now;

                Model.t_AttendanceWebData newrecord = new Model.t_AttendanceWebData();
                newrecord.StaffNumber = staffnumber;
                newrecord.LogDate = dateTime_now;
                newrecord.LogTime = dateTime_now;
                newrecord.Type = type;

                try
                {
                    BLL.t_AttendanceWebData.Add(newrecord);
                    this.label_msg.InnerHtml = "Success :" +type+ ".&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + staffnumber + ".&nbsp&nbsp&nbsp&nbsp&nbsp" + dateTime_now.ToString("yyyy-MM-dd hh:mm:ss");
                }
                catch(Exception e)
                {
                    this.label_msg.InnerText = e.ToString();
                }
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
                bool res= BLL.t_staff.Exists(staffNumber);
                if (!res)
                {
                    msg = "please check your staff number";
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