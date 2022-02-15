using ClassLibrary;
using System;

namespace Co_opClasses
{
    public class clsClient
    {
        //private data memeber for the order property
        private Int32 mAccountNumber;
        private Int32 mClientID;
        private string mAccountType;
        private string mAnnualIncome;
        private string mBankName;
        private string mEmail;
        private string mEmploymentStatus;
        private string mFirstName;
        private Int32 mHouseNumber;
        private string mLastName;
        private string mPassword;
        private string mPhoneNumber;
        private string mPostCode;
        private Int32 mSortCode;
        private string mStreet;
        private Int32 mStreetNumber;
        private string mTown;

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

        public int AccountNumber
        {
            get
            {
                //tis line of code sends data out of the property
                return mAccountNumber;
            }
            set
            {
                //this line of code allows data into property
                mAccountNumber = value;
            }
        }

        public string AccountType
        {
            get
            {
                //tis line of code sends data out of the property
                return mAccountType;
            }
            set
            {
                //this line of code allows data into property
                mAccountType = value;
            }
        }


        public string AnnualIncome
        {
            get
            {
                //tis line of code sends data out of the property
                return mAnnualIncome;
            }
            set
            {
                //this line of code allows data into property
                mAnnualIncome = value;
            }
        }


        public string BankName
        {
            get
            {
                //tis line of code sends data out of the property
                return mBankName;
            }
            set
            {
                //this line of code allows data into property
                mBankName = value;
            }
        }


        public string Email
        {
            get
            {
                //tis line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into property
                mEmail = value;
            }
        }


        public string EmploymentStatus
        {
            get
            {
                //tis line of code sends data out of the property
                return mEmploymentStatus;
            }
            set
            {
                //this line of code allows data into property
                mEmploymentStatus = value;
            }
        }


        public string FirstName
        {
            get
            {
                //tis line of code sends data out of the property
                return mFirstName;
            }
            set
            {
                //this line of code allows data into property
                mFirstName = value;
            }
        }


        public string LastName
        {
            get
            {
                //tis line of code sends data out of the property
                return mLastName;
            }
            set
            {
                //this line of code allows data into property
                mLastName = value;
            }
        }


        public Int32 HouseNumber
        {
            get
            {
                //tis line of code sends data out of the property
                return mHouseNumber;
            }
            set
            {
                //this line of code allows data into property
                mHouseNumber = value;
            }
        }


        public string Password
        {
            get
            {
                //tis line of code sends data out of the property
                return mPassword;
            }
            set
            {
                //this line of code allows data into property
                mPassword = value;
            }
        }


        public string PhoneNumber
        {
            get
            {
                //tis line of code sends data out of the property
                return mPhoneNumber;
            }
            set
            {
                //this line of code allows data into property
                mPhoneNumber = value;
            }
        }


        public string PostCode
        {
            get
            {
                //tis line of code sends data out of the property
                return mPostCode;
            }
            set
            {
                //this line of code allows data into property
                mPostCode = value;
            }
        }


        public string Street
        {
            get
            {
                //tis line of code sends data out of the property
                return mStreet;
            }
            set
            {
                //this line of code allows data into property
                mStreet = value;
            }
        }

        public Int32 StreetNumber
        {
            get
            {
                //tis line of code sends data out of the property
                return mStreetNumber;
            }
            set
            {
                //this line of code allows data into property
                mStreetNumber = value;
            }
        }


        public string Town
        {
            get
            {
                //tis line of code sends data out of the property
                return mTown;
            }
            set
            {
                //this line of code allows data into property
                mTown = value;
            }
        }


        public Int32 SortCode
        {
            get
            {
                //tis line of code sends data out of the property
                return mSortCode;
            }
            set
            {
                //this line of code allows data into property
                mSortCode = value;
            }
        }

        //find function
        public bool Find(int ClientID)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter to search for
            DB.AddParameter("@ClientID", ClientID);
            //execute the stored procedure
            DB.Execute("sproc_tblClient_FilterByClientID");
            //if one record is found 
            if (DB.Count == 1)
            //copy the data from database to the private data members
            {

                mClientID = Convert.ToInt32(DB.DataTable.Rows[0]["ClientID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mStreetNumber = Convert.ToInt32(DB.DataTable.Rows[0]["StreetNumber"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mHouseNumber = Convert.ToInt32(DB.DataTable.Rows[0]["HouseNumber"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mAccountType = Convert.ToString(DB.DataTable.Rows[0]["AccountType"]);
                mAnnualIncome = Convert.ToString(DB.DataTable.Rows[0]["AnnualIncome"]);
                mEmploymentStatus = Convert.ToString(DB.DataTable.Rows[0]["EmploymentStatus"]);
                mBankName = Convert.ToString(DB.DataTable.Rows[0]["BankName"]);
                mSortCode = Convert.ToInt32(DB.DataTable.Rows[0]["SortCode"]);
                mAccountNumber = Convert.ToInt32(DB.DataTable.Rows[0]["AccountNumber"]);


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