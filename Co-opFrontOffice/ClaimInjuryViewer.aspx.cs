using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class ClaimInjuryViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //instance of the clsClaim
        clsClaimInjury AClaimInjury = new clsClaimInjury();
        //get the data from the session object
        AClaimInjury = (clsClaimInjury)Session["AClaimInjury"];
        //display the house  number for this entry
        Response.Write(AClaimInjury.InjuryID);
        Response.Write(AClaimInjury.ClaimID);
    }
}