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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsCustomerLoginCollection AllCustomerLogins = new clsCustomerLoginCollection();
            //create the item of test data
            clsCustomerLogin TestItem = new clsCustomerLogin();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerLoginID = 1;
            TestItem.CustomerID = 2;
            TestItem.Email = "John123@gmail.com";
            TestItem.Password = "Password123";
            //set ThisClaim to the test data;
            AllCustomerLogins.ThisCustomerLogin = TestItem;
            //add the record
            PrimaryKey = AllCustomerLogins.Add();
            //set the primary key of the test data
            TestItem.CustomerLoginID = PrimaryKey;
            //find the record
            AllCustomerLogins.ThisCustomerLogin.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomerLogins.ThisCustomerLogin, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerLoginCollection AllCustomerLogins = new clsCustomerLoginCollection();
            clsCustomerLogin TestLogin = new clsCustomerLogin();
            Int32 PrimaryKey = 0;
            TestLogin.CustomerLoginID = 1;
            TestLogin.CustomerID = 2;
            TestLogin.Email = "John.c@outlook.com";
            TestLogin.Password = "Password123";
            AllCustomerLogins.ThisCustomerLogin = TestLogin;
            PrimaryKey = AllCustomerLogins.Add();
            TestLogin.CustomerLoginID = PrimaryKey;
            AllCustomerLogins.ThisCustomerLogin.Find(PrimaryKey);
            AllCustomerLogins.Delete();
            Boolean Found = AllCustomerLogins.ThisCustomerLogin.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsCustomerLoginCollection AllCustomerLogins = new clsCustomerLoginCollection();
            //create the item of test data
            clsCustomerLogin TestLogin = new clsCustomerLogin();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestLogin.CustomerID = 2;
            TestLogin.Email = "John123@gmail.com";
            TestLogin.Password = "Password123";
            //set ThisClaim to the test data;
            AllCustomerLogins.ThisCustomerLogin = TestLogin;
            //add the record
            PrimaryKey = AllCustomerLogins.Add();
            //set the primary key of the test data
            TestLogin.CustomerLoginID = PrimaryKey;
            //modify the record
            TestLogin.CustomerID = 4;
            TestLogin.Email = "John.123@gmail.com";
            TestLogin.Password = "Password321";
            AllCustomerLogins.ThisCustomerLogin = TestLogin;
            AllCustomerLogins.Update();
            AllCustomerLogins.ThisCustomerLogin.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomerLogins.ThisCustomerLogin, TestLogin);
        }

    }
}
