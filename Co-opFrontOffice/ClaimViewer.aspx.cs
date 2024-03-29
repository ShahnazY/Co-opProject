﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class ClaimViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //instance of the clsClaim
        clsClaim AClaim = new clsClaim();
        //get the data from the session object
        AClaim = (clsClaim)Session["AClaim"];
        //display the house  number for this entry
        Response.Write(AClaim.Location);
        Response.Write(AClaim.Status);
        Response.Write(AClaim.DateOfClaim);
        Response.Write(AClaim.DateOfInjury);
    }
}