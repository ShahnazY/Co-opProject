using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class AFund : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Continuebtn_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        //create instance of the class
        clsShare APurchase = new clsShare();
        //variable to store result
        Boolean Found = false;
        Found = APurchase.FindThePurchaseNo();
        //if the operation is successful
        if (Found == true)
        {
            lblPurchaseNo.Text = "Your Purchase Number is: " + Convert.ToString(APurchase.PurchaseNo);

        }

        else
        {
            lblPurchaseNo.Text = "";
        }



    }
    void Add()
    {
        //create instance of the class
        clsSharesCollection NewPurchase = new clsSharesCollection();
        //validate the data on the web form
        String Error = NewPurchase.ThisPurchase.Valid(txtClientID.Text, txtShares.Text, ddlOrderType.Text, txtDuration.Text, txtSymbol.Text, txtFundID.Text);
        if (Error == "")
        {
            NewPurchase.ThisPurchase.ClientID = Convert.ToInt32(txtClientID.Text);
            //capture shares
            NewPurchase.ThisPurchase.Shares = Convert.ToInt32(txtShares.Text);
            //capture order type
            NewPurchase.ThisPurchase.OrderType = ddlOrderType.Text;
            //capture duration
            NewPurchase.ThisPurchase.Duration = Convert.ToDateTime(txtDuration.Text);
            //capture symbol
            NewPurchase.ThisPurchase.Symbol= txtSymbol.Text;
            NewPurchase.ThisPurchase.FundID = Convert.ToInt32(txtFundID.Text);
            //add the record
            NewPurchase.Add();

            lblError.Text = "New share was added succesfully, your purchase number will be provided shortly, to continue with your purchase.";
        }
        else
        {
            //report error

            lblError.Text = Error;
        }

        
     

    }
}