using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Remove : System.Web.UI.Page
{
    clsCart MyCart = new clsCart();

    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 Index;
        //upon loading the page you need to read in the cart from the session object
        MyCart = (clsCart)Session["MyCart"];
        //get the index of the item to remove
        Index = Convert.ToInt32(Request.QueryString["Index"]);
        //remove the item in the query string
        MyCart.Products.RemoveAt(Index);
        //go back to view cart
        Response.Redirect("Viewcart.aspx");
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //you must also save the cart every time the unload event takes place
        Session["MyCart"] = MyCart;
    }


}