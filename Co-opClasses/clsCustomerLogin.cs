using System;
using System.Text.RegularExpressions;
using ClassLibrary;

namespace Co_opClasses
{
    public class clsCustomerLogin
    {
        private Int32 mCustomerLoginID;
        private Int32 mCustomerID;
        private string mEmail;
        private string mPassword;
        public int CustomerLoginID
        {
            get
            {
                return mCustomerLoginID;
            }
            set
            {
                mCustomerLoginID = value;
            }
        }
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
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
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        public bool Find(int CustomerLoginID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CustomerLoginID", CustomerLoginID);
            DB.Execute("sproc_tblCustomerLogin_FilterByCustomerLoginID");
            
            if (DB.Count == 1)
            {
                mCustomerLoginID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerLoginID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]); ;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string customerID, string email, string password)
        {
            String Error = "";
            //Temp variable to store the customer ID
            Int32 IDTemp;
            //string pattern to validate email 
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            try
            {
                IDTemp = Convert.ToInt32(customerID);
                if (IDTemp == 0)
                {
                    Error = Error + "The CustomerID cannot be blank : ";
                }
                
            }
            catch
            {
                Error = Error + "The data entered in the customerID is not a number : ";
            }
            if (email.Length == 0)
            {
                Error = Error + "The Email may not be blank : ";
            }
            else if (Regex.IsMatch(email, pattern) == false)
            {
                Error = Error + "Email is not valid. The correct format is 'example@example.uk' : ";
            }
            if (password.Length < 7)
            {
                Error = Error + "The Password cannot be less than 7 characters : ";
            }
            if (password.Length > 15)
            {
                Error = Error + "The Password may not be more than 15 characters : ";
            }
            
            return Error;
        }
    }
}