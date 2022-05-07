﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class Co_opProject : System.Web.UI.MasterPage
{
    //create an instance of the security 
    clsSecurity Sec;
    protected void Page_Load(object sender, EventArgs e)
    {
        //on load get the current state from the session
        Sec = (clsSecurity)Session["Sec"];
        //if the object is null then it needs initialising
        if (Sec == null)
        {
            //initialise the object
            Sec = new clsSecurity();
            //update the session
            Session["Sec"] = Sec;
        }
        //set the state of the linsk based on the cureent state of authentication
        SetLinks(Sec.Authenticated);
    }

    private void SetLinks(Boolean Authenticated)
    {
        ///sets the visiible state of the links based on the authentication state
        ///

        //set the state of the following to not authenticated i.e. they will be visible when not logged in
        hypReSet.Visible = !Authenticated;
        hypSignUp.Visible = !Authenticated;
        hypSignIn.Visible = !Authenticated;
        //set the state of the following to authenticated i.e. they will be visible when user is logged in
        hypChangePassword.Visible = Authenticated;
        hypSignOut.Visible = Authenticated;
    }
}
