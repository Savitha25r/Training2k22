﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemanagement
{
    public partial class QuerySource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnclick_Click(object sender, EventArgs e)
        {
            Response.Redirect("QueryDestination.aspx?uname=" + Txtname.Text +
                "&psswd=" + Txtpsswd.Text);
        }
    }
}