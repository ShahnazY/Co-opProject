using System.Collections.Generic;
using System;
using ClassLibrary;


namespace Co_opClasses
{
    public class clsClaimCollection
    {
        //constructor for the class
        public clsClaimCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblClaim_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //While there are records to process 
            while (Index < RecordCount)
            {
                //create a blank trainers 
                clsClaim AClaim = new clsClaim();
                //read in the fields from the current record 
                AClaim.Location = Convert.ToString(DB.DataTable.Rows[Index]["Location"]);
                AClaim.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                AClaim.DateOfClaim = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfClaim"]);
                AClaim.DateOfInjury = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfInjury"]);
                AClaim.EvidenceProvided = Convert.ToBoolean(DB.DataTable.Rows[Index]["EvidenceProvided"]);
                //add the record to the private data member
                mClaimList.Add(AClaim);
                //point to the next record 
                Index++;
            }
        } 


        List<clsClaim> mClaimList = new List<clsClaim>();
        public List<clsClaim> ClaimsList
        {
            get
            {
                return mClaimList;
            }
            set
            {
                mClaimList = value;
            }
        }
        public int Count
        {
            get
            {
                return mClaimList.Count;
            }
            set
            {
                
            }
        }
        public clsClaim ThisClaim { get; set; }
    }
}