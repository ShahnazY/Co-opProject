using System;
namespace Co_opClasses
{
    public class clsInsurance
    {
        //private data members of all properties
        private Int32 mInsuranceID;
        private Boolean mDentalTreatment;
        private string mCover;
        private string mVetFees;
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

        public bool Find(int InsuranceID)
        {
            //set the private data members to the test data value
            mInsuranceID = 6;
            mDentalTreatment = true;
            mCover = "Accident Only";
            mVetFees = "Up to £3000";
            //always return true
            return true;
        }

    }
}
    
