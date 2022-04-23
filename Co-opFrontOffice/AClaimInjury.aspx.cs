using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class AClaimInjury : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //new instance of clsClaimInjury
        clsClaimInjury AClaimInjury = new clsClaimInjury();
        //capture the properties
        AClaimInjury.ClaimID = Convert.ToInt32(txtClaimID.Text);
        AClaimInjury.InjuryID = Convert.ToInt32(txtPersonalInjuryID.Text);
        //store the claiminjury in the session object
        Session["AClaimInjury"] = AClaimInjury;
        //redirect to the viewer page
        Response.Redirect("ClaimInjuryViewer.aspx");
    }
}