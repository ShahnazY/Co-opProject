using System.Collections.Generic;
using System;
using ClassLibrary;


namespace Co_opClasses
{
    public class clsClaimCollection
    {
        //private data member for the list 
        List<clsClaim> mClaimList = new List<clsClaim>();
        //private data member thisClaim
        clsClaim mThisClaim = new clsClaim();

        //public property for ThisClaim
        public clsClaim ThisClaim
        {
            get
            {
                return mThisClaim;
            }
            set
            {
                mThisClaim = value;
            }
        }
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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Location", mThisClaim.Location);
            DB.AddParameter("@Status", mThisClaim.Status);
            DB.AddParameter("@DateOfClaim", mThisClaim.DateOfClaim);
            DB.AddParameter("@DateOfInjury", mThisClaim.DateOfInjury);
            DB.AddParameter("@EvidenceProvided", mThisClaim.EvidenceProvided);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblClaim_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClaimID", mThisClaim.ClaimID);
            DB.Execute("sproc_tblClaim_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClaimID", mThisClaim.ClaimID);
            DB.AddParameter("@Location", mThisClaim.Location);
            DB.AddParameter("@Status", mThisClaim.Status);
            DB.AddParameter("@DateOfClaim", mThisClaim.DateOfClaim);
            DB.AddParameter("@DateOfInjury", mThisClaim.DateOfInjury);
            DB.AddParameter("@EvidenceProvided", mThisClaim.EvidenceProvided);
            //execute the stored procedure
            DB.Execute("sproc_tblClaim_Update");
        }

        public void ReportByStatus(string Status)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Status", Status);
            DB.Execute("sproc_tblClaim_FilterByStatus");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mClaimList = new List<clsClaim>();
            while (Index < RecordCount)
            {
                clsClaim AClaim = new clsClaim();
                AClaim.Location = Convert.ToString(DB.DataTable.Rows[Index]["Location"]);
                AClaim.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                AClaim.DateOfClaim = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfClaim"]);
                AClaim.DateOfInjury = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfInjury"]);
                AClaim.EvidenceProvided = Convert.ToBoolean(DB.DataTable.Rows[Index]["EvidenceProvided"]);
                mClaimList.Add(AClaim);
                Index++;
            }
        }
    }
}