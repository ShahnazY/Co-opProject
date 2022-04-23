using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PersonalInjuryTesting
{
    [TestClass]
    public class tstClaim
    {
        //good test data to pass to the method
        string Location = "Oadby";
        string Status = "In Progress";
        string DateOfClaim = DateTime.Now.Date.ToString();
        string DateOfInjury = DateTime.Now.Date.AddYears(-3).ToString();
        

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
            string Location = "Oadby";
            //assign the data to the property
            AClaim.Location = Location;
            //test to see it exists
            Assert.AreEqual(AClaim.Location, Location);
        }

        [TestMethod]
        public void StatusOK()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create some test data to assign to the property
            string Status = "In Progress";
            //assign the data to the property
            AClaim.Status = Status;
            //test to see it exists
            Assert.AreEqual(AClaim.Status, Status);
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
        public void FindMethodOK()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ClaimID = 1;
            //invoke the method
            Found = AClaim.Find(ClaimID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestLocationFound()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClaimID = 1;
            //invoke the method
            Found = AClaim.Find(ClaimID);
            //check the property
            if (AClaim.Location != "Leicester")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClaimID = 1;
            //invoke the method
            Found = AClaim.Find(ClaimID);
            //check the property
            if (AClaim.Status != "In Progress")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfClaimFound()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClaimID = 1;
            //invoke the method
            Found = AClaim.Find(ClaimID);
            //check the property
            if (AClaim.DateOfClaim != Convert.ToDateTime("22/04/2022"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfInjuryFound()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClaimID = 1;
            //invoke the method
            Found = AClaim.Find(ClaimID);
            //check the property
            if (AClaim.DateOfInjury != Convert.ToDateTime("08/04/2022"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEvidenceProvidedFound()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClaimID = 1;
            //invoke the method
            Found = AClaim.Find(ClaimID);
            //check the property
            if (AClaim.EvidenceProvided != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of validation
            String Error = "";
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Location = "";
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Location = "O";
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Location = "Oa";
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Location = "";
            //pad the string with characters
            Location = Location.PadRight(49, 'a');
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Location = "";
            //pad the string with characters
            Location = Location.PadRight(50, 'a');
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Location = "";
            //pad the string with characters
            Location = Location.PadRight(51, 'a');
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Location = "";
            //pad the string with characters
            Location = Location.PadRight(25, 'a');
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Location = "";
            //pad the string with characters
            Location = Location.PadRight(500, 'a');
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Status = "";
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Status = "h";
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Status = "he";
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Status = "";
            //pad the string with characters
            Status = Status.PadRight(49, 'a');
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxBoundary()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Status = "";
            //pad the string with characters
            Status = Status.PadRight(50, 'a');
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Status = "";
            //pad the string with characters
            Status = Status.PadRight(51, 'a');
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Status = "";
            //pad the string with characters
            Status = Status.PadRight(25, 'a');
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
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
            string Status = "";
            //pad the string with characters
            Status = Status.PadRight(500, 'a');
            //invoke the method 
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void DateOfClaimExtremeMin()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is - 100 years
            TestData = TestData.AddYears(-100);
            //convert the date variable to a string variable 
            string DateOfClaim = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void DateOfClaimMinLessOne()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is - 1 day
            TestData = TestData.AddDays(-1);
            //convert the date variable to a string variable 
            string DateOfClaim = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfClaimMinandMax()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateOfClaim = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfClaimMinPlusOne()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is + 1 day
            TestData = TestData.AddDays(1);
            //convert the date variable to a string variable 
            string DateOfClaim = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfClaimMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is + 1 day
            TestData = TestData.AddDays(-1);
            //convert the date variable to a string variable 
            string DateOfClaim = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfClaimMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is + 1 day
            TestData = TestData.AddDays(+1);
            //convert the date variable to a string variable 
            string DateOfClaim = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOfClaimExtremeMax()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is + 100 years
            TestData = TestData.AddYears(100);
            //convert the date variable to a string variable 
            string DateOfClaim = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfClaimInvalidData()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //set the dateOfClaim to a non date value
            string DateOfClaim = "This is not a date";
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*
        [TestMethod]
        public void DateOfInjuryExtremeMin()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is - 100 years
            TestData = TestData.AddYears(-100);
            //convert the date variable to a string variable 
            string DateOfInjury = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfInjuryMinLessOne()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is - 366 days
            TestData = TestData.AddDays(-366);
            //convert the date variable to a string variable 
            string DateOfInjury = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void DateOfInjuryMin()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is -365 days
            TestData = TestData.AddDays(-365);
            //convert the date variable to a string variable 
            string DateOfInjury = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void DateOfInjuryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is -364days
            TestData = TestData.AddDays(-364);
            //convert the date variable to a string variable 
            string DateOfInjury = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        } 
        [TestMethod]
        public void DatOfInjuryExtremeMax()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is + 100 years
            TestData = TestData.AddYears(100);
            //convert the date variable to a string variable 
            string DateOfInjury = TestData.ToString();
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfInjuryInvalidData()
        {
            //create an instance of the class we want to create
            clsClaim AClaim = new clsClaim();
            //string variable to store any error message
            String Error = "";
            //set the dateOfInjury to a non date value
            string DateOfInjury = "This is not in a date format";
            //invoke the method
            Error = AClaim.Valid(Location, Status, DateOfClaim, DateOfInjury);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        } */
    }
}
