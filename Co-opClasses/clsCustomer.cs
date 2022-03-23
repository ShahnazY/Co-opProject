using System;

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
        private Int32 mHouseNo;
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
        public int HouseNo
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

        public string Valid(string firstName, string lastName, string dateOfBirth, string email, string houseNo, string street, string town, string postCode)
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