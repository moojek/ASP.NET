using System;
using System.Web.UI;

namespace Z4_empty
{
    public partial class print : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["name"];
            string date = Request.QueryString["date"];
            string subject = Request.QueryString["subject"];
            string listNr = Request.QueryString["ListNumber"];

            int[] tasksPoints = new int[11];
            for (int i = 1; i <= 10; i++)
            {
                tasksPoints[i] = int.TryParse(Request.QueryString["task" + i], out int points) ? points : 0;
            }

            // trzeba stworzyć obraz do wydruku
            Response.Write("<h2>Deklaracja</h2>");
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>Imię i nazwisko</th><td>" + name + "</td></tr>");
            Response.Write("<tr><th>Data</th><td>" + date + "</td></tr>");
            Response.Write("<tr><th>Nazwa zajęć</th><td>" + subject + "</td></tr>");
            Response.Write("<tr><th>Numer zestawu</th><td>" + listNr + "</td></tr>");

            Response.Write("<tr><th colspan='2'>Deklarowane zadania</th></tr>");
            for (int i = 1; i <= 10; i++)
            {
                Response.Write("<tr><th>Zadanie " + i + "</th><td>" + tasksPoints[i] + "</td></tr>");
            }
            Response.Write("</table>");
        }
    }
}