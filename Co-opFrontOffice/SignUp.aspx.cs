﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{

    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        //create a new instance of the security class
        clsSecurity Sec = new clsSecurity();
        //try to sign up using the supplied credentials
        string Outcome = Sec.SignUp(txtEMail.Text, txtPassword1.Text, txtPassword2.Text,false);
        //report the outcome of the operation
        lblError.Text = Outcome;
        //store the object in the session objec for other pages to access
        Session["Sec"] = Sec;
    }

    protected void btnDone_Click(object sender, EventArgs e)
    {
        //if done redirect to main page
        Response.Redirect("Default.aspx");
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        //view the email
        Response.Redirect("EMailViewer.aspx");
    }

    protected void btnReSend_Click(object sender, EventArgs e)
    {
        //display re-set password form
        Response.Redirect("ReSet.aspx");
    }
}