using System.Collections.Generic;
using System;
using ClassLibrary;

namespace Co_opClasses
{
    public class clsStaffCollection
    {
        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //While there are records to process 
            while (Index < RecordCount)
            {
                //create a blank trainers 
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record 
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                AStaff.Gender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                AStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                AStaff.Department = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //add the record to the private data member
                mStaffsList.Add(AStaff);
                //point to the next record 
                Index++;
            }
        }

        List<clsStaff> mStaffsList = new List<clsStaff>();
        public List<clsStaff> StaffsList
        {
            get
            {
                return mStaffsList;
            }
            set
            {
                mStaffsList = value;
            }
        }
        public clsStaff ThisStaff { get; set; }
        public int Count
        {
            get
            {
                return mStaffsList.Count;
            }
            set
            {

            }
        }
    }
}