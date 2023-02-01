using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjExceptions
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
                DataSet ds = new DataSet();
            //to invoke the custom error page of 404 http status code
               Response.Redirect("Hello.aspx");
                ds.ReadXml(Server.MapPath("~/Employees.xml"));
                GridView1.DataSource = ds;
                GridView1.DataBind();
            //}
            //catch (System.IO.FileNotFoundException fnf)
            //{
            //    Label1.Text = "The File is Missing..";
            //}
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            //    Exception ex = Server.GetLastError();
            //    Server.ClearError();
            //    // Response.Write(ex.GetType());
            //    Server.Transfer("~/Errors.aspx");
            //   // Response.Redirect("Errors.aspx");

        }
    }
}
