using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemanagement
{
    public partial class CookieDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            //reading values using persistant cookie
            //HttpCookie rc = Request.Cookies["MyCookie"];
            //lbl1.Text = rc["d1"];
            //lbl2.Text = rc["d2"];

            //reading non-persistant cookie values
            lbl1.Text = Request.Cookies["data1"].Value.ToString();
            lbl2.Text = Request.Cookies["data2"].Value;
            Response.Redirect("Postback.aspx");


        }
    }
}