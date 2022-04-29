using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_opClasses
{
    public class clsSharesCollection
    {
        List<clsShare> mPurchaseList = new List<clsShare>();
        clsShare mThisPurchase = new clsShare();

        //these lines of cone contain the constructor of the class
        /////////////////////////////////////////
        /////////////////////////////////////////
        ////////////////////////////////////////

        public clsSharesCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblPurchases_SelectAll");
            //populate the array list with data table
            Populate(DB);
        }
        /// 
        /// THE CONSTRUCTOR ENDS HERE
        ///
        public List<clsShare> PurchaseList
        {
            get
            {
                //return the private data
                return mPurchaseList;

            }

            set
            {
                //set the private data
                mPurchaseList = value;

            }
        }


        public int Count
        {
            get
            {
                //return the private data
                return mPurchaseList.Count;
            }

            set
            {
                //we will do this later
            }
        }


        public clsShare ThisPurchase
        {
            get
            {
                //return the private data
                return mThisPurchase;
            }
            set
            {
                //set the private data
                mThisPurchase = value;
            }

        }

        //function for adding new order
        public int Add()
        {
            //adds a new record to the database based on the value value of mThisOrder
            //set the primary key value of the record
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@ClientID", mThisPurchase.ClientID);
            DB.AddParameter("@Shares", mThisPurchase.Shares);
            DB.AddParameter("@OrderType", mThisPurchase.OrderType);
            DB.AddParameter("@Duration", mThisPurchase.Duration);
            DB.AddParameter("@Symbol", mThisPurchase.Symbol);
            DB.AddParameter("@FundID", mThisPurchase.FundID);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblPurchase_Insert");
        }


        public void ReportByClientID(int ClientID)
        {
            //filters the records based on full or partial post code
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@ClientID", ClientID);
            //execute the stored proc
            DB.Execute("sproc_tblOrder_FilterByClientID");
            //populate the array list with data table
            Populate(DB);
        }

        void Populate(clsDataConnection DB)

        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mPurchaseList = new List<clsShare>();
            while (Index < RecordCount)
            {
                //create blank order
                clsShare APurchase = new clsShare();
                //read the fields from the current record
                APurchase.ClientID = Convert.ToInt32(DB.DataTable.Rows[Index]["ClientID"]);
                APurchase.PurchaseNo = Convert.ToInt32(DB.DataTable.Rows[Index]["PurchaseNo"]);
                APurchase.Shares = Convert.ToInt32(DB.DataTable.Rows[0]["Shares"]);
                APurchase.OrderType= Convert.ToString(DB.DataTable.Rows[0]["OrderType"]);
                APurchase.Duration = Convert.ToDateTime(DB.DataTable.Rows[0]["Duration"]);
                APurchase.Symbol = Convert.ToString(DB.DataTable.Rows[0]["Symbol"]);
                APurchase.FundID = Convert.ToInt32(DB.DataTable.Rows[0]["FundID"]);

                //add the record to the private data member
                mPurchaseList.Add(APurchase);
                //point at the next record
                Index++;
            }
        }

    }// end of class
}// end of namespace
