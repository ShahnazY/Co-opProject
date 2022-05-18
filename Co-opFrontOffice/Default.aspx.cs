using Co_opClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    
    //create an object based on the security class
    clsSecurity Sec;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the security data from the session
        Sec = (clsSecurity)Session["Sec"];
        //if it is null then this is the first run of the site
        if (Sec == null)
        {
            //initialise the object
            Sec = new clsSecurity();
            //save it to the session
            Session["Sec"] = Sec;
        }
        //set the state of the menu buttons
        Authenticated(Sec.Authenticated);
    }

    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        //go to sign up
        Response.Redirect("SignUp.aspx");
    }

    protected void btnReSet_Click(object sender, EventArgs e)
    {
        //go to re-set
        Response.Redirect("ReSet.aspx");
    }

    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        //go to change password
        Response.Redirect("ChangePassword.aspx");
    }

    protected void btnSignOut_Click(object sender, EventArgs e)
    {
        //go to sign out
        Response.Redirect("SignOut.aspx");
    }

    void Authenticated(Boolean Auth)
    {
        //sets the visibility of the buttons on the main menu based on authentication state
        //if not logged in then dsiplay the following
        btnSignIn.Visible = !Auth;
        btnSignUp.Visible = !Auth;
        btnReSet.Visible = !Auth;
        //if logged in display the following
        btnChangePassword.Visible = Auth;
        btnSignOut.Visible = Auth;
        btnFunds.Visible = Auth;
        btnPurchase.Visible = Auth;
        btnClaims.Visible = Auth;
    }


    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        //go to sign in
        Response.Redirect("SignIn.aspx");

    }

    protected void btnFunds_Click(object sender, EventArgs e)
    {
        //go to funds
        Response.Redirect("AFund.aspx");
    }
    protected void btnPurchase_Click(object sender, EventArgs e)
    {
        //go to funds
        Response.Redirect("Purchase.aspx");
    }

    protected void btnClaims_Click(object sender, EventArgs e)
    {
        Response.Redirect("AClaim1.aspx");
    }

    protected void btnClaims_Click1(object sender, EventArgs e)
    {
        Response.Redirect("AClaim1.aspx");
    }

    protected void btnInsurance_Click(object sender, EventArgs e)
    {
        Response.Redirect("ADog1.aspx");
    }
}