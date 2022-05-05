using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        //try to sign in and record any errors
        String Error = Sec.SignIn(txtEMail.Text, txtPassword.Text);
        //if there were no errors
        if (Error == "")
        {
            //redirect to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //otherwise display any errors
            lblError.Text = Error;
        }
    }
}
}