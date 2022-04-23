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
            String Error = "";
            //create a temp variable to store date values for dateofClaim
            DateTime DateCTemp;
            //create a temp variable to store date values for dateofInjury
            DateTime DateITemp;
            //if the location is blank
            if (location.Length == 0)
            {
                //return an error message
                Error = Error + "The Location must not be blank";
            }
            if (location.Length > 50)
            {
                //record an error message
                Error = Error + "The Location must not exceed 50 characters :";
            }
            if (status.Length == 0)
            {
                //return an error message
                Error = Error + "The status must not be blank";
            }
            if (status.Length > 50)
            {
                Error = Error + "The status must not exceed 50 characters :";
            }
            try
            {
                //cope the dateOfClaim value to the DateTemp variable
                DateCTemp = Convert.ToDateTime(dateOfClaim);
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
                
            }
            catch
            {
                //record the error
                Error = Error + "The date is not a valid date : ";
            }
            /*try
            {
                DateITemp = Convert.ToDateTime(dateOfInjury);
                if (DateITemp < DateTime.Now.Date.AddDays(-365))
                {
                    //record the error
                    Error = Error + "The date of injury cannot be more than a year ago :";
                }
                if (DateITemp > DateTime.Now.Date)
                {
                    Error = Error + "The injury date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The data of injury is not in a valid format : ";
            }*/
            return Error;
        }

        


            
           
    }
}
