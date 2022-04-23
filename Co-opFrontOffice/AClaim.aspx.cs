using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class AClaim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*if (IsPostBack == false)
        {
            DisplayLocations();
        }*/
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsClaim AClaim = new clsClaim();
        //capture the properties
        AClaim.Location = txtLocation.Text;
        AClaim.Status = ddlStatus.Text;
        AClaim.DateOfClaim = Convert.ToDateTime(txtDateOfClaim.Text);
        AClaim.DateOfInjury = Convert.ToDateTime(txtDateOfInjury.Text);
        //store the claim in the session object
        Session["AClaim"] = AClaim;
        Response.Redirect("ClaimViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    //function for populating the location drop down list
    /*void DisplayLocations()
    {
        clsClaimCollection Locations = new clsClaimCollection();
        ddlLocation.DataSource = Locations.AllClaims;
        ddlLocation.DataValueField = "ClaimID";
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataBind();
    }*/

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsClaim AClaim = new clsClaim();
        //variable to store the primary key
        Int32 ClaimID;
        //variable to stor ethe result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ClaimID = Convert.ToInt32(txtClaimID.Text);
        //find the record
        Found = AClaim.Find(ClaimID);
        if (Found == true)
        {
            //display the values of the properties in the form
            txtDateOfClaim.Text = AClaim.DateOfClaim.ToString();
            txtDateOfInjury.Text = AClaim.DateOfInjury.ToString();
            ddlStatus.Text = AClaim.Status;
            txtLocation.Text = AClaim.Location;
        }
        else
        {
            lblError.Text = "Claim not found";
        }
    }
}