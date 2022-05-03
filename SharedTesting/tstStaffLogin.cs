using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace SharedTesting
{
    [TestClass]
    public class tstStaffLogin
    {
        //good test data to pass to the method
        string StaffID = "1";
        string Email = "jane@gmail.com";
        string Password = "Password";

        [TestMethod]
        public void InstanceOK()
        {
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            Assert.IsNotNull(AStaffLogin);
        }

        [TestMethod]
        public void StaffLoginIDOK()
        {
            //create an instance of the class
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create some test data to assign to the property
            Int32 StaffLoginID = 1;
            //assign the data to the property
            AStaffLogin.StaffLoginID = StaffLoginID;
            //test to see it exists
            Assert.AreEqual(AStaffLogin.StaffLoginID, StaffLoginID);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            //create an instance of the class we want to create
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create som test data to assign to the property 
            Int32 TestData = 2;
            //assign the data to the property
            AStaffLogin.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffLogin.StaffID, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create som test data to assign to the property 
            string TestData = "bird123@gmail.com";
            //assign the data to the property
            AStaffLogin.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffLogin.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create som test data to assign to the property 
            string TestData = "Password";
            //assign the data to the property
            AStaffLogin.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffLogin.Password, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of class we want to create
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //Bollean variable to store the resutlts of the validation
            Boolean Found = false;
            //create some test data to use with method
            Int32 StaffLoginID = 1;
            //invoke the method
            Found = AStaffLogin.Find(StaffLoginID);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void StaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffLoginID = 1;
            //invoke method
            Found = AStaffLogin.Find(StaffLoginID);
            if (AStaffLogin.StaffID != 1)
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoe the method
            Found = AStaffLogin.Find(StaffID);
            //check the dog no
            if (AStaffLogin.StaffID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffLoginID = 1;
            //invoe the method
            Found = AStaffLogin.Find(StaffLoginID);
            //check the customer no
            if (AStaffLogin.Email != "jane@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffLoginID = 1;
            //invoe the method
            Found = AStaffLogin.Find(StaffLoginID);
            //check the customer no
            if (AStaffLogin.Password != "Password")
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
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //string variable to store any error message
            String Error = "";
            //invoke method 
            Error = AStaffLogin.Valid(StaffID, Email, Password);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; // should trigger an error
            //invoke the method
            Error = AStaffLogin.Valid(StaffID, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create a string variable to store the result of the validation
            String Error = "Pass";
            //create some test data to assign to the property
            string Password = "";
            //invoke the method 
            Error = AStaffLogin.Valid(StaffID, Email, Password);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinBoundary()
        {
            //create an instance of the class
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "Passw";
            //invoke the method 
            Error = AStaffLogin.Valid(StaffID, Email, Password);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "Passwo";
            //invoke the method 
            Error = AStaffLogin.Valid(StaffID, Email, Password);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "";
            //pad the string with characters
            Password = Password.PadRight(19, 'a');
            //invoke the method 
            Error = AStaffLogin.Valid(StaffID, Email, Password);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxBoundary()
        {
            //create an instance of the class
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "";
            //pad the string with characters
            Password = Password.PadRight(20, 'a');
            //invoke the method 
            Error = AStaffLogin.Valid(StaffID, Email, Password);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "";
            //pad the string with characters
            Password = Password.PadRight(21, 'a');
            //invoke the method 
            Error = AStaffLogin.Valid(StaffID, Email, Password);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "";
            //pad the string with characters
            Password = Password.PadRight(10, 'a');
            //invoke the method 
            Error = AStaffLogin.Valid(StaffID, Email, Password);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "";
            //pad the string with characters
            Password = Password.PadRight(100, 'a');
            //invoke the method 
            Error = AStaffLogin.Valid(StaffID, Email, Password);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create an instance of the class
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string CustomerID = "";
            //invoke the method 
            Error = ACustomerLogin.Valid(CustomerID, Email, Password);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinBoundary()
        {
            //create an instance of the class
            clsStaffLogin AStaffLogin = new clsStaffLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "1";
            //invoke the method 
            Error = AStaffLogin.Valid(StaffID, Email, Password);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }
    }
}
