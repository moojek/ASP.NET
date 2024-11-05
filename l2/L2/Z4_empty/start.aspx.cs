using System;
using System.Text;
using System.Web.UI;

namespace Z4_empty
{
    public partial class start : Page
    {
        const string _urlBase = "print.aspx?";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                StringBuilder sb = new StringBuilder(_urlBase);
                sb.Append("name=" + Server.UrlEncode(Request.Form["name"]));
                sb.Append("&date=" + Server.UrlEncode(Request.Form["date"]));
                sb.Append("&subject=" + Server.UrlEncode(Request.Form["subject"]));
                sb.Append("&ListNumber=" + Server.UrlEncode(Request.Form["ListNumber"]));
                for (int i = 1; i <= 10; i++)
                {
                    string taskValue = Request.Form["task" + i];
                    sb.Append("&task" + i + "=" + (string.IsNullOrEmpty(taskValue) ? "0" : Server.UrlEncode(taskValue)));
                }
                Response.Redirect(sb.ToString());
            }
        }
    }
}