using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassLibrary;


namespace SharedTesting
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //instance of the class
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see it exists
            Assert.IsNotNull(AllStaffs);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 2;
            TestItem.FirstName = "Neil";
            TestItem.LastName = "Bird";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18);
            TestItem.Email = "bird123@gmail.com";
            TestItem.Department = "Investment";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffsList = TestList;
            //test to see it exists
            Assert.AreEqual(AllStaffs.StaffsList, TestList);
        }


        [TestMethod]
        public void ThisStaffOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set its properties
            TestStaff.StaffID = 3;
            TestStaff.FirstName = "Neil";
            TestStaff.LastName = "Bird";
            TestStaff.Gender = "Male";
            TestStaff.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestStaff.Email = "bird123@gmail.com";
            TestStaff.Department = "Investment";
            //assign the data to the property
            AllStaffs.ThisStaff = TestStaff;
            //test to see it exists
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 3;
            TestItem.FirstName = "Neil";
            TestItem.LastName = "Bird";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Email = "bird123@gmail.com";
            TestItem.Department = "Investment";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffsList = TestList;
            //test to see it exists
            Assert.AreEqual(AllStaffs.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 3;
            TestItem.FirstName = "Neil";
            TestItem.LastName = "Bird";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Email = "bird123@gmail.com";
            TestItem.Department = "Investment";
            //set Thisdog to the test data;
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 3;
            TestItem.FirstName = "Neil";
            TestItem.LastName = "Bird";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Email = "bird123@gmail.com";
            TestItem.Department = "Investment";
            //set Thisdog to the test data;
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaffs.Delete();
            //now find the record
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName = "Neil";
            TestItem.LastName = "Bird";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Email = "bird123@gmail.com";
            TestItem.Department = "Investment";
            //set Thisdog to the test data;
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the record
            TestItem.FirstName = "Jhonny";
            TestItem.LastName = "Star";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-24);
            TestItem.Email = "J.Star@gmail.com";
            TestItem.Department = "Insurance";
            //set the record based on new data
            AllStaffs.ThisStaff = TestItem;
            //update the record
            AllStaffs.Update();
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
    }
}
