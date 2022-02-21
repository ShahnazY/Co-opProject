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
        if (IsPostBack == false)
        {
            DisplayLocations();
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsClaim AClaim = new clsClaim();
        string Error;
        string Status;
        Status = txtStatus.Text;
        Error = AClaim.Valid(Status);
        lblError.Text = Error;
        Response.Redirect("Default.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    //function for populating the location drop down list
    void DisplayLocations()
    {
        clsClaimCollection Locations = new clsClaimCollection();
        ddlLocation.DataSource = Locations.AllClaims;
        ddlLocation.DataValueField = "ClaimID";
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataBind();
    }
}