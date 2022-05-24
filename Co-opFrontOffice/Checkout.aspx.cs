using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddingClient2 : System.Web.UI.Page
{
    clsCart MyCart = new clsCart();
    protected void Page_Load(object sender, EventArgs e)
    {
        //upon loading the page you need to read in the cart from the session object
        MyCart = (clsCart)Session["MyCart"];

        //if we don't know who the user is we need them to log in
        if (MyCart.UserNo == 0)
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //you must also save the cart every time the unload event takes place
        Session["MyCart"] = MyCart;
    }



    protected void btnCheckout_Click(object sender, EventArgs e)
    {

        Response.Redirect("Thanks.aspx");
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Funds.aspx");
    }
}
