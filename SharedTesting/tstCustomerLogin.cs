using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Co_opClasses;

namespace SharedTesting
{
    [TestClass]
    public class tstCustomerLogin
    {
        string CustomerID = "5";
        string Email = "John123@gmail.com";
        string Password = "Password123";

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            Assert.IsNotNull(ACustomerLogin);
        }

        [TestMethod]
        public void CustomerLoginIDOK()
        {
            //create an instance of the class
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create some test data to assign to the property
            Int32 CustomerLoginID = 2;
            //assign the data to the property
            ACustomerLogin.CustomerLoginID = CustomerLoginID;
            //test to see it exists
            Assert.AreEqual(ACustomerLogin.CustomerLoginID, CustomerLoginID);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create some test data to assign to the property 
            Int32 TestData = 23;
            //assign the data to the property
            ACustomerLogin.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerLogin.CustomerID, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create some test data to assign to the property 
            string TestData = "John.Smith@gmail.com";
            //assign the data to the property
            ACustomerLogin.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerLogin.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create some test data to assign to the property 
            string TestData = "JohnS123";
            //assign the data to the property
            ACustomerLogin.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerLogin.Password, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerLoginID = 2;
            //invoke method
            Found = ACustomerLogin.Find(CustomerLoginID);
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void CustomerLoginIDFound()
        {
            //create an instance of the class we want to create
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerLoginID = 2;
            //invoke method
            Found = ACustomerLogin.Find(CustomerLoginID);
            if (ACustomerLogin.CustomerLoginID != 2)
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerLoginID = 2;
            //invoke method
            Found = ACustomerLogin.Find(CustomerLoginID);
            if (ACustomerLogin.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void EmailFound()
        {
            //create an instance of the class we want to create
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerLoginID = 2;
            //invoke method
            Found = ACustomerLogin.Find(CustomerLoginID);
            if (ACustomerLogin.Email != Convert.ToString("matt12@gmail.com"))
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerLoginID = 2;
            //invoke method
            Found = ACustomerLogin.Find(CustomerLoginID);
            if (ACustomerLogin.Password != Convert.ToString("password12"))
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //string variable to store any error message
            String Error = "";
            //invoke method 
            Error = ACustomerLogin.Valid(CustomerID, Email, Password);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; // should trigger an error
            //invoke the method
            Error = ACustomerLogin.Valid(CustomerID, Email,Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //
        //tests for password property
        //


        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create a string variable to store the result of the validation
            String Error = "Passwo";
            //create some test data to assign to the property
            string Password = "";
            //invoke the method 
            Error = ACustomerLogin.Valid(CustomerID, Email, Password);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinBoundary()
        {
            //create an instance of the class
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "Passwor";
            //invoke the method 
            Error = ACustomerLogin.Valid(CustomerID, Email, Password);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "Password";
            //invoke the method 
            Error = ACustomerLogin.Valid(CustomerID, Email, Password);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "";
            //pad the string with characters
            Password =Password.PadRight(14, 'a');
            //invoke the method 
            Error = ACustomerLogin.Valid(CustomerID, Email, Password);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxBoundary()
        {
            //create an instance of the class
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "";
            //pad the string with characters
            Password = Password.PadRight(15, 'a');
            //invoke the method 
            Error = ACustomerLogin.Valid(CustomerID, Email, Password);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "";
            //pad the string with characters
            Password = Password.PadRight(16, 'a');
            //invoke the method 
            Error = ACustomerLogin.Valid(CustomerID, Email, Password);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "";
            //pad the string with characters
            Password = Password.PadRight(7, 'a');
            //invoke the method 
            Error = ACustomerLogin.Valid(CustomerID, Email, Password);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "";
            //pad the string with characters
            Password = Password.PadRight(100, 'a');
            //invoke the method 
            Error = ACustomerLogin.Valid(CustomerID, Email, Password);
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
            clsCustomerLogin ACustomerLogin = new clsCustomerLogin();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Password = "1";
            //invoke the method 
            Error = ACustomerLogin.Valid(CustomerID, Email, Password);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

    }
}
