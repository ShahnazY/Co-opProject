using System.Collections.Generic;
using System;
using ClassLibrary;

namespace Co_opClasses
{
    public class clsCustomerLoginCollection
    {
        //private data member for the list 
        List<clsCustomerLogin> mCustomerLoginsList = new List<clsCustomerLogin>();
        //private data member thisClaim
        clsCustomerLogin mThisCustomerLogin = new clsCustomerLogin();

        public clsCustomerLoginCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomerLogin_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //While there are records to process 
            while (Index < RecordCount)
            {
                //create a blank trainers 
                clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
                //read in the fields from the current record 
                ACustomerLogin.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomerLogin.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomerLogin.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                //add the record to the private data member
                mCustomerLoginsList.Add(ACustomerLogin);
                //point to the next record 
                Index++;
            }
        }

        public List<clsCustomerLogin> CustomerLoginList
        {
            get
            {
                return mCustomerLoginsList;
            }
            set
            {
                mCustomerLoginsList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerLoginsList.Count;
            }
            set
            {

            }
        }
        public clsCustomerLogin ThisCustomerLogin
        {
            get
            {
                return mThisCustomerLogin;
            }
            set
            {
                mThisCustomerLogin = value;
            }
        }
    }
}