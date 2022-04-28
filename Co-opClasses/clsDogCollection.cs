using System.Collections.Generic;
using System;
using ClassLibrary;
using Co_opClasses;


namespace Co_opClasses
{
    public class clsDogCollection
    {
        //constructor for the class
        public clsDogCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblDog_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //While there are records to process 
            while (Index < RecordCount)
            {
                //create a blank dogs 
                clsDog ADog = new clsDog();
                //read in the fields from the current record 
                ADog.DogID = Convert.ToInt32(DB.DataTable.Rows[Index]["DogID"]);
                ADog.Age = Convert.ToInt32(DB.DataTable.Rows[Index]["Age"]);
                ADog.Breed = Convert.ToString(DB.DataTable.Rows[Index]["Breed"]);
                ADog.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                ADog.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ADog.Size = Convert.ToString(DB.DataTable.Rows[Index]["Size"]);
                ADog.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mDogList.Add(ADog);
                //point to the next record 
                Index++;
            }
        }


        List<clsDog> mDogList = new List<clsDog>();
        public List<clsDog> DogsList
        {
            get
            {
                return mDogList;
            }
            set
            {
                mDogList = value;
            }
        }
        public int Count
        {
            get
            {
                return mDogList.Count;
            }
            set
            {

            }
        }
        public clsDog ThisDog { get; set; }
    }
}