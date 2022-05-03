using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SharedTesting
{
    [TestClass]
    public class tstCustomerLoginCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerLoginCollection AllCustomerLogins = new clsCustomerLoginCollection();
            Assert.IsNotNull(AllCustomerLogins);
        }

        [TestMethod]
        public void CustomerLoginListOK()
        {
            clsCustomerLoginCollection AllCustomerLogins = new clsCustomerLoginCollection();
            List<clsCustomerLogin> TestList = new List<clsCustomerLogin>();
            clsCustomerLogin TestItem = new clsCustomerLogin();
            TestItem.CustomerLoginID = 2;
            TestItem.CustomerID = 1;
            TestItem.Email = "John123@gmail.com";
            TestItem.Password = "Password123";
            //add the item to the test list
            TestList.Add(TestItem);
            AllCustomerLogins.CustomerLoginList = TestList;
            Assert.AreEqual(AllCustomerLogins.CustomerLoginList, TestList);
        }

        [TestMethod]
        public void ThisCustomerLoginOK()
        {
            //create an instance of the class
            clsCustomerLoginCollection AllCustomerLogins = new clsCustomerLoginCollection();
            //create some test data to assign to the property
            clsCustomerLogin TestCustomerLogin = new clsCustomerLogin();
            //set its properties
            TestCustomerLogin.CustomerLoginID = 1;
            TestCustomerLogin.CustomerID = 3;
            TestCustomerLogin.Email = "M.Smith@gmail.com";
            TestCustomerLogin.Password = "Password123";
            AllCustomerLogins.ThisCustomerLogin = TestCustomerLogin;
            //test to see it exists
            Assert.AreEqual(AllCustomerLogins.ThisCustomerLogin, TestCustomerLogin);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsCustomerLoginCollection AllCustomerLogins = new clsCustomerLoginCollection();
            //create some test data to assign to the property
            List<clsCustomerLogin> TestList = new List<clsCustomerLogin>();
            //create the item of test data
            clsCustomerLogin TestItem = new clsCustomerLogin();
            //set its properties
            TestItem.CustomerLoginID = 1;
            TestItem.CustomerID = 3;
            TestItem.Email = "M.Smith@gmail.com";
            TestItem.Password = "Password123";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomerLogins.CustomerLoginList = TestList;
            //test to see it exists
            Assert.AreEqual(AllCustomerLogins.Count, TestList.Count);
        }

    }
}
