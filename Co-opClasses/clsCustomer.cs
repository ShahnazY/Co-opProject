using System;
using ClassLibrary;

namespace Co_opClasses
{
    public class clsCustomer
    {
        //private data members for all the properties
        private Int32 mCustomerID;
        private string mFirstName;
        private string mLastName;
        private string mContactNo;
        private string mGender;
        private string mHouseNo;
        private string mStreet;
        private string mTown;
        private string mPostCode;
        private DateTime mDateOfBirth;
        private string mEmail;
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public string ContactNo
        {
            get
            {
                return mContactNo;
            }
            set
            {
                mContactNo = value;
            }
        }
        public string Gender
        {
            get
            {
                return mGender;
            }
            set
            {
                mGender = value;
            }
        }
        public string HouseNo
        {
            get
            {
                return mHouseNo;
            }
            set
            {
                mHouseNo = value;
            }
        }
        public string Street
        {
            get
            {
                return mStreet;
            }
            set
            {
                mStreet = value;
            }
        }
        public string Town
        {
            get
            {
                return mTown;
            }
            set
            {
                mTown = value;
            }
        }
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customerID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if a record is found
            if (DB.Count == 1)
            {
                //copy the data from database to the private data mmembers
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                //return everything worked
                return true;
            }
            else
            {
                //return a problem
                return false;

            }
        }

            public string Valid(string firstName, string lastName, string dateOfBirth, string gender, string email, string houseNo, string street, string town, string postCode)
        {
            //string variable to store the error message
            string Error = "";
            //create a temp variable to store date values
            DateTime DateTemp;
            //if the name of the personal injury is more than 50 characters
            if (firstName.Length > 50)
            {
                //return a blank string
                Error = "The first name cannot have more than 50 characters";
            }
            if (firstName.Length == 0)
            {
                //return an error message
                Error = "The first name must not be blank";
            }
            if (lastName.Length > 50)
            {
                //return a blank string
                Error = "The last name cannot have more than 50 characters";
            }
            if (lastName.Length == 0)
            {
                //return an error message
                Error = "The last name must not be blank";
            }
            if (gender.Length == 0)
            {
                Error = Error + "The gender cannot be blank : ";
            }
            if (gender.Length > 7)
            {
                Error = Error + "The gender cannot be more than 7 characters : ";
            }
            if (street.Length > 50)
            {
                //return a blank string
                Error = "The street cannot have more than 50 characters";
            }
            if (street.Length == 0)
            {
                //return an error message
                Error = "The street must not be blank";
            }
            if (town.Length > 50)
            {
                //return a blank string
                Error = "The town cannot have more than 50 characters";
            }
            if (town.Length == 0)
            {
                //return an error message
                Error = "The town must not be blank";
            }

            try
            {
                //cope the dateOfClaim value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp > DateTime.Now.Date.AddYears(-18)) 
                {
                    //record the error
                    Error = Error + "You must be older than 18 : ";
                }
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error
                    Error = Error + "You are too old : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date entered is not in the valid format : ";
            }
            return Error;
        }

        
    }
}