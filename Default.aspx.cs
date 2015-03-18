using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Globalization;

namespace DisplayImages
{
    public partial class _Default : System.Web.UI.Page
    {
        private Random RandomNo = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            String rnumber = this.RandomNo.Next().ToString();
            String img = getimage();

            if (img.Equals("0"))
            {
                ScriptManager.RegisterStartupScript((Page)this, typeof(string), rnumber, "javascript:setsrc(default.tif);", true);

            }
            else
            {
                ScriptManager.RegisterStartupScript((Page)this, typeof(string), rnumber, "javascript:setsrc('" + img + "');", true);
            }
        }



        protected String getimage()
        {
            try
            {
                String img = "test.tif";
                String img2 = System.Configuration.ConfigurationManager.AppSettings["Documentspath"].ToString() + img;
 
                if (File.Exists(img2))
                {
                    return img;
                }
                else
                {
                    return "0";
                    Response.Write("<script>alert('" + img2 + "');</script>");
                }

            }
            catch (Exception ex)
            {
                return "0";
            }
        }
    }
}
