using System;
using System.Text.RegularExpressions;
using ClassLibrary;

namespace Co_opClasses
{
    public class clsStaff
    {
        //private data members for all the properties
        private Int32 mStaffID;
        private string mFirstName;
        private string mLastName;
        private string mGender;
        private DateTime mDateOfBirth;
        private string mEmail;
        private string mDepartment;
        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        public string Gender
        {
            get
            {
                return mGender;
            }
            set
            {
                mGender = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staffID to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if a record is found
            if (DB.Count == 1)
            {
                //copy the data from database to the private data mmembers
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return everything worked
                return true;
            }
            else
            {
                //return a problem
                return false;

            }
        }
    }
}