using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    clsCart MyCart = new clsCart();

    protected void Page_Load(object sender, EventArgs e)
    {
        //upon loading the page you need to read in the cart from the session object
        MyCart = (clsCart)Session["MyCart"];
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //you must also save the cart every time the unload event takes place
        Session["MyCart"] = MyCart;
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the authentication class
        clsDummySecurity Login = new clsDummySecurity();
        //declare a variable to store the user no if the user who logged in
        Int32 UserNo;
        //authenticate the login
        UserNo = Login.SignIn(txtUserName.Text, txtPassword.Text);
        //if there is a user number returned
        if (UserNo != 0)
        {
            //set the user no of the cart
            MyCart.UserNo = UserNo;
            //go onto the next step
            Response.Redirect("Checkout.aspx");
        }
        else
        {
            //otherwise the login failed so report an error
            lblError.Text = "Login failed";
        }
    }
}