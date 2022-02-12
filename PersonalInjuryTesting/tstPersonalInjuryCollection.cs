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
            //create an instance of the class
            clsPersonalInjuryCollection AllPersonalInjuries = new clsPersonalInjuryCollection();
            //test to see it exists
            Assert.IsNotNull(AllPersonalInjuries);
        }

        [TestMethod]
        public void CountOK()
        {
            //create an instance of the class
            clsPersonalInjuryCollection AllPersonalInjuries = new clsPersonalInjuryCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllPersonalInjuries.Count = SomeCount;
            //test to see it exists
            Assert.AreEqual(AllPersonalInjuries.Count, SomeCount);
        }

        [TestMethod]
        public void AllPersonalInjuriesOK()
        {
            //create an instance of the class
            clsPersonalInjuryCollection PersonalInjuries = new clsPersonalInjuryCollection();
            //create some test data to assign to the property
            List<clsPersonalInjury> TestList = new List<clsPersonalInjury>();
            //create the item of test data
            clsPersonalInjury TestItem = new clsPersonalInjury();
            //set its properties
            TestItem.PersonalInjuryID = 1;
            TestItem.TypeOfInjury = "Head";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            PersonalInjuries.AllPersonalInjuries = TestList;
            //test to see it exists
            Assert.AreEqual(PersonalInjuries.AllPersonalInjuries, TestList);
        }

        [TestMethod]
        public void PersonalInjuriesListOK()
        {
            //create an instance of the class
            clsPersonalInjuryCollection PersonalInjuries = new clsPersonalInjuryCollection();
            //create some test data to assign to the property
            List<clsPersonalInjury> TestList = new List<clsPersonalInjury>();
            //create the item of test data
            clsPersonalInjury TestItem = new clsPersonalInjury();
            //set its properties
            TestItem.PersonalInjuryID = 1;
            TestItem.TypeOfInjury = "Head";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            PersonalInjuries.AllPersonalInjuries = TestList;
            //test to see it exists
            Assert.AreEqual(PersonalInjuries.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoPersonalInjuriesPresent()
        {
            clsPersonalInjuryCollection PersonalInjuries = new clsPersonalInjuryCollection();
            //test to see that the two values are the same
            Assert.AreEqual(PersonalInjuries.Count, 2);
        }
    }
}
