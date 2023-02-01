using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day1_EmptyPrj
{
    public partial class FirstForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("page Load" + "<br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Init Complete" + "<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("page Init" + "<br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Pre Load" + "<br/>");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Pre Init" + "<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Pre Render" + "<br/>");
        }
        protected void Page_Render(object sender, EventArgs e)
        {
            Response.Write("Render" + "<br/>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
             // Response.Write("page Un Load");
        }

        protected void Page_Pre_Render(object sender, EventArgs e)
        {
              Response.Write("Pre Render");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text="Hello All";
            
        }
    }
}