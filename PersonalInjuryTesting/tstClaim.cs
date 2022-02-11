using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PersonalInjuryTesting
{
    [TestClass]
    public class tstClaim
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //test to see it exists
            Assert.IsNotNull(AClaim);
        }

        [TestMethod]
        public void ClaimIDOK()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create some test data to assign to the property
            Int32 ClaimID = 1;
            //assign the data to the property
            AClaim.ClaimID = ClaimID;
            //test to see it exists
            Assert.AreEqual(AClaim.ClaimID, ClaimID);
        }

        [TestMethod]
        public void LocationOK()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create some test data to assign to the property
            string SomeLocation = "Leicester";
            //assign the data to the property
            AClaim.Location = SomeLocation;
            //test to see it exists
            Assert.AreEqual(AClaim.Location, SomeLocation);
        }

        [TestMethod]
        public void StatusOK()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create some test data to assign to the property
            string SomeStatus = "In Progress";
            //assign the data to the property
            AClaim.Status = SomeStatus;
            //test to see it exists
            Assert.AreEqual(AClaim.Status, SomeStatus);
        }


        [TestMethod]
        public void DateOfClaimOK()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AClaim.DateOfClaim = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, AClaim.DateOfClaim);
        }

        [TestMethod]
        public void DateOfInjuryOK()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AClaim.DateOfInjury = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, AClaim.DateOfInjury);
        }

        [TestMethod]
        public void EvidenceProvidedOK()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AClaim.EvidenceProvided = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, AClaim.EvidenceProvided);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of validation
            String Error = "";
            //create some test data to test the method
            string SomeLocation = "TestData";
            //invoke the method
            Error = AClaim.Valid(SomeLocation);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }

        /// <summary>
        /// Location property tests for minimums, mid and maximums
        /// </summary>

        [TestMethod]
        public void LocationMinLessOne()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeLocation = "";
            //invoke the method 
            Error = AClaim.Valid(SomeLocation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LocationMinBoundary()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeLocation = "h";
            //invoke the method 
            Error = AClaim.Valid(SomeLocation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationMinPlusOne()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeLocation = "he";
            //invoke the method 
            Error = AClaim.Valid(SomeLocation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationMaxLessOne()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeLocation = "";
            //pad the string with characters
            SomeLocation = SomeLocation.PadRight(49, 'a');
            //invoke the method 
            Error = AClaim.Valid(SomeLocation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationMaxBoundary()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeLocation = "";
            //pad the string with characters
            SomeLocation = SomeLocation.PadRight(50, 'a');
            //invoke the method 
            Error = AClaim.Valid(SomeLocation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationMaxPlusOne()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeLocation = "";
            //pad the string with characters
            SomeLocation = SomeLocation.PadRight(51, 'a');
            //invoke the method 
            Error = AClaim.Valid(SomeLocation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LocationMid()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeLocation = "";
            //pad the string with characters
            SomeLocation = SomeLocation.PadRight(25, 'a');
            //invoke the method 
            Error = AClaim.Valid(SomeLocation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationExtremeMax()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeLocation = "";
            //pad the string with characters
            SomeLocation = SomeLocation.PadRight(500, 'a');
            //invoke the method 
            Error = AClaim.Valid(SomeLocation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }


        /// <summary>
        /// Status property tests for minimums, mid and maximums
        /// </summary>

        [TestMethod]
        public void StatusMinLessOne()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeStatus = "";
            //invoke the method 
            Error = AClaim.Valid(SomeStatus);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatusMinBoundary()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeStatus = "h";
            //invoke the method 
            Error = AClaim.Valid(SomeStatus);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMinPlusOne()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeStatus = "he";
            //invoke the method 
            Error = AClaim.Valid(SomeStatus);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxLessOne()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeStatus = "";
            //pad the string with characters
            SomeStatus = SomeStatus.PadRight(49, 'a');
            //invoke the method 
            Error = AClaim.Valid(SomeStatus);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusnMaxBoundary()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeStatus = "";
            //pad the string with characters
            SomeStatus = SomeStatus.PadRight(50, 'a');
            //invoke the method 
            Error = AClaim.Valid(SomeStatus);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxPlusOne()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeStatus = "";
            //pad the string with characters
            SomeStatus = SomeStatus.PadRight(51, 'a');
            //invoke the method 
            Error = AClaim.Valid(SomeStatus);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatusMid()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeStatus = "";
            //pad the string with characters
            SomeStatus = SomeStatus.PadRight(25, 'a');
            //invoke the method 
            Error = AClaim.Valid(SomeStatus);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusExtremeMax()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeStatus = "";
            //pad the string with characters
            SomeStatus = SomeStatus.PadRight(500, 'a');
            //invoke the method 
            Error = AClaim.Valid(SomeStatus);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
    }
}
