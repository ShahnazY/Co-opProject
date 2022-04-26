using System.Collections.Generic;
using System;
using ClassLibrary;

namespace Co_opClasses
{
    public class clsPersonalInjuryCollection
    {
        public clsPersonalInjuryCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblPersonalInjury_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //While there are records to process 
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

        List<clsPersonalInjury> mPersonalInjuriesList = new List<clsPersonalInjury>();
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

        public clsPersonalInjury ThisPersonalInjury { get; set; }
    }
}