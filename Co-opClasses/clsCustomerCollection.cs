using System.Collections.Generic;
using System;
using ClassLibrary;

namespace Co_opClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisClaim
        clsCustomer mThisCustomer = new clsCustomer();
        //constructor for the class
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //While there are records to process 
            while (Index < RecordCount)
            {
                //create a blank trainers 
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record 
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                ACustomer.HouseNo= Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                ACustomer.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                ACustomer.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                //add the record to the private data member
                mCustomersList.Add(ACustomer);
                //point to the next record 
                Index++;
            }
        }

        List<clsCustomer> mCustomersList = new List<clsCustomer>();
        public List<clsCustomer> CustomersList
        {
            get
            {
                return mCustomersList;
            }
            set
            {
                mCustomersList = value;
            }
        }
        public clsCustomer ThisCustomer {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomersList.Count;
            }
            set
            {

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Gender", mThisCustomer.Gender);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@Street", mThisCustomer.Street);
            DB.AddParameter("@Town", mThisCustomer.Town);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Gender", mThisCustomer.Gender);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@Street", mThisCustomer.Street);
            DB.AddParameter("@Town", mThisCustomer.Town);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}