using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class print : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["name"];
            string date = Request.QueryString["date"];
            string subject = Request.QueryString["subject"];
            string ListNumber = Request.QueryString["ListNumber"];

            int[] taskPoints = new int[10];
            for (int i = 1; i <= 10; i++)
            {
                taskPoints[i - 1] = int.TryParse(Request.QueryString["task" + i], out int points) ? points : 0;
            }

            // trzeba stworzyć obraz do wydruku
            Response.Write("<h2>Deklaracja</h2>");
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>Imię i nazwisko</th><td>" + name + "</td></tr>");
            Response.Write("<tr><th>Data</th><td>" + date + "</td></tr>");
            Response.Write("<tr><th>Nazwa zajęć</th><td>" + subject + "</td></tr>");
            Response.Write("<tr><th>Numer zestawu</th><td>" + ListNumber + "</td></tr>");

            Response.Write("<tr><th colspan='2'>Deklarowane zadania</th></tr>");
            for (int i = 0; i < taskPoints.Length; i++)
            {
                Response.Write("<tr><th>Zadanie " + (i + 1) + "</th><td>" + taskPoints[i] + "</td></tr>");
            }
            Response.Write("</table>");
        }
    }
}
