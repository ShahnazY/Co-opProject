using System.Collections.Generic;
using System;
using ClassLibrary;


namespace Co_opClasses
{
    public class clsInsuranceCollection
    {
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


        List<clsInsurance> mInsuranceList = new List<clsInsurance>();
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
        public clsInsurance ThisInsurance { get; set; }
    }
}