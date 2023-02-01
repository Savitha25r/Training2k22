using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemanagement
{
    public partial class PostBack : System.Web.UI.Page
    {
        int ClicksCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt1.Text = "0";
            }

        }

        protected void btnclick_Click(object sender, EventArgs e)
        {
            /* step 1
            ClicksCount = ClicksCount + 1;
            txt1.Text = ClicksCount.ToString();*/
            //step 2 using viewstate variables
            //if(ViewState["Clicks"]!=null)
            //{
            //    ClicksCount = (int)ViewState["Clicks"] + 1;
            //}
            //txt1.Text = ClicksCount.ToString();
            //ViewState["Clicks"] = ClicksCount;

            //step 3 without creating view state variable, since 
            //every asp control has a viewstate variable that can maintain the state
            ClicksCount = Convert.ToInt32(txt1.Text)+1;
            txt1.Text = ClicksCount.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Request.Cookies["data1"].Value + Request.Cookies["Data2"].Value;

        }
    }
}