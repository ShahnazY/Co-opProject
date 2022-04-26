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
        ACustomerLogin.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        ACustomerLogin.Email = txtEmail.Text;
        ACustomerLogin.Password = txtPassword.Text;
        Session["ACustomerLogin"] = ACustomerLogin;
        Response.Redirect("CustomerLoginViewer.aspx");
    }
}