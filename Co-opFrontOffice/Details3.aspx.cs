using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Details3 : System.Web.UI.Page
{
    clsCart MyCart = new clsCart();
    Int32 ProductID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //upon loading the page you need to read in the cart from the session object
        MyCart = (clsCart)Session["MyCart"];
        //you also need to get the product id from the query string
        ProductID = Convert.ToInt32(Request.QueryString["ProductID"]);
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //you must also save the cart every time the unload event takes place
        Session["MyCart"] = MyCart;
    }

    protected void btnContinue_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCartItem
        clsCartItem AnItem = new clsCartItem();
        //set the product id
        AnItem.ProductID = ProductID;
        //set the quantity
        AnItem.QTY = Convert.ToInt32(txtQTY.Text);
        //add the item to the cart's products collection
        MyCart.Products.Add(AnItem);
        //go back to shopping
        Response.Redirect("Purchase.aspx");
    }
}