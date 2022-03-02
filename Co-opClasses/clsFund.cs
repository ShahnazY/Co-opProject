using ClassLibrary;
using System;

namespace Co_opClasses
{
    public class clsFund
    {
        private Int32 mFundNo;
        private string mChange;
        private string mFundName;
        private Int32 mRisk;
        private string mMarketPrice;
        private Int32 mStocks;
        private string mObjective;


        public int FundNo
        {
            get
            {
                //tis line of code sends data out of the property
                return mFundNo;
            }
            set
            {
                //this line of code allows data into property
                mFundNo = value;
            }
        }

        public string FundName
        {
            get
            {
                //tis line of code sends data out of the property
                return mFundName;
            }
            set
            {
                //this line of code allows data into property
                mFundName = value;
            }
        }

        public string Change
        {
            get
            {
                //tis line of code sends data out of the property
                return mChange;
            }
            set
            {
                //this line of code allows data into property
                mChange = value;
            }
        }

        public int Risk
        {
            get
            {
                //tis line of code sends data out of the property
                return mRisk;
            }
            set
            {
                //this line of code allows data into property
                mRisk = value;
            }
        }

        public string MarketPrice
        {
            get
            {
                //tis line of code sends data out of the property
                return mMarketPrice;
            }
            set
            {
                //this line of code allows data into property
                mMarketPrice = value;
            }
        }

        public int Stocks
        {
            get
            {
                //tis line of code sends data out of the property
                return mStocks;
            }
            set
            {
                //this line of code allows data into property
                mStocks = value;
            }
        }

        public string Objective
        {
            get
            {
                //tis line of code sends data out of the property
                return mObjective;
            }
            set
            {
                //this line of code allows data into property
                mObjective = value;
            }
        }

        //private Int32 mFundNo;
        //private string mChange;
        //private string mFundName;
        //private Int32 mRisk;
        //private string mMarketPrice;
        //private Int32 mStocks;
        //private string mObjective;

        public bool Find(int fundNo)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter to search for
            DB.AddParameter("@FundNo", FundNo);
            //execute the stored procedure
            DB.Execute("sproc_tblFund_FilterByFundNo");
            //if one record is found 
            if (DB.Count == 1)
            //copy the data from database to the private data members
            {

                mFundNo = Convert.ToInt32(DB.DataTable.Rows[0]["FundNo"]);
                mChange = Convert.ToString(DB.DataTable.Rows[0]["Change"]);
                mFundName = Convert.ToString(DB.DataTable.Rows[0]["FundName"]);
                mRisk = Convert.ToInt32(DB.DataTable.Rows[0]["Risk"]);
                mMarketPrice = Convert.ToString(DB.DataTable.Rows[0]["MarketPrice"]);
                mStocks = Convert.ToInt32(DB.DataTable.Rows[0]["Stocks"]);
                mObjective = Convert.ToString(DB.DataTable.Rows[0]["Objective"]);

                //return that everything worked
                return true;
            }
            //if no record was found
            else
            {
                //return false if there's a problem
                return false;

            }
        }//end of find function
    }
}