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
        private string mSymbol;


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

        public string Symbol
        {
            get
            {
                //tis line of code sends data out of the property
                return mSymbol;
            }
            set
            {
                //this line of code allows data into property
                mSymbol = value;
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

        public bool Find(int FundNo)
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
                mSymbol = Convert.ToString(DB.DataTable.Rows[0]["Symbol"]);

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


        //fuction for the public validation method
        public string Valid(string symbol, string fundName, string risk, string objective, string change, string stocks, string marketPrice)
        {
            //this function accepts 7 parameters for validation
            //it returns string containing error message
            //if no erorr is found, it return blank string

            //string variable to store error
            String Error = "";
            //storing temporaty variables
            Int32 ValueTemp;

            //if the symbol is blank
            if (symbol.Length == 0)
            {
                Error = Error + "The symbol may not be blank!  ";
            }

            //if the symbol is too long
            if (symbol.Length > 10)
            {
                Error = Error + "The symbol must be less than 10 characters!  ";
            }

            //if the symbol is blank
            if (change.Length == 0)
            {
                Error = Error + "The change may not be blank!  ";
            }

            //if the symbol is too long
            if (change.Length > 10)
            {
                Error = Error + "The change must be less than 10 characters!  ";
            }

            //if the fund name is blank
            if (fundName.Length == 0)
            {
                Error = Error + "The fund name may not be blank!  ";
            }

            //if the fund name is too long
            if (fundName.Length > 50)
            {
                Error = Error + "The fund name must be less than 50 characters!  ";
            }

            //if the objective is blank
            if (objective.Length == 0)
            {
                Error = Error + "The objective may not be blank!  ";
            }

            //if the objective is too long
            if (objective.Length > 500)
            {
                Error = Error + "The objective must be less than 500 characters!  ";
            }

            try
            {
                ValueTemp = Convert.ToInt32(risk);
                //if the risk value is 0
                if (ValueTemp == 0)
                {
                    Error = Error + "The risk value cannot be 0!  ";
                }

                //if the risk value is too big
                if (ValueTemp > 7)
                {
                    Error = Error + "The risk value is too big! Maximum risk value is 7. ";
                }
            }

            catch
            {
                Error = Error + "The risk value must be a number!  ";
            }

            try
            {
                ValueTemp = Convert.ToInt32(stocks);
                //if the stock value is 0
                if (ValueTemp == 0)
                {
                    Error = Error + "The stock value cannot be 0!  ";
                }

                //if the stock value is too big
                if (ValueTemp > 50000000)
                {
                    Error = Error + "The stock value is too big! Maximum risk value is 1000000. ";
                }
            }

            catch
            {
                Error = Error + "The stock value must be a number!  ";
            }

            //return any error message
            return Error;
        }

        public bool FindTheFundNo()
        {
            //create instance of data connection class
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to find last order nmber
            DB.Execute("sproc_tblFund_SelectFundNo");
            //if one record is found
            if (DB.Count == 1)
            {
                mFundNo = Convert.ToInt32(DB.DataTable.Rows[0]["FundNo"]);
                return true;
            }
            else

            {
                return false;
            }

        }

        public string AllDetails
        {
            get
            {
                return FundNo + ", " + FundName + ", " + Symbol + ", " + MarketPrice + ", " + Change;
            }
        }

        public string FullDescription
        {
            get {
                return Objective;
            }
        }
    }
}