using System;
using ClassLibrary;
using Co_opClasses;

namespace Co_opClasses
{
    public class clsInsurance
    {
        //private data members of all properties
        private Int32 mInsuranceID;
        private Int32 mDogID;
        private Boolean mDentalTreatment;
        private string mCover;
        private string mVetFees;
        private decimal mPrice;
        //public property for the dog ID
        public int InsuranceID
        {
            get
            {
                //return the private data
                return mInsuranceID;
            }

            set
            {
                //set the value of the private data member
                mInsuranceID = value;
            }
        }

        public Int32 DogID
        {
            get
            {
                //this line allows data out of the property
                return mDogID;
            }
            set
            {
                //this line allows data into property
                mDogID = value;
            }
        }

        //public property for the age
        public bool DentalTreatment
        {
            get
            {
                //return the private data
                return mDentalTreatment;
            }
            set
            {
                //set the value of the private data member
                mDentalTreatment = value;
            }
        }

        //public property for breed
        public string Cover
        {
            get
            {
                //return the private data
                return mCover;
            }

            set
            {
                //set the private data
                mCover = value;
            }
        }

        //public data meber for gender
        public string VetFees
        {
            get
            {
                //return the private dat
                return mVetFees;
            }

            set
            {
                //set the private dat
                mVetFees = value;
            }
        }

        public decimal Price
        {
            get
            {
                //send data out of the property
                return mPrice;
            }
            set
            {
                //send data into the property
                mPrice = value;
            }
        }

        public bool Find(int InsuranceID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the insurance id to search for
            DB.AddParameter("@InsuranceID", InsuranceID);
            //execute the stored procedure
            DB.Execute("sproc_tblInsurance_FilterByInsuranceID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mInsuranceID = Convert.ToInt32(DB.DataTable.Rows[0]["InsuranceID"]);
                mDogID = Convert.ToInt32(DB.DataTable.Rows[0]["DogID"]);
                mDentalTreatment = Convert.ToBoolean(DB.DataTable.Rows[0]["DentalTreatment"]);
                mCover = Convert.ToString(DB.DataTable.Rows[0]["Cover"]);
                mVetFees = Convert.ToString(DB.DataTable.Rows[0]["VetFees"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                //return that everything worked fine
                return true;
            }
            //if no record found
            else
            {
                //return false indicatiing a problem
                return false;
            }

        }

        public string Valid(string dogID, string price)
        {
            //string variable to store the error message
            string Error = "";
            Int32 ValueTemp;
            //temp variable to store the price value
            Decimal PriceTemp;
            try
            {
                ValueTemp = Convert.ToInt32(dogID);
                //if the value is 0
                if (ValueTemp == 0)
                {
                    Error = Error + "Dog ID cannot be 0 :  ";
                }
                //if the value is too big
                if (ValueTemp > 50000)
                {
                    Error = Error + "Dog ID is too big : ";
                }
            }
            catch
            {
                Error = Error + "Dog ID  must be a number!  ";
            }
            try
            {
                PriceTemp = Convert.ToDecimal(price);
                if (PriceTemp < 0.01M)
                {
                    //record an error
                    Error = Error + "The price amount cannot be less than £0.01 : ";
                }
                if (PriceTemp > 50000M)
                {
                    //record an error
                    Error = Error + "The price amount cannot be more than £50,000 : ";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The value cannot be blank or in the format entered : ";
            }
            return Error;
        }
    }
}
    
