using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;
using ClassLibrary;

public partial class InsuranceList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box
            DisplayInsurances();
        }
    }
    void DisplayInsurances()
    {
        clsInsuranceCollection Insurances = new clsInsuranceCollection();
        lstInsurance.DataSource = Insurances.InsuranceList;
        lstInsurance.DataValueField = "InsuranceID";
        lstInsurance.DataTextField = "AllInsurances";
        lstInsurance.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the sessionobject to indicate this is a new record
        Session["InsuranceID"] = -1;
        //redirect to the data entry page
        Response.Redirect("DogDetails.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 InsuranceID;
        //if a record is selected from the list 
        if (lstInsurance.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            InsuranceID = Convert.ToInt32(lstInsurance.SelectedValue);
            //store the data in the session object
            Session["InsuranceID"] = InsuranceID;
            //redirect to the delete page
            Response.Redirect("DeleteInsurance.aspx");
        }
        else
        {
            lblError.Text = "Record must be selected from the list to delete";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 InsuranceID;
        if (lstInsurance.SelectedIndex != -1)
        {
            InsuranceID = Convert.ToInt32(lstInsurance.SelectedValue);
            Session["InsuranceID"] = InsuranceID;
            Response.Redirect("AInsurance.aspx");
        }
        else
        {
            lblError.Text = "Record must be selected from the list before editing";
        }
    }
}