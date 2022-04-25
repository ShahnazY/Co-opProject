using System;
using ClassLibrary;

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

        public bool Find(int ClaimID)
        {
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the claimID to search for
            DB.AddParameter("@ClaimID", ClaimID);
            //execute the stored procedure
            DB.Execute("sproc_tblClaim_FilterByClaimID");
            //if a record is found
            if (DB.Count == 1)
            {
                //copy the data from database to the private data mmembers
                mClaimID = Convert.ToInt32(DB.DataTable.Rows[0]["ClaimID"]);
                mLocation = Convert.ToString(DB.DataTable.Rows[0]["Location"]); ;
                mStatus = Convert.ToString(DB.DataTable.Rows[0]["Status"]);
                mDateOfClaim = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfClaim"]);
                mDateOfInjury = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfInjury"]);
                mEvidenceProvided = Convert.ToBoolean(DB.DataTable.Rows[0]["EvidenceProvided"]);
                //return everything worked
                return true;
            }
            else
            {
                //return a problem
                return false;
            }
        }


        public string Valid(string location, string status, string dateOfClaim, string dateOfInjury)
        {
            //string variable to store the error message
            string Error = "";
            //create a temp variable to store date values for date of Claim and date of Injury
            DateTime DateCTemp;
            DateTime DateITemp;
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
                DateCTemp = Convert.ToDateTime(dateOfClaim);
                DateITemp = Convert.ToDateTime(dateOfInjury);
                if (DateCTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date of claim cannot be in the past : ";
                }
                if (DateCTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date of claim cannot be in the future : ";
                }
                
                if (DateITemp > DateTime.Now.Date.AddDays(-1))
                {
                    //record the error
                    Error = Error + "The date of injury cannot be today or in the future : ";
                }
                if (DateITemp < DateTime.Now.Date.AddYears(-3))
                {
                    Error = Error + "The injury date cannot be more than 3 years ago :";
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
