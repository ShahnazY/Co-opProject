using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class AClaim1 : System.Web.UI.Page
{
    Int32 ClaimID;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        /*Add();
        clsClaim AClaim = new clsClaim();
        //capture the properties
        string Location = txtLocation.Text;
        string Status = ddlStatus.Text;
        string DateOfClaim = txtDateOfClaim.Text;
        string DateOfInjury = txtDateOfInjury.Text;
        //variable to store the error 
        string Error = "";
        //validate the data 
        Error = AClaim.Valid(Location, DateOfClaim, DateOfInjury);
        if (Error == "")
        {
            AClaim.Location = Location;
            AClaim.Status = Status;
            AClaim.DateOfClaim = Convert.ToDateTime(DateOfClaim);
            AClaim.DateOfInjury = Convert.ToDateTime(DateOfInjury);
            //store the claim in the session object
            Session["AClaim"] = AClaim;
            Response.Redirect("ClaimList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        */
        if (ClaimID == -1)
        {
            Add();
        }
        else
        {
            Update();
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    /*protected void btnFind_Click(object sender, EventArgs e)
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
    }*/

    void Add()
    {
        clsClaimCollection Claims = new clsClaimCollection();
        String Error = Claims.ThisClaim.Valid(txtLocation.Text, txtDateOfClaim.Text, txtDateOfInjury.Text);
        if (Error == "")
        {
            //get the data entered by the user
            Claims.ThisClaim.Location = txtLocation.Text;
            Claims.ThisClaim.DateOfClaim = Convert.ToDateTime(txtDateOfClaim.Text);
            Claims.ThisClaim.DateOfInjury = Convert.ToDateTime(txtDateOfInjury.Text);
            Claims.ThisClaim.Status = Convert.ToString(ddlStatus.SelectedValue);
            Claims.ThisClaim.EvidenceProvided = chkYes.Checked;
            //add the record
            Claims.Add();
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered  " + Error;
        }
    }

    void Update()
    {
        clsClaimCollection Claims = new clsClaimCollection();
        //validate the data on the form
        String Error = Claims.ThisClaim.Valid(txtLocation.Text, txtDateOfClaim.Text, txtDateOfInjury.Text);
        //if data is OK then add it to the object
        if (Error == "")
        {
            Claims.ThisClaim.Find(ClaimID);
            //get the data entered by user
            Claims.ThisClaim.Location = txtLocation.Text;
            Claims.ThisClaim.DateOfClaim = Convert.ToDateTime(txtDateOfClaim.Text);
            Claims.ThisClaim.DateOfInjury = Convert.ToDateTime(txtDateOfInjury.Text);
            Claims.ThisClaim.Status = ddlStatus.SelectedValue;
            Claims.ThisClaim.EvidenceProvided = chkYes.Checked;
            //update the record
            Claims.Update();
            //redirect to list
            Response.Redirect("ClaimList.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered  " + Error;
        }
    }
}