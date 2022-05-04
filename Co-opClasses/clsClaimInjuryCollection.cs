using System.Collections.Generic;
using System;
using ClassLibrary;

namespace Co_opClasses
{
    public class clsClaimInjuryCollection
    {
        List<clsClaimInjury> mClaimInjuriesList = new List<clsClaimInjury>();
        clsClaimInjury mThisClaimInjury = new clsClaimInjury();
        public clsClaimInjuryCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblClaimInjury_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //While there are records to process 
            while (Index < RecordCount)
            {
                //create a blank trainers 
                clsClaimInjury AClaimInjury = new clsClaimInjury();
                //read in the fields from the current record 
                AClaimInjury.InjuryID = Convert.ToInt32(DB.DataTable.Rows[Index]["InjuryID"]);
                AClaimInjury.ClaimID = Convert.ToInt32(DB.DataTable.Rows[Index]["ClaimID"]);
                //add the record to the private data member
                mClaimInjuryList.Add(AClaimInjury);
                //point to the next record 
                Index++;
            }
        }
        //private member for the list 
        List<clsClaimInjury> mClaimInjuryList = new List<clsClaimInjury>();
        public List<clsClaimInjury> ClaimInjuryList
        {
            get
            {
                return mClaimInjuryList;
            }
            set
            {
                mClaimInjuryList = value;
            }
        }
        
        public int Count
        {
            get
            {
                return mClaimInjuryList.Count;
            }
            set
            {

            }
        }

        public clsClaimInjury ThisClaimInjury { get; set; }

        /*public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClaimID", mThisClaimInjury.ClaimID);
            DB.AddParameter("@InjuryID", mThisClaimInjury.InjuryID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblClaimInjury_Insert");
        }*/
    }
}