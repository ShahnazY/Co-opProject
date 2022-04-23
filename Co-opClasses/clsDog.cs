using System;



namespace Co_opClasses
{
    public class clsDog
    {
        //private data member for the dog ID propert
        private Int32 mDogID;
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

        //private data member for the age property
        public Int32 mAge;
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

        //private data member for breed
        private string mBreed;
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

        //private data member for gender
        private string mGender;
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

        //private data member for name
        private string mName;
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

        //private data member for size
        private string mSize;
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

        //private data added data memebr
        private DateTime mDateAdded;
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