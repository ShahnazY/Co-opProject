using System;

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
            mCustomerLoginID = 2;
            mCustomerID = 5;
            mEmail = "Mark.12@gmail.com";
            mPassword = "password";
            return true;
        }
    }
}