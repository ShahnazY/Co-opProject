using System;
using ClassLibrary;

namespace Co_opClasses
{
    public class clsClaimInjury
    {
        //private data members for all the properties
        private Int32 mClaimID;
        private Int32 mInjuryID;
        private Int32 mClaimInjuryID;
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
        public int InjuryID 
        {
            get
            {
                return mInjuryID;
            }
            set
            {
                mInjuryID = value;
            }
        }

        public int ClaimInjuryID
        {
            get
            {
                return mClaimInjuryID;
            }
            set
            {
                mClaimInjuryID = value;
            }
        }

        public bool Find(int ClaimInjuryID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClaimInjuryID", ClaimInjuryID);
            DB.Execute("sproc_tblClaimInjury_FilterByClaimInjuryID");
            if (DB.Count == 1)
            {
                mClaimInjuryID = Convert.ToInt32(DB.DataTable.Rows[0]["ClaimInjuryID"]);
                mClaimID = Convert.ToInt32(DB.DataTable.Rows[0]["ClaimID"]);
                mInjuryID = Convert.ToInt32(DB.DataTable.Rows[0]["InjuryID"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string claimID, string injuryID)
        {
            String Error = "";
            Int32 ClaimTemp;
            Int32 InjuryTemp;
            try
            {
              ClaimTemp = Convert.ToInt32(claimID);
                    if (ClaimTemp == 0)
                    {
                        //record the error
                        Error = Error + "The claim ID cannot be blank : ";
                    }
                    if (ClaimTemp > 1000)
                    {
                        //record the error
                        Error = Error + "The claim ID cannot be greater than 1000 : ";
                    }
            }
            catch
                {
                    //record the error
                    Error = Error + "The value entered is not a number : ";
                }

            try
            {
                InjuryTemp = Convert.ToInt32(injuryID);
                if (InjuryTemp == 0)
                {
                    //record the error
                    Error = Error + "The injury ID cannot be blank : ";
                }
                if (InjuryTemp > 1000)
                {
                    //record the error
                    Error = Error + "The injury ID cannot be greater than 1000 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The value entered is not a number : ";
            }

            return Error;
            
        }

        /*public string Valid(string someClaimInjury)
        {
            //if the name of the personal injury is not blank
            if (someClaimInjury != "")
            {
                //return a blank string
                return "";
            }
            else
            {
                //otherwise return an error message
                return "The Claim Injury must not be blank";
            }

        try
            {
                SizeTemp = Convert.ToInt32(size);
                if (SizeTemp == 0)
                {
                    //record the error
                    Error = Error + "The size cannot be blank : ";
                }
                if (SizeTemp > 12)
                {
                    //record the error
                    Error = Error + "The size cannot be greater than 12 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The value entered is not a number : ";
            } 
        }*/
    }
}