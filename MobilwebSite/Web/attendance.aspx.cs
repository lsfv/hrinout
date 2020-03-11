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
            string errMsg = CheckFormData();
            if (string.IsNullOrWhiteSpace(errMsg))
            {
                int res= BLL.Attendance.Insert();
                this.label_msg.InnerText = "success:" + res;
            }
            else
            {
                this.label_msg.InnerText = errMsg;
            }
        }

        protected void btn_out_Click(object sender, EventArgs e)
        {
            string errMsg = CheckFormData();
            if (string.IsNullOrWhiteSpace(errMsg))
            {
                int res = BLL.Attendance.Insert();
                this.label_msg.InnerText = "success:" + res;
            }
            else
            {
                this.label_msg.InnerText = errMsg;
            }
        }


        private string CheckFormData()
        {
            string msg = "";
            if (string.IsNullOrWhiteSpace(this.tb_staffnumber.Text))
            {
                msg = "please input staff number.";
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