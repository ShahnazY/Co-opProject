using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PersonalInjuryTesting
{
    [TestClass]
    public class tstClaimInjury
    {
        string ClaimID = "1";
        string InjuryID = "5";

        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //see it exists
            Assert.IsNotNull(AClaimInjury);
        }

        [TestMethod]
        public void ClaimInjuryIDOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create some test data to assign to the property
            Int32 ClaimInjuryID = 1;
            //assign the data to the property
            AClaimInjury.ClaimInjuryID = ClaimInjuryID;
            //test to see it exists
            Assert.AreEqual(AClaimInjury.ClaimInjuryID, ClaimInjuryID);
        }

        [TestMethod]
        public void ClaimIDOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create some test data to assign to the property
            Int32 ClaimID = 1;
            //assign the data to the property
            AClaimInjury.ClaimID = ClaimID;
            //test to see it exists
            Assert.AreEqual(AClaimInjury.ClaimID, ClaimID);
        }

        [TestMethod]
        public void InjuryIDOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create some test data to assign to the property
            Int32 InjuryID = 1;
            //assign the data to the property
            AClaimInjury.InjuryID = InjuryID;
            //test to see it exists
            Assert.AreEqual(AClaimInjury.InjuryID, InjuryID);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ClaimInjuryID = 2;
            //invoke the method
            Found = AClaimInjury.Find(ClaimInjuryID);
            //test to see it exists
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestClaimIDOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClaimInjuryID = 2;
            //invoke the method
            Found = AClaimInjury.Find(ClaimInjuryID);
            //check the property
            if (AClaimInjury.ClaimID != 1)
            {
                OK = false;
            }
            //test to see it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInjuryIDOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClaimInjuryID = 2;
            //invoke the method
            Found = AClaimInjury.Find(ClaimInjuryID);
            //check the property
            if (AClaimInjury.InjuryID != 2)
            {
                OK = false;
            }
            //test to see it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimIDMinLess()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string ClaimID = "";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClaimIDMin()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string ClaimID = "1";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimIDMinPlusOne()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string ClaimID = "12";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimIDMaxLessOne()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string ClaimID = "999";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimIDMax()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string ClaimID = "1000";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimIDMaxPlusOne()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string ClaimID = "1001";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void InjuryIDMinLessOne()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string InjuryID = "";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void InjuryIDMin()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string InjuryID = "1";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InjuryIDMinPlusOne()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string InjuryID = "12";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InjuryIDMaxLessOne()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string InjuryID = "999";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InjuryIDMax()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string InjuryID = "1000";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InjuryIDMaxPlusOne()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            string InjuryID = "1001";
            //invoke the method
            Error = AClaimInjury.Valid(ClaimID, InjuryID);
            //test to see it exists
            Assert.AreNotEqual(Error, "");
        }

    }
}
