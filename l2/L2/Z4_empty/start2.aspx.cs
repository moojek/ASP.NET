using System;
using System.Web.UI;

namespace Z4_empty
{
    public partial class start2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Session["name"] = Request.Form["name"];
                Session["date"] = Request.Form["date"];
                Session["subject"] = Request.Form["subject"];
                Session["ListNumber"] = Request.Form["ListNumber"];

                for (int i = 1; i <= 10; i++)
                {
                    string taskValue = Request.Form["task" + i];
                    Session["task" + i] = string.IsNullOrEmpty(taskValue) ? "0" : taskValue;
                }
                
                Response.Redirect("print2.aspx");
            }
        }
    }
}
