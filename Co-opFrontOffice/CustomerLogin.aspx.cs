using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
        //capture the properties
        string CustomerID = txtCustomerID.Text;
        string Email = txtEmail.Text;
        string Password = txtPassword.Text;
        //validate the data
        String Error = "";
        Error = ACustomerLogin.Valid(CustomerID, Email, Password);
        if (Error == "")
        {
            ACustomerLogin.CustomerID = Convert.ToInt32(CustomerID);
            ACustomerLogin.Email = Email;
            ACustomerLogin.Password = Password;
            Session["ACustomerLogin"] = ACustomerLogin;
            Response.Write("CustomerLoginViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
        Int32 CustomerLoginID;
        Boolean Found = false;
        CustomerLoginID = Convert.ToInt32(txtLoginID.Text);
        Found = ACustomerLogin.Find(CustomerLoginID);
        if (Found == true)
        {
            txtCustomerID.Text = ACustomerLogin.CustomerID.ToString();
            txtEmail.Text = ACustomerLogin.Email;
            txtPassword.Text = ACustomerLogin.Password;
        }
        else
        {
            lblError.Text = "Customer login details not found";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}