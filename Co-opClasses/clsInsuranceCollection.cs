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

        public clsInsurance ThisInsurance
        {
            get
            {
                return mThisInsurance;
            }
            set
            {
                mThisInsurance = value;
            }
        }

        //constructor for the class
        public clsInsuranceCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblInsurance_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //While there are records to process 
            while (Index < RecordCount)
            {
                //create a blank insurances 
                clsInsurance AnInsurance = new clsInsurance();
                //read in the fields from the current record 
                AnInsurance.InsuranceID = Convert.ToInt32(DB.DataTable.Rows[Index]["InsuranceID"]);
                AnInsurance.DentalTreatment = Convert.ToBoolean(DB.DataTable.Rows[Index]["DentalTreatment"]);
                AnInsurance.Cover = Convert.ToString(DB.DataTable.Rows[Index]["Cover"]);
                AnInsurance.VetFees = Convert.ToString(DB.DataTable.Rows[Index]["VetFees"]);
                AnInsurance.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);     
                //add the record to the private data member
                mInsuranceList.Add(AnInsurance);
                //point to the next record 
                Index++;
            }
        }
        public List<clsInsurance> InsurancesList
        {
            get
            {
                return mInsuranceList;
            }
            set
            {
                mInsuranceList = value;
            }
        }
        public int Count
        {
            get
            {
                return mInsuranceList.Count;
            }
            set
            {

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
            DB.AddParameter("@DogID", mThisInsurance.InsuranceID);
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
        public void ReportByDogID(int DogID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DogID", DogID);
            DB.Execute("sproc_tblInsurance_FilterByDogID");
            PopulateArray(DB);
        }
        public void ReportByDentalTreatment(string DentalTreatment)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DentalTreatment", DentalTreatment);
            DB.Execute("sproc_tblDog_FilterByDentalTreatment");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mInsuranceList = new List<clsInsurance>();
            while (Index < RecordCount)
            {
                clsInsurance AnInsurance = new clsInsurance();
                AnInsurance.InsuranceID = Convert.ToInt32(DB.DataTable.Rows[Index]["InsuranceID"]);
                AnInsurance.DentalTreatment = Convert.ToBoolean(DB.DataTable.Rows[Index]["DentalTreatment"]);
                AnInsurance.Cover = Convert.ToString(DB.DataTable.Rows[Index]["Cover"]);
                AnInsurance.VetFees = Convert.ToString(DB.DataTable.Rows[Index]["VetFees"]);
                AnInsurance.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                mInsuranceList.Add(AnInsurance);
                Index++;
            }
        }
    }
}