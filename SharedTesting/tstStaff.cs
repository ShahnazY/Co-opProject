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
    }
}
