using System.Collections.Generic;
using System;
using ClassLibrary;
using Co_opClasses;

namespace Co_opClasses
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member this staff
        clsStaff mThisStaff = new clsStaff();

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }
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
                mStaffList.Add(AStaff);
                //point to the next record 
                Index++;
            }
        }

        public List<clsStaff> StaffsList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }
    
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Department", mThisStaff.Department);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Department", mThisStaff.Department);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByEmail(string Email)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Email", Email);
            DB.Execute("sproc_tblStaff_FilterByEmail");
            PopulateArray(DB);
        }
        public void ReportByDepartment(string Department)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Department", Department);
            DB.Execute("sproc_tblStaff_FilterByDepartment");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AStaff.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                mStaffList.Add(AStaff);
                Index++;
            }
        }
    }
}