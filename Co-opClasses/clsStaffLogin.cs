﻿using System;
using ClassLibrary;
using System.Text.RegularExpressions;
using Co_opClasses;

namespace Co_opClasses
{
    public class clsStaffLogin
    {
        //private data members for all the properties
        private Int32 mStaffLoginID;
        private Int32 mStaffID;
        private string mEmail;
        private string mPassword;
    
    
        public int StaffLoginID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffLoginID;
            }
            set
            {
                //this line of code allows data into property
                mStaffLoginID = value;
            }
        }
   
        public int StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into property
                mStaffID = value;
            }
        }
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into property
                mEmail = value;
            }
        }
        public string Password
        {
            get
            {
                //this line of code sends data out of the propert
                return mPassword;
            }
            set
            {
                //this line of code allows data into property
                mPassword = value;
            }
        }

        public bool Find(int StaffLoginID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff to search for
            DB.AddParameter("@StaffLoginID", StaffLoginID);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaffLogin_FilterByStaffLoginID");
            //if one record is found ( there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to private data member
                mStaffLoginID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffLoginID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                //return that everything worked 
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem 
                return false;
            }
        }
            public string Valid(string staffID, string email, string password)
            {
                String Error = "";
                //Temp variable to store the staff ID
                Int32 IDTemp;
                //string pattern to validate email 
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                try
                {
                    IDTemp = Convert.ToInt32(staffID);
                    if (IDTemp == 0)
                    {
                        Error = Error + "You must enter Staff ID : ";
                    }

                }
                catch
                {
                    Error = Error + "Staff ID must be a number : ";
                }
                if (email.Length == 0)
                {
                    Error = Error + "You must enter an email : ";
                }
                else if (Regex.IsMatch(email, pattern) == false)
                {
                    Error = Error + "Email is in the wrong format : ";
                }
                if (password.Length < 5)
                {
                    Error = Error + "The Password cannot be less than 5 characters : ";
                }
                if (password.Length > 20)
                {
                    Error = Error + "The Password may not be more than 20 characters : ";
                }

                return Error;          
        }
    }
}