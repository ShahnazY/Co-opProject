using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace InsuranceTesting
{
    [TestClass]
    public class tstDog
    {
     

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
            Assert.AreEqual(ADog.Age, TestData);
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


    }
}
