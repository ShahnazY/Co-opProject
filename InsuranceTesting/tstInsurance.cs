using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace InsuranceTesting
{
    [TestClass]
    public class tstInsurance
    {


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
    }
}
