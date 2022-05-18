using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DogDetails : System.Web.UI.Page
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        {
            //create a new instance of clsCartItem
            clsCartItem AnInsurance = new clsCartItem();
            //set the product id
            AnInsurance.ProductID = ProductID;
            //set the quantity
            AnInsurance.QTY = Convert.ToInt32(txtQuanity.Text);
            //add the item to the cart's products collection
            MyCart.Products.Add(AnInsurance);
            //go back to shopping
            Response.Redirect("Viewcart.aspx");
        }
    }
}