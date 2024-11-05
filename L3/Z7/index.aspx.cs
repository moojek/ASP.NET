using System;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Xml;

namespace Z7
{
    public partial class index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) return;
            var file = Request.Files["fileName"];
            if (file == null) return;

            var xmlDoc = new XmlDocument();
            var root = xmlDoc.CreateElement("opis");

            var nameElement = xmlDoc.CreateElement("nazwa");
            nameElement.InnerText = Path.GetFileName(file.FileName);
            root.AppendChild(nameElement);

            var sizeElement = xmlDoc.CreateElement("rozmiar");
            sizeElement.InnerText = file.ContentLength.ToString();
            root.AppendChild(sizeElement);

            var signatureElement = xmlDoc.CreateElement("sygnatura");
            signatureElement.InnerText = GetSignature(file).ToString();
            root.AppendChild(signatureElement);

            xmlDoc.AppendChild(root);
            Response.Clear();
            Response.ContentType = "application/xml";
            Response.ContentEncoding = Encoding.UTF8;
            Response.AddHeader("Content-Disposition", $"attachment; filename=\"{file.FileName}\"");
            Response.AddHeader("Content-Disposition", $"attachment; filename*=UTF-8''{Uri.EscapeDataString(file.FileName)}");
            Response.Write(xmlDoc.OuterXml);
            Response.End();
        }

        private static int GetSignature(HttpPostedFile file)
        {
            var sum = 0;
            using (var fileStream = file.InputStream)
            {
                int byteValue;
                while ((byteValue = fileStream.ReadByte()) != -1)
                {
                    sum += byteValue;
                }
            }

            return sum % 0xFFFF;
        }
    }
}