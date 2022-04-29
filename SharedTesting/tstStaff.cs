using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Co_opClasses;
using ClassLibrary;

namespace SharedTesting
{
    [TestClass]
    public class tstStaff
    {
        string FirstName = "Jane";
        string LastName = "Smith";
        string Gender = "Female";
        string DateOfBirth = DateTime.Now.Date.AddYears(-18).ToString();
        string Email = "jane@gmail.com";
        string Department = "Insurance";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //test to see it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create som test data to assign to the property 
            Int32 TestData = 3;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "Jane";
            //assign the data to the property
            AStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FirstName, TestData);
        }

        [TestMethod]
        public void LastNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "Smith";
            //assign the data to the property
            AStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.LastName, TestData);
        }

        [TestMethod]
        public void GenderOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "Female";
            //assign the data to the property
            AStaff.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Gender, TestData);
        }

        [TestMethod]
        public void DateOfBirthOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateOfBirth, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create som test data to assign to the property 
            string TestData = "jane@gmail.com";
            //assign the data to the property
            AStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "Insurance";
            //assign the data to the property
            AStaff.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Department, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class clsStaff
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void StaffIDFound()
        {
            //create an instance of the new class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create some test data
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the Staff id
            if (AStaff.StaffID != 3)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameFound()
        {
            //create an instance of the class clsstaff
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the first name
            if (AStaff.FirstName != "Paige")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameFound()
        {
            //create an instance of the cls staff
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //bolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff last name
            if (AStaff.LastName != "Brown")
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
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff gender
            if (AStaff.Gender != "Female")
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
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff DOB
            if (AStaff.DateOfBirth != Convert.ToDateTime("03/12/1899"))
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
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff email
            if (AStaff.Email != "paige1899@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DepartmentFound()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff department
            if (AStaff.Department != "Personal Injury")
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
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "J";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "Ja";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //pad the string with characters
            FirstName = FirstName.PadRight(49, 'j');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //pad the string with characters
            FirstName = FirstName.PadRight(50, 'j');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);           
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //pad the string with characters
            FirstName = FirstName.PadRight(51, 'j');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //pad the string with characters
            FirstName = FirstName.PadRight(25, 'j');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string FirstName = "";
            //pad the string with characters
            FirstName = FirstName.PadRight(500, 'j');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);           
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "S";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "Sm";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //pad the string with characters
            LastName = LastName.PadRight(49, 's');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //pad the string with characters
            LastName = LastName.PadRight(50, 's');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //pad the string with characters
            LastName = LastName.PadRight(51, 's');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //pad the string with characters
            LastName = LastName.PadRight(25, 's');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string LastName = "";
            //pad the string with characters
            LastName = LastName.PadRight(500, 's');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenderMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenderMinBoundary()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "F";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMinPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "Fe";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMaxLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(5, 'f');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMaxBoundary()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(6, 'f');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMaxPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(7, 'f');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenderMid()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(3, 'f');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);           
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Gender = "";
            //pad the string with characters
            Gender = Gender.PadRight(100, 'f');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);           
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 18 years, 18th birthday today
            TestDate = TestDate.AddYears(-18);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 16 years and 1 day, 16 birthday yesterday
            TestDate = TestDate.AddYears(-18).AddDays(-1);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);           
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);           
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class 
            clsStaff AStaff = new clsStaff();
            //string var to store any error message
            String Error = "";
            //set the DateOfBirth to non date value
            string DateOfBirth = "The format is not date!";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);            
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; // should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Department = "";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinBoundary()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Department = "I";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Department = "In";
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Department = "";
            //pad the string with characters
            Department = Department.PadRight(49, 'i');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxBoundary()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Department = "";
            //pad the string with characters
            Department = Department.PadRight(50, 'i');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Department = "";
            //pad the string with characters
            Department = Department.PadRight(51, 'i');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMid()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Department = "";
            //pad the string with characters
            Department = Department.PadRight(25, 'i');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Department = "";
            //pad the string with characters
            Department = Department.PadRight(500, 'i');
            //invoke the method 
            Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
    }
}
