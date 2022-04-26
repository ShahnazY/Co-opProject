using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of the class
        clsCustomer ACustomer = new clsCustomer();
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Email = txtEmail.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string Gender = ddlGender.Text;
        string HouseNo = txtHouseNo.Text;
        string Street = txtStreet.Text;
        string Town = ddlTown.Text;
        string PostCode = txtPostCode.Text;
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
        if (Error == "")
        {
            //capture the properties
            ACustomer.FirstName = FirstName;
            ACustomer.LastName = LastName;
            ACustomer.Email = Email;
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            ACustomer.Gender = Gender;
            ACustomer.HouseNo = HouseNo;
            ACustomer.Street = Street;
            ACustomer.Town = Town;
            ACustomer.PostCode = PostCode;
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = ACustomer.Find(CustomerID);
        if(Found == true)
        {
            txtFirstName.Text = ACustomer.FirstName;
            txtLastName.Text = ACustomer.LastName;
            txtEmail.Text = ACustomer.Email;
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();
            txtHouseNo.Text = ACustomer.HouseNo;
            txtStreet.Text = ACustomer.Street;
            txtPostCode.Text = ACustomer.PostCode;
        }
        else
        {
            lblError.Text = "Customer not found";
        }
    }
}