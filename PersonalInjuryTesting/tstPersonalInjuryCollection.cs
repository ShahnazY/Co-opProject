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

    }
}
