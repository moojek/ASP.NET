using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class start : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string url = "print.aspx?";
                url += "name=" + Server.UrlEncode(Request.Form["name"]);
                url += "&date=" + Server.UrlEncode(Request.Form["date"]);
                url += "&subject=" + Server.UrlEncode(Request.Form["subject"]);
                url += "&ListNumber=" + Server.UrlEncode(Request.Form["ListNumber"]);
                for (int i = 1; i <= 10; i++)
                {
                    string taskValue = Request.Form["task" + i];
                    url += "&task" + i + "=" + (string.IsNullOrEmpty(taskValue) ? "0" : Server.UrlEncode(taskValue));
                }
                Response.Redirect(url);
            }
        }
    }
}
