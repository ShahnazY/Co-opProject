using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PersonalInjuryTesting
{
    [TestClass]
    public class tstClaimInjuryCollection
    {
        public object AllClaimInjuries { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsClaimInjuryCollection AllClaimInjuries = new clsClaimInjuryCollection();
            //test to see it exists
            Assert.IsNotNull(AllClaimInjuries);
        }

        [TestMethod]
        public void CountOK()
        {
            //create an instance of the class
            clsClaimInjuryCollection AllClaimInjuries = new clsClaimInjuryCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllClaimInjuries.Count = SomeCount;
            //test to see it exists
            Assert.AreEqual(AllClaimInjuries.Count, SomeCount);
        }

        [TestMethod]
        public void AllClaimInjuriesOK()
        {
            //create an instance of the class
            clsClaimInjuryCollection ClaimInjuries = new clsClaimInjuryCollection();
            //create some test data to assign to the property
            List<clsClaimInjury> TestList = new List<clsClaimInjury>();
            //create the item of test data
            clsClaimInjury TestItem = new clsClaimInjury();
            //set its properties
            TestItem.ClaimID = 1;
            TestItem.InjuryID = 5;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            ClaimInjuries.AllClaimInjuries = TestList;
            //test to see it exists
            Assert.AreEqual(ClaimInjuries.AllClaimInjuries, TestList);
        }

        [TestMethod]
        public void ClaimInjuriesListOK()
        {
            //create an instance of the class
            clsClaimInjuryCollection ClaimInjuries = new clsClaimInjuryCollection();
            //create some test data to assign to the property
            List<clsClaimInjury> TestList = new List<clsClaimInjury>();
            //create the item of test data
            clsClaimInjury TestItem = new clsClaimInjury();
            //set its properties
            TestItem.ClaimID = 1;
            TestItem.InjuryID = 2;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            ClaimInjuries.AllClaimInjuries = TestList;
            //test to see it exists
            Assert.AreEqual(ClaimInjuries.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoClaimInjuriesPresent()
        {
            clsClaimInjuryCollection ClaimInjuries = new clsClaimInjuryCollection();
            //test to see that the two values are the same
            Assert.AreEqual(ClaimInjuries.Count, 2);
        }
    }
}
