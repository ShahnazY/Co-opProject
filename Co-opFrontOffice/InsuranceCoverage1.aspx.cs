using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class InsuranceCoverage1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instace of clsInsurance
        clsInsurance AInsurance = new clsInsurance();
        //capture the dog's name
        AInsurance.Cover = ddlCover.Text;
        //store the name in the session object
        Session["AInsurance"] = AInsurance;
        //redirect to the viewer page
        Response.Redirect("InsuranceCoverageViewer.aspx");
    }

    void Add()
    {
        //create instance of the class
        clsInsuranceCollection NewInsurance = new clsInsuranceCollection();
        //validate the data on the web form
        String Error = NewInsurance.ThisInsurance.Valid(txtInsuranceID.Text, txtDogID.Text, ddlCover.Text, ddlVetFees.Text, txtPrice.Text);
        if (Error == "")
        //string trainerID, string orderNo, string quantity, string price
        {
            NewInsurance.ThisInsurance.InsuranceID = Convert.ToInt32(txtInsuranceID.Text);

            NewInsurance.ThisInsurance.DogID = Convert.ToInt32(txtDogID.Text);

            NewInsurance.ThisInsurance.DentalTreatment = Convert.ToBoolean(chkDentalTreatment.Text);

            NewInsurance.ThisInsurance.Cover = ddlCover.Text;

            NewInsurance.ThisInsurance.VetFees = ddlVetFees.Text;

            NewInsurance.ThisInsurance.Price = Convert.ToInt32(txtPrice.Text);
            NewInsurance.Add();

            lblError.Text = "Cover was sucessfully added for your dog!";
        }
        else
        {
            //report error
            lblError.Text = "There were problems with the data entered: " + Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsInsurance AInsurance = new clsInsurance();
        Int32 DogID;
        Boolean Found = false;
        DogID = Convert.ToInt32(txtDogID.Text);
        Found = AInsurance.Find(DogID);
        if (Found == true)
        {
            ddlCover.Text = AInsurance.Cover;
            ddlVetFees.Text = AInsurance.VetFees;
        }
        else
        {
            lblError.Text = "Dog could not be found";
        }
    }
}