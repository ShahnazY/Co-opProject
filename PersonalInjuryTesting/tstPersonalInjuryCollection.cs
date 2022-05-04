using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PersonalInjuryTesting
{
    [TestClass]
    public class tstPersonalInjuryCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPersonalInjuryCollection AllPersonalInjuries = new clsPersonalInjuryCollection();
            Assert.IsNotNull(AllPersonalInjuries);
        }

        [TestMethod]
        public void PersonalInjuriesListOK()
        {
            //create an instance of the class
            clsPersonalInjuryCollection AllPersonalInjuries = new clsPersonalInjuryCollection();
            //create some test data to assign to the property
            List<clsPersonalInjury> TestList = new List<clsPersonalInjury>();
            //create the item of test data
            clsPersonalInjury TestItem = new clsPersonalInjury();
            //set its properties
            TestItem.Severity = "Moderate";
            TestItem.TypeOfInjury = "Head";
            TestItem.Compensation = 15000M;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPersonalInjuries.PersonalInjuriesList = TestList;
            //test to see it exists
            Assert.AreEqual(AllPersonalInjuries.PersonalInjuriesList, TestList);
        }

        [TestMethod]
        public void ThisPersonalInjuryyOK()
        {
            //create an instance of the class 
            clsPersonalInjuryCollection AllPersonalInjuries = new clsPersonalInjuryCollection();
            //create some test data to assign to the property
            clsPersonalInjury TestPersonalInjury = new clsPersonalInjury();
            //set the properties of the test object
            TestPersonalInjury.TypeOfInjury = "Head";
            TestPersonalInjury.Severity = "Moderate";
            TestPersonalInjury.Compensation = 15000M;

            //assign the data to the property
            AllPersonalInjuries.ThisPersonalInjury = TestPersonalInjury;
            //test to see that it exists
            Assert.AreEqual(AllPersonalInjuries.ThisPersonalInjury, TestPersonalInjury);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class 
            clsPersonalInjuryCollection AllPersonalInjuries = new clsPersonalInjuryCollection();
            //create some test data to assign to the property
            List<clsPersonalInjury> TestList = new List<clsPersonalInjury>();
            //add an item to the list
            //create the item of test data
            clsPersonalInjury TestItem = new clsPersonalInjury();
            //set the properties of the test object
            TestItem.TypeOfInjury = "Head";
            TestItem.Severity = "Moderate";
            TestItem.Compensation = 15000M;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPersonalInjuries.PersonalInjuriesList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllPersonalInjuries.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsPersonalInjuryCollection AllPersonalInjuries = new clsPersonalInjuryCollection();
            //create the item of test data
            clsPersonalInjury TestItem = new clsPersonalInjury();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PersonalInjuryID = 1;
            TestItem.TypeOfInjury = "Head";
            TestItem.Severity = "Moderate";
            TestItem.Compensation = 15000M;
            //set ThisClaim to the test data;
            AllPersonalInjuries.ThisPersonalInjury = TestItem;
            //add the record
            PrimaryKey = AllPersonalInjuries.Add();
            //set the primary key of the test data
            TestItem.PersonalInjuryID = PrimaryKey;
            //find the record
            AllPersonalInjuries.ThisPersonalInjury.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPersonalInjuries.ThisPersonalInjury, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsPersonalInjuryCollection AllPersonalInjuries = new clsPersonalInjuryCollection();
            //create the item of test data
            clsPersonalInjury TestItem = new clsPersonalInjury();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PersonalInjuryID = 1;
            TestItem.TypeOfInjury = "Head";
            TestItem.Severity = "Moderate";
            TestItem.Compensation = 15000M;
            //set ThisClaim to the test data;
            AllPersonalInjuries.ThisPersonalInjury = TestItem;
            //add the record
            PrimaryKey = AllPersonalInjuries.Add();
            //set the primary key of the test data
            TestItem.PersonalInjuryID = PrimaryKey;
            //find the record
            AllPersonalInjuries.ThisPersonalInjury.Find(PrimaryKey);
            //delete the record
            AllPersonalInjuries.Delete();
            //now find the record
            Boolean Found = AllPersonalInjuries.ThisPersonalInjury.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsPersonalInjuryCollection AllPersonalInjuries = new clsPersonalInjuryCollection();
            //create the item of test data
            clsPersonalInjury TestItem = new clsPersonalInjury();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TypeOfInjury = "Head";
            TestItem.Severity = "Moderate";
            TestItem.Compensation = 15000M;
            //set ThisClaim to the test data;
            AllPersonalInjuries.ThisPersonalInjury = TestItem;
            //add the record
            PrimaryKey = AllPersonalInjuries.Add();
            //set the primary key of the test data
            TestItem.PersonalInjuryID = PrimaryKey;
            //modify the record
            TestItem.TypeOfInjury = "Leg";
            TestItem.Severity = "High";
            TestItem.Compensation = 25000M;
            //set the record based on new data
            AllPersonalInjuries.ThisPersonalInjury = TestItem;
            //update the record
            AllPersonalInjuries.Update();
            //find the record
            AllPersonalInjuries.ThisPersonalInjury.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllPersonalInjuries.ThisPersonalInjury, TestItem);
        }


    }
}
