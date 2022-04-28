using System;
using ClassLibrary;
using Co_opClasses;

namespace Co_opClasses
{
    public class clsDog
    {
        //private data members for all properties
        private Int32 mDogID;
        private Int32 mAge;
        private string mBreed;
        private string mGender;
        private string mName;
        private string mSize;
        private DateTime mDateAdded;
        //public propert for the dog ID
        public int DogID
        {
            get
            {
                //return the private data
                return mDogID;
            }

            set
            {
                //set the value of the private data member
                mDogID = value;
            }
        }

        //public property for the age
        public int Age
        {
            get
            {
                //return the private data
                return mAge;
            }
            set
            {
                //set the value of the private data member
                mAge = value;
            }
        }

        //public property for breed
        public string Breed
        {
            get
            {
                //return the private data
                return mBreed;
            }

            set
            {
                //set the private data
                mBreed = value;
            }
        }

        //public data meber for gender
        public string Gender
        {
            get
            {
                //return the private dat
                return mGender;
            }

            set
            {
                //set the private dat
                mGender = value;
            }
        }

        //public data member for name
        public string Name
        {
            get
            {
                //return the private data
                return mName;
            }

            set
            {
                //set the private data
                mName = value;
            }
        }

        //public data member for size
        public string Size
        {
            get
            {
                //return the private data
                return mSize;
            }
            set
            {
                //set the private data
                mSize = value;
            }
        }

        //public property for data added
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }

            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        public bool Find(int DogID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the dog id to search for
            DB.AddParameter("@DogID", DogID);
            //execute the stored procedure
            DB.Execute("sproc_tblDog_FilterByDogID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mDogID = Convert.ToInt32(DB.DataTable.Rows[0]["DogID"]);
                mAge = Convert.ToInt32(DB.DataTable.Rows[0]["Age"]);
                mBreed = Convert.ToString(DB.DataTable.Rows[0]["Breed"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mSize = Convert.ToString(DB.DataTable.Rows[0]["Size"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //return that everything worked fine
                return true;
            }
            //if no record found
            else
            {
                //return false indicatiing a problem
                return false;
            }

        }

    }
}