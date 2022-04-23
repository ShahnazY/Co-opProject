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
        //capture the properties
        ACustomer.FirstName = txtFirstName.Text;
        ACustomer.LastName = txtLastName.Text;
        ACustomer.Email = txtEmail.Text;
        ACustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        ACustomer.Gender = ddlGender.Text;
        ACustomer.HouseNo = txtHouseNo.Text;
        ACustomer.Street = txtStreet.Text;
        ACustomer.Town = ddlTown.Text;
        ACustomer.PostCode = txtPostCode.Text;
        //store the customer in the session object
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

  
}