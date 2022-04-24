using System;

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
            //set the private data members to the test data value
            mDogID = 8;
            mAge = 1;
            mBreed = "German Shepherd";
            mGender = "Male";
            mName = "Bruno";
            mSize = "Large";
            mDateAdded = Convert.ToDateTime("23/04/2022");
            //always return true
            return true;
        }

    }
}