using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Co_opClasses;

namespace SharedTesting
{
    [TestClass]
    public class tstCustomerLogin
    {
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
            Int32 CustomerLoginID = 1;
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
            //create som test data to assign to the property 
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
            //create som test data to assign to the property 
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
            //create som test data to assign to the property 
            string TestData = "JohnS123";
            //assign the data to the property
            ACustomerLogin.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerLogin.Password, TestData);
        }
    }
}
