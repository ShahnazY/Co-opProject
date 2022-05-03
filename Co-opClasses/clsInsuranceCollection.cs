using System.Collections.Generic;
using System;
using ClassLibrary;
using Co_opClasses;


namespace Co_opClasses
{
    public class clsInsuranceCollection
    {
        //private data members for the list
        List<clsInsurance> mInsuranceList = new List<clsInsurance>();
        clsInsurance mThisInsurance = new clsInsurance();

        public List<clsInsurance> InsuranceList
        {
            get
            {
                //return the private data
                return mInsuranceList;
            }

            set
            {
                //set the private data
                mInsuranceList = value;
            }
        }

        public clsInsurance ThisInsurance
        {
            get
            {
                //return the private data
                return mThisInsurance;
            }
            set
            {
                //set the private data
                mThisInsurance = value;
            }
        }

        public int Count
        {
            get
            {
                //retun the private data
                return mInsuranceList.Count;
            }

            set
            {

            }
        }

        public clsInsuranceCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblInsurance_selectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank insurance
                clsInsurance AnInsurance = new clsInsurance();
                //read the fields from the current record
                AnInsurance.DogID = Convert.ToInt32(DB.DataTable.Rows[Index]["DogID"]);
                AnInsurance.DentalTreatment = Convert.ToBoolean(DB.DataTable.Rows[Index]["DentalTreatment"]);
                AnInsurance.Cover = Convert.ToString(DB.DataTable.Rows[Index]["Cover"]);
                AnInsurance.VetFees = Convert.ToString(DB.DataTable.Rows[Index]["VetFees"]);
                AnInsurance.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                mInsuranceList.Add(AnInsurance);
                //point at the next record
                Index++;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DogID", mThisInsurance.DogID);
            DB.AddParameter("@DentalTreatment", mThisInsurance.DentalTreatment);
            DB.AddParameter("@Cover", mThisInsurance.Cover);
            DB.AddParameter("@VetFees", mThisInsurance.VetFees);
            DB.AddParameter("@Price", mThisInsurance.Price);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblInsurance_Insert");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@InsuranceID", mThisInsurance.InsuranceID);
            DB.Execute("sproc_tblInsurance_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@InsuranceID", mThisInsurance.InsuranceID);
            DB.AddParameter("@DogID", mThisInsurance.DogID);
            DB.AddParameter("@DentalTreatment", mThisInsurance.DentalTreatment);
            DB.AddParameter("@Cover", mThisInsurance.Cover);
            DB.AddParameter("@VetFees", mThisInsurance.VetFees);
            DB.AddParameter("@Price", mThisInsurance.Price);
            //execute the stored procedure
            DB.Execute("sproc_tblInsurance_Update");
        }
       
       
        
    }
}