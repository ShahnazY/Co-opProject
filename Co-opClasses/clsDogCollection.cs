using System.Collections.Generic;
using System;
using ClassLibrary;
using Co_opClasses;


namespace Co_opClasses
{
    public class clsDogCollection
    {
        //private data member for the list 
        List<clsDog> mDogList = new List<clsDog>();
        //private data member thisdog
        clsDog mThisDog = new clsDog();

        public clsDog ThisDog
        {
            get
            {
                return mThisDog;
            }
            set
            {
                mThisDog = value;
            }
        }

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
            public int Add()
            {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Age", mThisDog.Age);
            DB.AddParameter("@Breed", mThisDog.Breed);
            DB.AddParameter("@Gender", mThisDog.Gender);
            DB.AddParameter("@Name", mThisDog.Name);
            DB.AddParameter("@Size", mThisDog.Size);
            DB.AddParameter("@DateAdded", mThisDog.DateAdded);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblDog_Insert");
            }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DogID", mThisDog.DogID);
            DB.Execute("sproc_tblDog_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DogID", mThisDog.DogID);
            DB.AddParameter("@Age", mThisDog.Age);
            DB.AddParameter("@Breed", mThisDog.Breed);
            DB.AddParameter("@Gender", mThisDog.Gender);
            DB.AddParameter("@Name", mThisDog.Name);
            DB.AddParameter("@Size", mThisDog.Size);
            DB.AddParameter("@DateAdded", mThisDog.DateAdded);
            //execute the stored procedure
            DB.Execute("sproc_tblDog_Update");
        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            DB.Execute("sproc_tblDog_FilterByName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mDogList = new List<clsDog>();
            while (Index < RecordCount)
            {
                clsDog ADog = new clsDog();
                ADog.Age = Convert.ToInt32(DB.DataTable.Rows[Index]["Age"]);
                ADog.Breed = Convert.ToString(DB.DataTable.Rows[Index]["Breed"]);
                ADog.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                ADog.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ADog.Size = Convert.ToString(DB.DataTable.Rows[Index]["Size"]);
                ADog.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                mDogList.Add(ADog);
                Index++;
            }
        }

    }
}