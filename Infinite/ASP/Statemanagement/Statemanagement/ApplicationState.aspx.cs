using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemanagement
{
    public partial class ApplicationState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnapplication_Click(object sender, EventArgs e)
        {
            int count = 0;
            if(Application["visits"]!=null)
            {
                count = Convert.ToInt32(Application["visits"].ToString());
            }
            count = count + 1;
            Application["visits"] = count;

            lblvisits.Text = "Total Visits to the Site =" + count.ToString();
        }
    }
}