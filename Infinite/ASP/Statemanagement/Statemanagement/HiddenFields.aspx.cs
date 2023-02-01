using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemanagement
{
    public partial class HiddenFields : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_store_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = txtname.Text;
            HiddenField2.Value = txtcity.Text;
            txtname.Text = "";
            txtcity.Text = string.Empty;
        }

        protected void btn_load_Click(object sender, EventArgs e)
        {
            Label1.Text = HiddenField1.Value + " " + HiddenField2.Value;
        }
    }
}