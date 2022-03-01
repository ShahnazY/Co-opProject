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
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CountOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see it exists
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void AllCustomersOK()
        {
            //create an instance of the class
            clsCustomerCollection Customers = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "John";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Customers.AllCustomers = TestList;
            //test to see it exists
            Assert.AreEqual(Customers.AllCustomers, TestList);
        }

        [TestMethod]
        public void CustomersListOK()
        {
            //create an instance of the class
            clsCustomerCollection Customers = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "John";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Customers.AllCustomers = TestList;
            //test to see it exists
            Assert.AreEqual(Customers.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoClaimsPresent()
        {
            clsCustomerCollection Customers = new clsCustomerCollection();
            //test to see that the two values are the same
            Assert.AreEqual(Customers.Count, 2);
        }

    }
}
