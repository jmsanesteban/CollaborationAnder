﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JallouWorld
{
    public partial class JallouWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMessage_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Ever tried. Ever failed. No matter. Try Again. Fail again. Fail better.";
        }
    }
}