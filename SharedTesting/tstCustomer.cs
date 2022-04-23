using Co_opClasses;
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
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
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        

    }
}
