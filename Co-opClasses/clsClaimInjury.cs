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
        }*/
    }
}