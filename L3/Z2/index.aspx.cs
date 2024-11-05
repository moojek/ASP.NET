using System;
using System.Globalization;
using System.IO;
using System.Web;
using System.Web.UI;

namespace Z2
{
    public partial class index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies.Add(new HttpCookie("datetime", DateTime.Now.ToString(CultureInfo.InvariantCulture)));
            Response.Write(Request.Cookies["datetime"]?.Value ?? "no cookie");
        }
    }
}