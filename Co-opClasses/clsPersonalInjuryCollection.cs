using System.Collections.Generic;
using System;
using ClassLibrary;

namespace Co_opClasses
{
    public class clsPersonalInjuryCollection
    {
        List<clsPersonalInjury> mPersonalInjuriesList = new List<clsPersonalInjury>();
        clsPersonalInjury mThisPersonalInjury = new clsPersonalInjury();
        public clsPersonalInjuryCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblPersonalInjury_SelectAll");
            PopulateArray(DB);
        }

        
        public List<clsPersonalInjury> PersonalInjuriesList
        {
            get
            {
                return mPersonalInjuriesList;
            }
            set
            {
                mPersonalInjuriesList = value;
            }
        }
        public int Count
        {
            get
            {
                return mPersonalInjuriesList.Count;
            }
            set
            {

            }
        }

        public clsPersonalInjury ThisPersonalInjury
        {
            get
            {
                return mThisPersonalInjury;
            }
            set
            {
                mThisPersonalInjury = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TypeOfInjury", mThisPersonalInjury.TypeOfInjury);
            DB.AddParameter("@Severity", mThisPersonalInjury.Severity);
            DB.AddParameter("@Compensation", mThisPersonalInjury.Compensation);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblPersonalInjury_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PersonalInjuryID", mThisPersonalInjury.PersonalInjuryID);
            DB.Execute("sproc_tblPersonalInjury_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PersonalInjuryID", mThisPersonalInjury.PersonalInjuryID);
            DB.AddParameter("@TypeOfInjury", mThisPersonalInjury.TypeOfInjury);
            DB.AddParameter("@Severity", mThisPersonalInjury.Severity);
            DB.AddParameter("@Compensation", mThisPersonalInjury.Compensation);
            //execute the stored procedure
            DB.Execute("sproc_tblPersonalInjury_Update");
        }

        public void ReportByTypeOfInjury(string TypeOfInjury)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TypeOfInjury", TypeOfInjury);
            DB.Execute("sproc_tblPersonalInjury_FilterByTypeOfInjury");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mPersonalInjuriesList = new List<clsPersonalInjury>();
            while (Index < RecordCount)
            {
                //create a blank trainers 
                clsPersonalInjury APersonalInjury = new clsPersonalInjury();
                //read in the fields from the current record 
                APersonalInjury.TypeOfInjury = Convert.ToString(DB.DataTable.Rows[Index]["TypeOfInjury"]);
                APersonalInjury.Severity = Convert.ToString(DB.DataTable.Rows[Index]["Severity"]);
                APersonalInjury.Compensation = Convert.ToDecimal(DB.DataTable.Rows[Index]["Compensation"]);

                //add the record to the private data member
                mPersonalInjuriesList.Add(APersonalInjury);
                //point to the next record 
                Index++;
            }
        }
    }
}