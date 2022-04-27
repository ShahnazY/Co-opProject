using System;
using ClassLibrary;
namespace Co_opClasses
{
    public class clsInsurance
    {
        //private data members of all properties
        private Int32 mInsuranceID;
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

    }
}
    
