using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class ClaimList1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box
            DisplayClaims();
        }
    }

    void DisplayClaims()
    {
        clsClaimCollection Claims = new clsClaimCollection();
        lstClaims.DataSource = Claims.ClaimsList;
        lstClaims.DataValueField = "ClaimID";
        lstClaims.DataTextField = "AllDetails";
        lstClaims.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the sessionobject to indicate this is a new record
        Session["ClaimID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AClaim.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 ClaimID;
        //if a record is selected from the list 
        if (lstClaims.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ClaimID = Convert.ToInt32(lstClaims.SelectedValue);
            //store the data in the session object
            Session["ClaimID"] = ClaimID;
            //redirect to the delete page
            Response.Redirect("DeleteClaim.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ClaimID;
        if (lstClaims.SelectedIndex != -1)
        {
            ClaimID = Convert.ToInt32(lstClaims.SelectedValue);
            Session["ClaimID"] = ClaimID;
            Response.Redirect("AClaim.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}