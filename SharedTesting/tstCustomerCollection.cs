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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Matt";
            TestItem.LastName = "Rodriguez";
            TestItem.Gender = "Male";
            TestItem.Email = "M.Rodriguez@outlook.com";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18);
            TestItem.HouseNo = "45";
            TestItem.Street = "London Road";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "LE2 4BQ";
            //set ThisClaim to the test data;
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Matt";
            TestItem.LastName = "Rodriguez";
            TestItem.Gender = "Male";
            TestItem.Email = "Matt.R@outlook.com";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18);
            TestItem.HouseNo = "45";
            TestItem.Street = "London Road";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "LE2 3BQ";

            //set ThisClaim to the test data;
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName = "Matt";
            TestItem.LastName = "Rodriguez";
            TestItem.Gender = "Male";
            TestItem.Email = "Matt.R@outlook.com";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18);
            TestItem.HouseNo = "45";
            TestItem.Street = "London Road";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "LE2 3BQ";
            //set ThisClaim to the test data;
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the record
            TestItem.FirstName = "Matt";
            TestItem.LastName = "Rodriguez";
            TestItem.Gender = "Male";
            TestItem.Email = "Matt.R@outlook.com";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-19);
            TestItem.HouseNo = "50";
            TestItem.Street = "Nottingham Road";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "LE5 6MS";
            //set the record based on new data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem); 
        }

        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByLastName("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByLastNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByLastName("xxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByTownMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByTown("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByTownNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByTown("xxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
    }
}
