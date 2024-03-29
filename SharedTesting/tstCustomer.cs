﻿using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SharedTesting
{
    [TestClass]
    public class tstCustomer
    {
        string FirstName = "John";
        string LastName = "Smith";
        string DateOfBirth = DateTime.Now.Date.AddYears(-18).ToString();
        string Gender = "Male";
        string Email = "john.smith@gmail.com";
        string HouseNo = "23";
        string Street = "Oxford Street";
        string Town = "Leicester";
        string PostCode = "LE2 1TN";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test to see it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            Int32 TestData = 23;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "John";
            //assign the data to the property
            ACustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Smith";
            //assign the data to the property
            ACustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void ContactNoOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "07123456789";
            //assign the data to the property
            ACustomer.ContactNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.ContactNo, TestData);
        }

        [TestMethod]
        public void GenderOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Male";
            //assign the data to the property
            ACustomer.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Gender, TestData);
        }

        [TestMethod]
        public void HouseNoOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "23";
            //assign the data to the property
            ACustomer.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.HouseNo, TestData);
        }

        [TestMethod]
        public void StreetNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Oxford Road";
            //assign the data to the property
            ACustomer.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Street, TestData);
        }

        [TestMethod]
        public void TownOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Leicester";
            //assign the data to the property
            ACustomer.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Town, TestData);
        }

        [TestMethod]
        public void PostCodeOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "LE2 1TN";
            //assign the data to the property
            ACustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }

        [TestMethod]
        public void DateOfBirthOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            string TestData = "John.Smith@gmail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class clsTrainers
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the new class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create some test data
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerID != 2)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameFound()
        {
            //create an instance of the class clsTrainers
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the claim ID
            if (ACustomer.FirstName != "Tom")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameFound()
        {
            //create an instance of the class 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //bolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.LastName != "Mitchell")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailFound()
        {
            //create an instance of the class 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.Email != "Tom.M@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void DateOfBirthFound()
        {
            //create an instance of the class 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.DateOfBirth != Convert.ToDateTime("22/02/1990"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void GenderFound()
        {
            //create an instance of the class 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.Gender != "Male")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HouseNoFound()
        {
            //create an instance of the class 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.HouseNo != "45")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StreetFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.Street != "Waltshire")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.PostCode != "L6 7ZT")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TownFound()
        {
            //create an instance of the class 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.Town != "Liverpool")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        /// <summary>
        /// Firstname property tests for minimums, mid and maximums
        /// </summary>

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "J";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "Jo";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //pad the string with characters
            FirstName = FirstName.PadRight(49, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //pad the string with characters
            FirstName = FirstName.PadRight(50, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //pad the string with characters
            FirstName = FirstName.PadRight(51, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //pad the string with characters
            FirstName = FirstName.PadRight(25, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //pad the string with characters
            FirstName = FirstName.PadRight(500, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Lastname property tests for minimums, mid and maximums
        /// </summary>


        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "J";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "Jo";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //pad the string with characters
            LastName = LastName.PadRight(49, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //pad the string with characters
            LastName = LastName.PadRight(50, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //pad the string with characters
            LastName = LastName.PadRight(51, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //pad the string with characters
            LastName = LastName.PadRight(25, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //pad the string with characters
            LastName = LastName.PadRight(500, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date 
            TestDate = TestDate.AddYears(-18).AddDays(1);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 18 years (18th birthday today)  
            TestDate = TestDate.AddYears(-18);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 16 years and 1 day (16 birthday yesterday)
            TestDate = TestDate.AddYears(-18).AddDays(-1);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 250 years
            TestDate = TestDate.AddYears(-250);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class 
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error message
            String Error = "";
            //set the DateOfBirth to non date value
            string DateOfBirth = "This is not a date!";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void GenderMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenderMinBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "M";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "Ma";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(5, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMaxBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(6, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(7, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenderMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(3, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(100, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; // should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void HouseNoMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "";// should trigger an error 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void HouseNoMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "a";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);            
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aa";// should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        /// <summary>
        /// Street property tests for minimums, mid and maximums
        /// </summary>

        [TestMethod]
        public void StreetMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Street = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Street = "O";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Street = "Ox";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Street = "";
            //pad the string with characters
            Street = Street.PadRight(49, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Street = "";
            //pad the string with characters
            Street = Street.PadRight(50, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Street = "";
            //pad the string with characters
            Street = Street.PadRight(51, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Street = "";
            //pad the string with characters
            Street = Street.PadRight(25, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Street = "";
            //pad the string with characters
            Street = Street.PadRight(500, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Town property tests for minimums, mid and maximums
        /// </summary>

        [TestMethod]
        public void TownMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Town = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMinBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Street = "L";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Street = "Le";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Town = "";
            //pad the string with characters
            Town = Town.PadRight(49, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Town = "";
            //pad the string with characters
            Town = Town.PadRight(50, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Town = "";
            //pad the string with characters
            Town = Town.PadRight(51, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Town = "";
            //pad the string with characters
            Town = Town.PadRight(25, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Town = "";
            //pad the string with characters
            Town = Town.PadRight(500, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodedMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(1, 'a'); // should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(2, 'a');// should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCod = "";
            PostCod = PostCod.PadRight(7, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(8, 'a');// should pass 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(4, 'a');// should pass (25 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(9, 'a');// should fail 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Gender, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
