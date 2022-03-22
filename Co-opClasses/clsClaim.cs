using System;

namespace Co_opClasses
{
    public class clsClaim
    {
        //private data members for all the properties
        private Int32 mClaimID;
        private string mLocation;
        private string mStatus;
        private DateTime mDateOfClaim;
        private DateTime mDateOfInjury;
        private Boolean mEvidenceProvided;

        public int ClaimID
        {
            get
            {
                return mClaimID;
            }
            set
            {
                mClaimID = value;
            }
        }
        public string Location
        {
            get
            {
                return mLocation;
            }
            set
            {
                mLocation = value;
            }
        }

        public string Status
        {
            get
            {
                return mStatus;
            }
            set
            {
                mStatus = value;
            }
        }
        public DateTime DateOfClaim
        {
            get
            {
                return mDateOfClaim;
            }
            set
            {
                mDateOfClaim = value;
            }
        }
        public DateTime DateOfInjury
        {
            get
            {
                return mDateOfInjury;
            }
            set
            {
                mDateOfInjury = value;
            }
        }
        public bool EvidenceProvided
        {
            get
            {
                return mEvidenceProvided;
            }
            set
            {
                mEvidenceProvided = value;
            }
        }

        public string Valid(string status)
        {
            string Error = "";
            if (status.Length > 50)
            {
                //return a blank string
                Error = "The Status cannot have more than 50 characters";
            }
            if (status.Length == 0)
            {
                //return an error message
                Error = "The Status must not be blank";
            }

            return Error;
        }


        public string Valid(string location, string status, string dateOfClaim, string dateOfInjury)
        {
            //string variable to store the error message
            string Error = "";
            //create a temp variable to store date values
            DateTime DateTemp;
            //if the name of the personal injury is more than 50 characters
            if (location.Length > 50)
            {
                //return a blank string
                Error = "The Location cannot have more than 50 characters";
            }
            if (location.Length == 0)
            {
                //return an error message
                Error = "The Location must not be blank";
            }
            if (status.Length > 50)
            {
                //return a blank string
                Error = "The Status cannot have more than 50 characters";
            }
            if (status.Length == 0)
            {
                //return an error message
                Error = "The Status must not be blank";
            }

            try
            {
                //cope the dateOfClaim value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfClaim);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                DateTemp = Convert.ToDateTime(dateOfClaim);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date entered is not in the valid format : ";
            }

            try
            {
                //cope the dateOfInjury value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfInjury);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date entered is not in the valid format : ";
            }

            try
            {
                //cope the dateOfInjury value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfInjury);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
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
