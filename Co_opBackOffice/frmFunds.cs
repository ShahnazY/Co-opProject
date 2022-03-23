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
    }
}
