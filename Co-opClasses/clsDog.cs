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

        public string Valid(string age, string breed, string gender, string name, string size, string dateAdded)
        {
            //string variable to store the error message
            string Error = "";
            //temporary variable to store age values
            Int32 AgeTemp;
            //create a temp variable to store date values for date of dog added 
            DateTime DateATemp;
            //if the breed is blank
            if (breed.Length == 0)
            {
                //record the error
                Error = Error + "The Breed field cannot be blank : ";
            }
            //if breed is greater than 50 characters
            if (breed.Length > 50)
            {
                //record the error
                Error = Error + "Dog breed must not be more than 50 characters : ";
            }
            //if the name is gender is blank
            if (gender.Length == 0)
            {
                //record the error
                Error = Error + "The gender of the dog cannot be blank : ";
            }
            //if the gender is greater than 6 characters
            if (gender.Length > 6)
            {
                //record the error
                Error = Error + "The gender cannot be more than 6 characters : ";
            }
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The dog's name may not be blank : ";
            }
            //if the name is greater than 50 character
            if (name.Length > 50)
            {
                //record the error
                Error = Error + "The dog's name cannot be more than 50 characters : ";
            }
            if (size.Length == 0)
            {
                //record error
                Error = Error + "The size field cannot be blank : ";
            }
            //if the size field is greater than 15
            if (size.Length > 20)
            {
                //record error
                Error = Error + "The size field cannot be more than 15 characters : ";
            }
            try
            {
                AgeTemp = Convert.ToInt32(age);
                if (AgeTemp == 0)
                {
                    //record the error
                    Error = Error + "The Age field cannot be blank : ";
                }
                if (AgeTemp > 18)
                {
                    //record the error
                    Error = Error + "The age cannot be greater than 18 years old : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The value entered is not a number : ";
            }

            try
            {
                //copy the dataAdded value to the datetemp variable
                DateATemp = Convert.ToDateTime(dateAdded);
                if (DateATemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateATemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The data entered is not a valid date : ";
            }

            //return any error message
            return Error;
        }
        public bool FindLastDogID()
        {
            clsDataConnection DB = new clsDataConnection();
            //DB.Execute("sproc_tblDog_SelectLAstID");
            DB.Execute("sproc_tblDog_SelectLastID");
            //if one record is found ( there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to private data member
                mDogID = Convert.ToInt32(DB.DataTable.Rows[0]["DogID"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
            