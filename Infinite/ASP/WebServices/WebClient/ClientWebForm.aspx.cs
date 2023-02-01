using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class ClientWebForm : System.Web.UI.Page
    {
        MyServicesReference.MyServicesSoapClient client = new MyServicesReference.MyServicesSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void msgbtn_Click(object sender, EventArgs e)
        {           
            lbldata.Text=client.Message(txtname.Text);
        }

        protected void hellobtn_Click(object sender, EventArgs e)
        {
            //MyServicesReference.MyServicesSoapClient client = new MyServicesReference.MyServicesSoapClient();
            lbldata.Text=client.HelloWorld();
        }

        protected void sqbtn_Click(object sender, EventArgs e)
        {
            float res = client.Squareroot(float.Parse(txtnum.Text));
            lbldata.Text = res.ToString();
        }
    }
}