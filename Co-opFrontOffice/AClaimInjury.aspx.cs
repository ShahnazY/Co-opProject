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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsClaimInjury AClaimInjury = new clsClaimInjury();
        //variable to store the primary key
        Int32 ClaimInjuryID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ClaimInjuryID = Convert.ToInt32(txtClaimInjuryID.Text);
        //find the record 
        Found = AClaimInjury.Find(ClaimInjuryID);
        //if found 
        if (Found == true)
        {
            //display the values in the textboxes
            txtClaimID.Text = AClaimInjury.ClaimID.ToString();
            txtPersonalInjuryID.Text = AClaimInjury.InjuryID.ToString();
        }
        else
        {
            lblError.Text = "Claim Injury not found";
        }
    }
}