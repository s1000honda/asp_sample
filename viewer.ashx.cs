using System;
using System.Web;
using System.IO;
using System.Configuration;

namespace DisplayImages
{
    /// <summary>
    /// Summary description for viewer
    /// </summary>
    public class viewer : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                string filepath = System.Configuration.ConfigurationManager.AppSettings["Documentspath"].ToString() + context.Request.QueryString["FileName"];
                context.Response.ContentType = "image/tiff";

                context.Response.Flush();
                context.Response.WriteFile(filepath);
                context.Response.End();
            }
            catch (Exception ex)
            {

            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
