using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SharedTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Mark";
            TestItem.LastName = "Smith";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.AddDays(-18);
            TestItem.Email = "M.Smith@gmail.com";
            TestItem.HouseNo = "25";
            TestItem.Street = "Oxford";
            TestItem.Town = "Liverpool";
            TestItem.PostCode = "L1 4BG";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomersList = TestList;
            //test to see it exists
            Assert.AreEqual(AllCustomers.CustomersList, TestList);
        }



        [TestMethod]
        public void ThisCustomerOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties
            TestCustomer.CustomerID =1;
            TestCustomer.FirstName = "Mark";
            TestCustomer.LastName = "Smith";
            TestCustomer.Gender = "Male";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddDays(-18);
            TestCustomer.Email = "M.Smith@gmail.com";
            TestCustomer.HouseNo = "25";
            TestCustomer.Street = "Oxford";
            TestCustomer.Town = "Liverpool";
            TestCustomer.PostCode = "L1 4BG";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see it exists
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Mark";
            TestItem.LastName = "Smith";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.AddDays(-18);
            TestItem.Email = "M.Smith@gmail.com";
            TestItem.HouseNo = "25";
            TestItem.Street = "Oxford";
            TestItem.Town = "Liverpool";
            TestItem.PostCode = "L1 4BG";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomersList = TestList;
            //test to see it exists
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}
