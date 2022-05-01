using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_opClasses
{
    public class clsShare
    {
        private Int32 mPurchaseNo;
        private string mSymbol;
        private string mOrderType;
        private Int32 mShares;
        private DateTime mDuration;
        private Int32 mFundID;

        private Int32 mClientID;

        public int ClientID
        {
            get
            {
                //tis line of code sends data out of the property
                return mClientID;
            }
            set
            {
                //this line of code allows data into property
                mClientID = value;
            }
        }
        public int FundID
        {
            get
            {
                //tis line of code sends data out of the property
                return mFundID;
            }
            set
            {
                //this line of code allows data into property
                mFundID = value;
            }
        }
        public int PurchaseNo
        {
            get
            {
                //tis line of code sends data out of the property
                return mPurchaseNo;
            }
            set
            {
                //this line of code allows data into property
                mPurchaseNo = value;
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

        public string OrderType
        {
            get
            {
                //tis line of code sends data out of the property
                return mOrderType;
            }
            set
            {
                //this line of code allows data into property
                mOrderType = value;
            }
        }

        public int Shares
        {
            get
            {
                //tis line of code sends data out of the property
                return mShares;
            }
            set
            {
                //this line of code allows data into property
                mShares = value;
            }
        }
        public DateTime Duration
        {
            get
            {
                //tis line of code sends data out of the property
                return mDuration;
            }
            set
            {
                //this line of code allows data into property
                mDuration = value;
            }
        }

        //find function
        public bool Find(int PurchaseNo)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter to search for
            DB.AddParameter("@PurchaseNo", PurchaseNo);
            //execute the stored procedure
            DB.Execute("sproc_tblPurchases_FilterByPurchaseNo");
            //if one record is found 
            if (DB.Count == 1)
            //copy the data from database to the private data members
            {
                mPurchaseNo = Convert.ToInt32(DB.DataTable.Rows[0]["PurchaseNo"]);
                mClientID = Convert.ToInt32(DB.DataTable.Rows[0]["ClientID"]);
                mShares = Convert.ToInt32(DB.DataTable.Rows[0]["Shares"]);
                mOrderType = Convert.ToString(DB.DataTable.Rows[0]["OrderType"]);
                mDuration = Convert.ToDateTime(DB.DataTable.Rows[0]["Duration"]);
                mSymbol = Convert.ToString(DB.DataTable.Rows[0]["Symbol"]);
                mFundID = Convert.ToInt32(DB.DataTable.Rows[0]["FundID"]);


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
        public string Valid(string clientID, string shares, string orderType, string duration, string symbol, string fundID)
        {
            //this function accepts 5 parameters for validation
            //it returns string containing error message
            //if no erorr is found, it return blank string

            //string variable to store error
            String Error = "";
            //temporary variable to store data values
            DateTime DateTemp;
            Int32 ValueTemp;


            try
            {

                ValueTemp = Convert.ToInt32(clientID);
                //if the value is 0
                if (ValueTemp == 0)
                {
                    Error = Error + "Client ID value cannot be 0!  ";
                }


            }

            catch
            {
                Error = Error + "Client ID value must be a number!  ";
            }

            try
            {

                ValueTemp = Convert.ToInt32(fundID);
                //if the value is 0
                if (ValueTemp == 0)
                {
                    Error = Error + "Fund ID value cannot be 0!  ";
                }


            }

            catch
            {
                Error = Error + "Fund ID value must be a number!  ";
            }


            try
            {
                //copy the duration value to the temporary variable
                DateTemp = Convert.ToDateTime(duration);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past.  ";
                }
            }
            catch 
            {
                Error = Error + "The date is not valid";
            }

           


            //if the order type is blank
            if (orderType.Length == 0)
            {
                Error = Error + "The order type may not be blank!  ";
            }

            //if the order type is too long
            if (orderType.Length > 50)
            {
                Error = Error + "The order type must be less than 50 characters!  ";
            }


            //if the symbol is blank
            if (symbol.Length == 0)
            {
                Error = Error + "The symbol may not be blank!  ";
            }

            //if the symbol is too long
            if (symbol.Length > 50)
            {
                Error = Error + "The symbol must be less than 50 characters!  ";
            }



            try
            {
                ValueTemp = Convert.ToInt32(shares);
                //if the value is 0
                if (ValueTemp == 0)
                {
                    Error = Error + "The shares value cannot be 0!  ";
                }

                //if the value is too big
                if (ValueTemp > 50000)
                {
                    Error = Error + "The shares is too big! If you wish to order more, please make another order.  ";
                }
            }

            catch
            {
                Error = Error + "The shares value must be a number!  ";
            }

            //return any error message
            return Error;

        }//end of function for validation

        public bool FindThePurchaseNo()
        {
            //create instance of data connection class
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to find last order nmber
            DB.Execute("sproc_tblPurchases_SelectPurchaseNo");
            //if one record is found
            if (DB.Count == 1)
            {
                mPurchaseNo = Convert.ToInt32(DB.DataTable.Rows[0]["PurchaseNo"]);
                return true;
            }
            else

            {
                return false;
            }

        }

        public string AllPurchases
        {
            get
            {
                return PurchaseNo + ", " + Symbol + ", " + Duration + ", " + Shares ;
            }
        }
    }
}
    
