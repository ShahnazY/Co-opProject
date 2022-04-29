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

        public string Valid(string firstName, string lastName, string gender, string dateOfBirth, string email, string department)
        {
            //string variable to store the error message
            string Error = "";
            //string pattern to validate email 
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            //create a temp variable to store date values
            DateTime DateTemp;
            //if the name of staff is more than 50 characters
            if (firstName.Length > 50)
            {
                //return a blank string
                Error = Error + "The first name cannot have more than 50 characters long :";
            }
            if (firstName.Length == 0)
            {
                //return an error message
                Error = Error + "The first name cannot be blank : ";
            }
            if (lastName.Length > 50)
            {
                //return a blank string
                Error = Error + "The last name cannot have more than 50 characters : ";
            }
            if (lastName.Length == 0)
            {
                //return an error message
                Error = Error + "The last name cannot be blank : ";
            }
            if (gender.Length == 0)
            {
                Error = Error + "Gender cannot be blank : ";
            }
            if (gender.Length > 6)
            {
                Error = Error + "Gender should not have more than 6 characters : ";
            }
            if (email.Length == 0)
            {
                Error = Error + "The Email cannot be blank : ";
            }
            else if (Regex.IsMatch(email, pattern) == false)
            {
                Error = Error + "Email is not in the correct format : ";
            }
            if (department.Length == 0)
            {
                Error = Error + "The department may not be  blank : ";
            }
            if (department.Length > 50)
            {
                Error = Error + "The department must not exceed 50 characters : ";
            }
            try
            {
                //cope the dateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp > DateTime.Now.Date.AddYears(-18))
                {
                    //record the error
                    Error = Error + "You must be at least 18 years old : ";
                }
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error
                    Error = Error + "The age is too old : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The entered date is not a valid format : ";
            }
            return Error;
        }
    }
}