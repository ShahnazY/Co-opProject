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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblClaim_SelectAll");
            PopulateArray(DB);
        }

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
                AClaim.ClaimID = Convert.ToInt32(DB.DataTable.Rows[Index]["ClaimID"]);
                AClaim.Location = Convert.ToString(DB.DataTable.Rows[Index]["Location"]);
                AClaim.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                AClaim.DateOfClaim = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfClaim"]);
                AClaim.DateOfInjury = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfInjury"]);
                AClaim.EvidenceProvided = Convert.ToBoolean(DB.DataTable.Rows[Index]["EvidenceProvided"]);
                mClaimList.Add(AClaim);
                Index++;
            }
        }

        public void ReportByLocation(string Location)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Location", Location);
            DB.Execute("sproc_tblClaim_FilterByLocation");
            PopulateArray(DB);
        }
    }
}