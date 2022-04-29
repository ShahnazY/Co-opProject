using ClassLibrary;
using Co_opClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Co_opBackOffice
{
    public partial class frmFunds : Form
    {
        public frmFunds()
        {
            InitializeComponent();
            btnNo.Visible = false;
            btnYes.Visible = false;
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            //call the display customers function
            lblError.Text = DisplayFunds() + " funds found";
        }

        Int32 DisplayFunds()
        {
            //create instamce of the Fund Collection
            clsFundCollection Funds = new clsFundCollection();
            //set the data source to the list of funds in the collection
            lstFunds.DataSource = Funds.FundList;
            //set the name of primary key
            lstFunds.ValueMember = "FundNo";
            //set the data field to display
            lstFunds.DisplayMember = "FundName";
            return Funds.Count;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 FundNo;
            //if a record has beenselected from the list
            if (lstFunds.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                FundNo = Convert.ToInt32(lstFunds.SelectedValue);
                //find the record to edit 
                clsFundCollection AllFunds = new clsFundCollection();
                AllFunds.ThisFund.Find(FundNo);
                //display the data for record with chosen FundNo
                txtSymbol.Text = AllFunds.ThisFund.Symbol;
                txtRisk.Text = AllFunds.ThisFund.Risk.ToString();
                txtMarketPrice.Text = AllFunds.ThisFund.MarketPrice;
                txtStocks.Text = AllFunds.ThisFund.Stocks.ToString();
                txtFundName.Text = AllFunds.ThisFund.FundName;
                txtChange.Text = AllFunds.ThisFund.Change;
                txtObjective.Text = AllFunds.ThisFund.Objective;

            }
            else
            {
                //display an error
                lblError1.Text = "You must select an item from the list to edit it.";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        void Add()
        {
            //create instance of the class
            clsFundCollection NewFund = new clsFundCollection();
            //validate the data on the web form
            String Error = NewFund.ThisFund.Valid(txtSymbol.Text, txtFundName.Text, txtRisk.Text, txtObjective.Text, txtChange.Text, txtStocks.Text, txtMarketPrice.Text);
            if (Error == "")
            {
                NewFund.ThisFund.Symbol = txtSymbol.Text;
                //capture fund name
                NewFund.ThisFund.FundName = txtFundName.Text;
                //capture risk
                NewFund.ThisFund.Risk = Convert.ToInt32(txtRisk.Text);
                //capture Objective
                NewFund.ThisFund.Objective = txtObjective.Text;
                //capture Change
                NewFund.ThisFund.Change = txtChange.Text;
                //capture stocks
                NewFund.ThisFund.Stocks = Convert.ToInt32(txtStocks.Text);
                //capture market price
                NewFund.ThisFund.MarketPrice = txtMarketPrice.Text;
                //add the record
                NewFund.Add();

                lblError.Text = "New fund was added succesfully. ";
            }



            else
            {
                //report error

                lblError1.Text = Error;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        void Update()
        {
            Int32 FundNo;
            FundNo = Convert.ToInt32(lstFunds.SelectedValue);
            //create an instance of fund collection class
            clsFundCollection FundCollection = new clsFundCollection();
            clsDataConnection DB = new clsDataConnection();
            //validate the data on the web form
            String Error = FundCollection.ThisFund.Valid(txtSymbol.Text, txtFundName.Text, txtRisk.Text, txtObjective.Text, txtChange.Text, txtStocks.Text, txtMarketPrice.Text);
            //if there is no error
            if (Error == "")
            {
                //find the record using primary key to update
                FundCollection.ThisFund.Find(FundNo);
                //get the data entered by the user 
                FundCollection.ThisFund.Symbol = txtSymbol.Text;
                //capture fund name
                FundCollection.ThisFund.FundName = txtFundName.Text;
                //capture risk
                FundCollection.ThisFund.Risk = Convert.ToInt32(txtRisk.Text);
                //capture Objective
                FundCollection.ThisFund.Objective = txtObjective.Text;
                //capture Change
                FundCollection.ThisFund.Change = txtChange.Text;
                //capture stocks
                FundCollection.ThisFund.Stocks = Convert.ToInt32(txtStocks.Text);
                //capture market price
                FundCollection.ThisFund.MarketPrice = txtMarketPrice.Text;
                //updatethe record
                FundCollection.Update();
                Clear();
                lblError.Text = DisplayFunds() + " Funds found";
                lblError1.Text = "The selected fund has been updated.";
            }
            else
            {
                //report an error
                lblError1.Text = "There were problems with the data entered " + Error;
            }

        }//end of edit

        //function to clear the data in the text boxes
        void Clear()
        {
            txtSymbol.Text = string.Empty;
            txtMarketPrice.Text = string.Empty;
            txtStocks.Text = string.Empty;
            txtChange.Text = string.Empty;
            txtFundName.Text = string.Empty;
            txtObjective.Text = string.Empty;
            txtRisk.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 FundNo;
            //if a record has beenselected from the list
            if (lstFunds.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                FundNo = Convert.ToInt32(lstFunds.SelectedValue);
                //show confirmation message
                lblError1.Text = "Are you sure you want to delete this fund?";

                //show buttons which were not visible before to confirm
                btnNo.Visible = true;
                btnYes.Visible = true;

            }
            else
            {
                //display an error
                lblError1.Text = "Please select a record from the list first. ";
            }
        }// end of delete on click

        void Delete()
        {
            //var to store primary key value
            Int32 FundNo;
            //create a new in stance of collection class
            clsFundCollection AllFunds = new clsFundCollection();
            //find the record to delete
            FundNo = Convert.ToInt32(lstFunds.SelectedValue);
            AllFunds.ThisFund.Find(FundNo);
            //delete the record 
            AllFunds.Delete();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Delete();
            //show confirmation message
            lblError1.Text = "This fund has ben deleted";
            btnYes.Visible = false;
            btnNo.Visible = false;

            Clear();
            DisplayFunds();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            lblError1.Text = string.Empty;
            btnYes.Visible = false;
            btnNo.Visible = false;
        }

        private void btnFilterFundNo_Click(object sender, EventArgs e)
        {
            //create an instance of the fund class
            clsFund AFund = new clsFund();
            //variable to store the primary key 
            Int32 FundNo;
            //variable to store the result of the find operation
            Boolean Found = false;
            //if the filter was provided
            if (txtFilterFundNo.Text != "")
            {
                //get the primary key entered by the user
                FundNo = Convert.ToInt32(txtFilterFundNo.Text);
                //find the record
                Found = AFund.Find(FundNo);
                //a list so that the DataSource can be used then 
                List<string> Fund = new List<string>();
                //if found
                if (Found == true)
                {
                    Fund.Add(AFund.FundName);
                    lstFunds.DataSource = Fund;
                    //set the text to be displayed
                    lstFunds.DisplayMember = "FundName";
                    lblError.Text = "1 record found";
                }
                else
                {
                    lblError.Text = "Fund number not found";
                }
            }
            else
            {
                //show an error 
                lblError1.Text = "Provide a valid Fund number";
            }
        }

       
    }
}
