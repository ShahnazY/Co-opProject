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

        public string Valid(string injuryID, string claimID)
        {
            String Error = "";
            //temp variable to store claimID
            Int32 ValueCTemp;
            //temp variable to store injuryID
            Int32 ValueITemp;
            try
            {
                ValueCTemp = Convert.ToInt32(claimID);
                ValueITemp = Convert.ToInt32(injuryID);
                //if the value is 0 
                if (ValueCTemp == 0)
                {
                    Error = Error + "The claim ID cannot be 0 : ";
                }
                if (ValueITemp == 0)
                {
                    Error = Error + "The injury ID cannot be 0 : ";
                }
            }
            catch
            {
                Error = Error + "The ID must be a number : ";
            }

            //return an error message
            return Error;
        }

        
    }
}