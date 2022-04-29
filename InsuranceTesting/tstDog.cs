using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace InsuranceTesting
{
    [TestClass]
    public class tstDog
    {
        //good test data to pass to the method
        string Age = "1";
        string Breed = "German Shepherd";
        string Gender = "Male";
        string Name = "Bruno";
        string Size = "Large";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an insatnce of the class we want to create
            clsDog ADog = new clsDog();
            //test to see that it exists
            Assert.IsNotNull(ADog);
        }

        [TestMethod]
        public void DogIDOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsDog ADog = new clsDog();
            //create some test data to assign to the propert
            Int32 TestData = 8;
            //assign the data to the property
            ADog.DogID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADog.DogID, TestData);
        }

        [TestMethod]
        public void AgeOK()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the proprty
            ADog.Age = TestData;
            //test to see that the two values are the smae
            Assert.AreEqual(TestData, ADog.Age);
        }

        [TestMethod]
        public void BreedOK()
        {
            //create an instance of the calss we want to create
            clsDog ADog = new clsDog();
            //create some test data to assign to the property
            string TestData = "German Shepherd";
            //assign the data to the property
            ADog.Breed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADog.Breed, TestData);
        }

        [TestMethod]
        public void GenderOK()
        {
            //create an instance of the calss we want to create
            clsDog ADog = new clsDog();
            //create some test data to assign to the property
            string TestData = "Male";
            //assign the data to the property
            ADog.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADog.Gender, TestData);
        }

        [TestMethod]
        public void NameOK()
        {
            //create an instance of the calss we want to create
            clsDog ADog = new clsDog();
            //create some test data to assign to the property
            string TestData = "Bruno";
            //assign the data to the property
            ADog.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADog.Name, TestData);
        }

        [TestMethod]
        public void SizeOK()
        {
            //create an instance of the calss we want to create
            clsDog ADog = new clsDog();
            //create some test data to assign to the property
            string TestData = "Large";
            //assign the data to the property
            ADog.Size = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADog.Size, TestData);
        }

        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ADog.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADog.DateAdded, TestData);
        }

       [TestMethod]
       public void FindMethodOK()
       {
           //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
           clsDog ADog = new clsDog();
            //Bollean variable to store the resutlts of the validation
            Boolean Found = false;
            //create some test data to use with method
            Int32 DogID = 2;
            //invoke the method
            Found = ADog.Find(DogID);
            //test to see if the result is true
           Assert.IsTrue(Found);
 
        }


        [TestMethod]
        public void TestDogIDFound()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DogID = 2;
            //invoe the method
            Found = ADog.Find(DogID);
            //check the dog no
            if (ADog.DogID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAgeFound()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DogID = 2;
            //invoe the method
            Found = ADog.Find(DogID);
            //check the dog no
            if (ADog.Age != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBreedFound()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DogID = 2;
            //invoe the method
            Found = ADog.Find(DogID);
            //check the dog no
            if (ADog.Breed != "Bulldog")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGenderFound()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DogID = 2;
            //invoe the method
            Found = ADog.Find(DogID);
            //check the dog no
            if (ADog.Gender != "Male")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DogID = 2;
            //invoe the method
            Found = ADog.Find(DogID);
            //check the dog no
            if (ADog.Name != "Rex")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSizeFound()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DogID = 2;
            //invoe the method
            Found = ADog.Find(DogID);
            //check the dog no
            if (ADog.Size != "Small")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the calss we want to create
            clsDog ADog = new clsDog();
            //boolean variable to store the results of the serach
            Boolean Found = false;
            //bollean variable to record if sata is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DogID = 2;
            //invoke the method
            Found = ADog.Find(DogID);
            //check the property
            if (ADog.DateAdded != Convert.ToDateTime("06/03/2022"))
            {
                OK = false;
            }
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //invoke method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AgeMinLessOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestAge = 0; //this should trigger an error
            //convert the age variable to a string variable
            string Age = TestAge.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AgeMin()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestAge = 1; //this should pass
            //convert the age variable to a string variable
            string Age = TestAge.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AgeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestAge = 2; //this should pass
            //convert the age variable to a string variable
            string Age = TestAge.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AgeMid()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestAge = 9; //this should pass
            //convert the age variable to a string variable
            string Age = TestAge.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void AgeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestAge = 17; //this should pass
            //convert the age variable to a string variable
            string Age = TestAge.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void AgeMax()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestAge = 18; //this should pass
            //convert the age variable to a string variable
            string Age = TestAge.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void AgeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestAge = 19; //this should pass
            //convert the age variable to a string variable
            string Age = TestAge.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AgeInvalidData()
        {
            //create instance of the class
            clsDog ADog = new clsDog();
            //string to store error message
            String Error = "";
            //set the age added to non int value
            String Age = "Value entered is not a number!";
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BreedMinLessOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string Breed = ""; //this should trigger error message
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BreedMin()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store error message
            String Error = "";
            //create some test data to assign to the property
            string Breed = "b"; //this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BreedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Breed = "bb"; //this shoud pass
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BreedMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Breed = "";
            //pad the string with characters
            Breed = Breed.PadRight(49, 'b'); //this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BreedMax()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to sore error message
            String Error = "";
            //create some test data to assign to the property
            string Breed = "";
            //pad the string with characters
            Breed = Breed.PadRight(50, 'b'); // this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BreedMid()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to sore error message
            String Error = "";
            //create some test data to assign to the property
            string Breed = "";
            //pad the string with characters
            Breed = Breed.PadRight(25, 'b'); // this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BreedMaxPlusOne()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Breed = "";
            //pad the string with characters
            Breed = Breed.PadRight(51, 'b'); //this should fail
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BreedMaxExtreme()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Breed = "";
            //pad the string with characters
            Breed = Breed.PadRight(100, 'b'); // this should fail
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMinLessOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string Gender = ""; //this should trigger error message
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMin()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store error message
            String Error = "";
            //create some test data to assign to the property
            string Gender = "g"; //this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "gg";//this should pass
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(5, 'g'); //this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMax()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to sore error message
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(6, 'g'); // this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMid()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to sore error message
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(3, 'g'); // this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxPlusOne()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(7, 'g'); //this should fail
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxExtreme()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(200, 'g'); // this should fail
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string Name = ""; //this should trigger error message
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store error message
            String Error = "";
            //create some test data to assign to the property
            string Name = "n";//this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nn";//this should pass
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            //pad the string with characters
            Name = Name.PadRight(49, 'n'); //this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to sore error message
            String Error = "";
            //create some test data to assign to the property
            string Name = "";
            //pad the string with characters
            Name = Name.PadRight(50, 'n'); // this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to sore error message
            String Error = "";
            //create some test data to assign to the property
            string Name = "";
            //pad the string with characters
            Name = Name.PadRight(25, 'n'); // this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Name = "";
            //pad the string with characters
            Name = Name.PadRight(51, 'n'); //this should fail
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxExtreme()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Name = "";
            //pad the string with characters
            Name = Name.PadRight(200, 'n'); // this should fail
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SizeMinLessOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string Size = ""; //this should trigger error message
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SizeMin()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store error message
            String Error = "";
            //create some test data to assign to the property
            string Size = "a"; //this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Size = "aa"; //this should pass
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Size = "";
            //pad the string with characters
            Size = Size.PadRight(19, 'a'); //this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMax()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to sore error message
            String Error = "";
            //create some test data to assign to the property
            string Size = "";
            //pad the string with characters
            Size = Size.PadRight(20, 'a'); // this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMid()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to sore error message
            String Error = "";
            //create some test data to assign to the property
            string Size = "";
            //pad the string with characters
            Size = Size.PadRight(10, 'a'); // this should pass
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxPlusOne()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Size = "";
            //pad the string with characters
            Size = Size.PadRight(21, 'a'); //this should fail
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxExtreme()
        {
            //create an instance of the class
            clsDog ADog = new clsDog();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Size = "";
            //pad the string with characters
            Size = Size.PadRight(200, 'a'); // this should fail
            //invoke the method 
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtrimeMin()
        {
            //create an instance of the calss we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            DateTime TestData;
            //set the data to todays date
            TestData = DateTime.Now.Date;
            //change the date to whanever the date is - 100 years
            TestData = TestData.AddYears(-100);
            //convert the data variable to a string variable
            string DateAdded = TestData.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is corret
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is - 1 day
            TestData = TestData.AddDays(-1);
            //convert the date variable to a string variable 
            string DateAdded = TestData.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestData.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is + 1 day
            TestData = TestData.AddDays(1);
            //convert the date variable to a string variable 
            string DateAdded = TestData.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is + 100 years
            TestData = TestData.AddYears(100);
            //convert the date variable to a string variable 
            string DateAdded = TestData.ToString();
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //string variable to store any error message
            String Error = "";
            //set the dateOfClaim to a non date value
            string DateAdded = "This is not a valid date";
            //invoke the method
            Error = ADog.Valid(Age, Breed, Gender, Name, Size, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
