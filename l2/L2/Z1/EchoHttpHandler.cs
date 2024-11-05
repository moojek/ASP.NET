using System.IO;
using System.Web;

namespace Z1
{
    public class EchoHttpHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(context.Request.HttpMethod);
            context.Response.Write(' ');
            context.Response.Write(context.Request.Url);
            context.Response.Write('\n');
            foreach (var header in context.Request.Headers.AllKeys)
            {
                context.Response.Write(header);
                context.Response.Write(": ");
                context.Response.Write(context.Request.Headers[header]);
                context.Response.Write("\n");
            }

            context.Response.Write("\n");

            if (context.Request.InputStream.Length != 0)
                context.Response.Write(new StreamReader(context.Request.InputStream).ReadToEnd());
        }

        public bool IsReusable { get; }
    }
}