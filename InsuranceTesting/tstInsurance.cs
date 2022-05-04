using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace InsuranceTesting
{
    [TestClass]
    public class tstInsurance
    {
        //test data to pass methods for an insurance
        string InsuranceID = "1";
        string DogID = "1";
        string Cover = "Accidents Only";
        string VetFees = "Up to £2000";
        string Price = "5.99";

        [TestMethod]
        public void InstanceOK()
        {
            //create an insatnce of the class we want to create
            clsInsurance AnInsurance = new clsInsurance();
            //test to see that it exists
            Assert.IsNotNull(AnInsurance);
        }
        [TestMethod]
        public void InsuranceIDOK()
        {
            //create an instance of the class clsInsurance
            clsInsurance AnInsurance = new clsInsurance();
            //create test data to assign to the property
            Int32 TestData = 6;
            //asign data to the property
            AnInsurance.InsuranceID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, AnInsurance.InsuranceID);
        }

        [TestMethod]
        public void DogIDOK()
        {
            //create an insatnce of the class we want to create
            clsInsurance AnInsurance = new clsInsurance();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnInsurance.DogID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnInsurance.DogID, TestData);
        }

        [TestMethod]
        public void DentalTreatmentOK()
        {
            //create an instance of the class clsInsurance
            clsInsurance AnInsurance = new clsInsurance();
            //create some test data to assign to the property
            Boolean TestData = true;
            //asign the data to the property
            AnInsurance.DentalTreatment = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, AnInsurance.DentalTreatment);
        }
        [TestMethod]
        public void CoverOK()
        {
            //create an instance of the class clsInsurance
            clsInsurance AnInsurance = new clsInsurance();
            //test data to assign to the property
            string TestData;
            TestData = "Accident Only";
            //assign data to the property
            AnInsurance.Cover = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, AnInsurance.Cover);
        }
        [TestMethod]
        public void VetFeesOK()
        {
            //create an insatnce of the class we want to create
            clsInsurance AnInsurance = new clsInsurance();
            //create some test data to assign to the property
            string TestData = "Up to £3000";
            //asign the data to the property
            AnInsurance.VetFees = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnInsurance.VetFees, TestData);
        }
        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class clsTrainers
            clsInsurance AInsurance = new clsInsurance();
            //test data to assign to the property
            Decimal TestData = 4;
            //test to see the two values are the same
            Assert.AreNotEqual(TestData, AInsurance.Price);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of class we want to create
            clsInsurance AnInsurance = new clsInsurance();
            //Bollean variable to store the resutlts of the validation
            Boolean Found = false;
            //create some test data to use with method
            Int32 InsuranceID = 1;
            //invoke the method
            Found = AnInsurance.Find(InsuranceID);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestInsuranceIDFound()
        {
            //create an instance of the class we want to create
            clsInsurance AnInsurance = new clsInsurance();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 InsuranceID = 1;
            //invoe the method
            Found = AnInsurance.Find(InsuranceID);
            //check the dog no
            if (AnInsurance.InsuranceID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDogIDFound()
        {
            //create an instance of the class we want to create
            clsInsurance AnInsurance = new clsInsurance();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DogID = 1;
            //invoe the method
            Found = AnInsurance.Find(DogID);
            //check the dog no
            if (AnInsurance.DogID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDentalTreatmentFound()
        {
            //create an instance of the class we want to create
            clsInsurance AnInsurance = new clsInsurance();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 InsuranceID = 1;
            //invoke the method
            Found = AnInsurance.Find(InsuranceID);
            //check the property
            if (AnInsurance.DentalTreatment != true) 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCoverFound()
        {
            //create an instance of the class we want to create
            clsInsurance AnInsurance = new clsInsurance();
            //boolean variable to tore the resut of the search
            Boolean Found = false;
            //bollean varibale to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 InsuranceID = 1;
            //invoke the method
            Found = AnInsurance.Find(InsuranceID);
            //check the property
            if (AnInsurance.Cover != "Accidents Only")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestVetFeesFound()
        {
            //create an instance of the class we want to create
            clsInsurance AnInsurance = new clsInsurance();
            //boolean variable to tore the resut of the search
            Boolean Found = false;
            //bollean varibale to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 InsuranceID = 1;
            //invoke the method
            Found = AnInsurance.Find(InsuranceID);
            //check the property
            if (AnInsurance.VetFees != "Up to £2000")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class clsisnurance
            clsInsurance AInsurance = new clsInsurance();
            //test data to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 InsuranceID = 1;
            //invoke the method
            Found = AInsurance.Find(InsuranceID);
            //check the property
            if (AInsurance.Price != Convert.ToDecimal(5.99))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of validation
            String Error = "";
            //invoke the method
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]            
        public void InsuranceIDValid()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of validation
            String Error = "";
            //value of 0 should fail
            Int32 TestValue;
            TestValue = 0;
            String InsuranceID = TestValue.ToString();
            //invoke the method
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DogIDValid()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of validation
            String Error = "";
            //value of 0 should fail
            Int32 TestValue;
            TestValue = 0;
            String DogID = TestValue.ToString();
            //invoke the method
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal TestPrice = 0.00M;
            //convert the price variable to a string
            string Price = TestPrice.ToString();
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal TestPrice = 0.01M;
            //convert the price variable to a string
            string Price = TestPrice.ToString();
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal TestPrice = 0.02M;
            //convert the price variable to a string
            string Price = TestPrice.ToString();
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal SomePrice = 25000.00M;
            //convert the price variable to a string
            string Price = SomePrice.ToString();
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal SomePrice = 49999.00M;
            //convert the price variable to a string
            string Price = SomePrice.ToString();
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal SomePrice = 50000.00M;
            //convert the price variable to a string
            string Price = SomePrice.ToString();
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal SomePrice = 50000.01M;
            //convert the price variable to a string
            string Price = SomePrice.ToString();
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PriceInvalidData()
        {
            //create instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //string to store error message
            String Error = "";
            //set the price to non money value
            String Price = "The value entered has to be money!";
            //invoke the method
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CoverMinLessOne()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Cover = "";
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CoverMinBoundary()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Cover = "A";
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CoverMinPlusOne()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Cover = "Ac";
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CoverMaxLessOne()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Cover = "";
            //pad the string with characters
            Cover = Cover.PadRight(29, 'A');
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CoverMaxBoundary()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Cover = "";
            //pad the string with characters
            Cover = Cover.PadRight(30, 'A');
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CoverMaxPlusOne()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Cover = "";
            //pad the string with characters
            Cover = Cover.PadRight(31, 'A');
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);            
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CoverMid()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Cover = "";
            //pad the string with characters
            Cover = Cover.PadRight(15, 'A');
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CoverExtremeMax()
        {
            //create an instance of the class
            clsInsurance AnInsurance = new clsInsurance();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Cover = "";
            //pad the string with characters
            Cover = Cover.PadRight(50000, 'A');
            //invoke the method 
            Error = AnInsurance.Valid(InsuranceID, DogID, Cover, VetFees, Price);            
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
    }
}
