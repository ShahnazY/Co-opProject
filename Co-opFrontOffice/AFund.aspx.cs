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
        if (IsPostBack == false)
        {
            //update the list box
            DisplayFunds();
        }
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

    protected void btnDisplayFunds_Click(object sender, EventArgs e)
    {
        //create instance of the class
        clsFund AFund = new clsFund();
        //variable to store symbol
        Int32 FundNo;
        //variable to store the result
        Boolean Found = false;
        //get the primary key entered by the user
        FundNo = Convert.ToInt32(txtFindSymbol.Text);
        //find the record
        Found = AFund.Find(FundNo);
        //if found
        if (Found == true)
        {
            //display the values in the form
            lbDescription.Text = AFund.FullDescription.ToString();


        }
        else
        {
            lblError.Text = "Fund number not found";
        }
    }

    void DisplayFunds()
    {
        //create instamce of the Fund Collection
        clsFundCollection Funds = new clsFundCollection();
        //set the data source to the list of funds in the collection
        lbFunds.DataSource = Funds.FundList;

        lbFunds.DataValueField = "FundNo";
        lbFunds.DataTextField = "AllDetails";
        lbFunds.DataBind();
    }


    protected void Clearbtn_Click(object sender, EventArgs e)
    {
        Clear();
    }
    void Clear()
    {
        txtSymbol.Text = string.Empty;
        txtClientID.Text = string.Empty;
        txtShares.Text = string.Empty;
        txtDuration.Text = string.Empty;
        txtFundID.Text = string.Empty;
    }

    protected void Holdingsbtn_Click(object sender, EventArgs e)
    {
        //instance of shares class
        clsShare APurchase = new clsShare();
        //variable to store ClietID
        Int32 ClientID;
        Boolean Found = false;
        ClientID = Convert.ToInt32(txtFindID.Text);
        Found = APurchase.Find(ClientID);
        //a list so that the DataSource can be used then 
        List<string> Purchase = new List<string>();
        if (Found == true) 
        {
            Purchase.Add(APurchase.Symbol);

            lbPurchases.DataSource = Purchase;
            //set the text to be displayed
            lbPurchases.DataTextField = "AllPurchases";
        }
    }

    
}