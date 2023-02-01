using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemanagement
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_redirect_Click(object sender, EventArgs e)
        {
            //persistant cookies - will make use of httpcookie class
            //HttpCookie hc = new HttpCookie("MyCookie");
            //hc["d1"] = Textname.Text;
            //hc["d2"] = Textpsswd.Text;
            //Response.Cookies.Add(hc);
            //Response.Redirect("CookieDestination.aspx");

            //non-persistant cookie
            Response.Cookies["data1"].Value = Textname.Text;
            Response.Cookies["data2"].Value = Textpsswd.Text;
            Response.Redirect("CookieDestination.aspx");
        }
    }
}