using System;
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
    }
}