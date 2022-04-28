using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
            TestItem.DateOfBirth = DateTime.Now.AddDays(-18);
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
            TestStaff.DateOfBirth = DateTime.Now.Date.AddDays(-18);
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
            TestItem.DateOfBirth = DateTime.Now.Date.AddDays(-18);
            TestItem.Email = "bird123@gmail.com";
            TestItem.Department = "Investment";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffsList = TestList;
            //test to see it exists
            Assert.AreEqual(AllStaffs.Count, TestList.Count);
        }
    }
}
