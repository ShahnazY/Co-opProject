using ClassLibrary;
using System;
using System.Collections.Generic;

namespace Co_opClasses
{
    public class clsFundCollection
    {
        //private data members for the list
        List<clsFund> mFundList = new List<clsFund>();
        clsFund mThisFund = new clsFund();

        //these lines of code contain the constructor of the class
        /////////////////////////////////////////
  

        public clsFundCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblFund_SelectAll");
            //populate the array list with data table
            Populate(DB);
        }
       
        /// THE CONSTRUCTOR ENDS HERE
       

        public List<clsFund> FundList
        {
            get
            {
                //return the private data
                return mFundList;

            }

            set
            {
                //set the private data
                mFundList = value;

            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mFundList.Count;
            }

            set
            {
                //we will do this later
            }
        }



        public clsFund ThisFund
        {
            get
            {
                //return the private data
                return mThisFund;
            }
            set
            {
                //set the private data
                mThisFund = value;
            }

        }






        //function for adding new fund into the system
        public int Add()
        {
            //adds a new record to the database based on the value value of mThisFund
            //set the primary key value of the record (FundNo)
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@Change", mThisFund.Change);
            DB.AddParameter("@Symbol", mThisFund.Symbol);
            DB.AddParameter("@FundName", mThisFund.FundName);
            DB.AddParameter("@Risk", mThisFund.Risk);
            DB.AddParameter("@MarketPrice", mThisFund.MarketPrice);
            DB.AddParameter("@Stocks", mThisFund.Stocks);
            DB.AddParameter("@Objective", mThisFund.Objective);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblFund_Insert");
        }

        //function for updating a record
        public void Update()
        {
            //update an existing record based on the values of thisFund

            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FundNo", mThisFund.FundNo);
            DB.AddParameter("@Change", mThisFund.Change);
            DB.AddParameter("@Symbol", mThisFund.Symbol);
            DB.AddParameter("@FundName", mThisFund.FundName);
            DB.AddParameter("@Risk", mThisFund.Risk);
            DB.AddParameter("@MarketPrice", mThisFund.MarketPrice);
            DB.AddParameter("@Stocks", mThisFund.Stocks);
            DB.AddParameter("@Objective", mThisFund.Objective);
            //execute the stored procedure
            DB.Execute("sproc_tblFund_Update");
        }

        //function for deleting a record
        public void Delete()
        {
            //deletes record based on the value value of mThisFund
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FundNo", mThisFund.FundNo);
            //execute the stored procedure
            DB.Execute("sproc_tblFund_Delete");
        }

        public void ReportByFundNo(int FundNo)
        {
            //filters the records based on fund number
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the FundNo parameter to the database
            DB.AddParameter("@FundNo", FundNo);
            //execute the stored proc
            DB.Execute("sproc_tblFund_FilterByFundNo");
            //populate the array list with data table
            Populate(DB);
        }



        void Populate(clsDataConnection DB)

        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mFundList = new List<clsFund>();
            while (Index < RecordCount)
            {
                //create blank fund
                clsFund AFund = new clsFund();
                //read the fields from the current record
                AFund.FundNo = Convert.ToInt32(DB.DataTable.Rows[Index]["FundNo"]);
                AFund.Risk = Convert.ToInt32(DB.DataTable.Rows[Index]["Risk"]);
                AFund.Change = Convert.ToString(DB.DataTable.Rows[0]["Change"]);
                AFund.FundName = Convert.ToString(DB.DataTable.Rows[0]["FundName"]);
                AFund.MarketPrice = Convert.ToString(DB.DataTable.Rows[0]["MarketPrice"]);
                AFund.Stocks = Convert.ToInt32(DB.DataTable.Rows[0]["Stocks"]);
                AFund.Objective = Convert.ToString(DB.DataTable.Rows[0]["Objective"]);
                AFund.Symbol = Convert.ToString(DB.DataTable.Rows[0]["Symbol"]);
                //add the record to the private data member
                mFundList.Add(AFund);
                //point at the next record
                Index++;
            }
        }

    }//end of fund collection class
}//end of namespace
