using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PersonalInjuryTesting
{
    [TestClass]
    public class tstClaimInjuryCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsClaimInjuryCollection AllClaimInjuries = new clsClaimInjuryCollection();
            //test to see it exists
            Assert.IsNotNull(AllClaimInjuries);
        }

        [TestMethod]
        public void ClaimInjuriesListOK()
        {
            //create an instance of the class
            clsClaimInjuryCollection AllClaimInjuries = new clsClaimInjuryCollection();
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
            AllClaimInjuries.ClaimInjuryList = TestList;
            //test to see it exists
            Assert.AreEqual(AllClaimInjuries.ClaimInjuryList, TestList);
        }

        [TestMethod]
        public void ThisClaimInjuryOK()
        {
            //create an instance of the class 
            clsClaimInjuryCollection AllClaimInjuries = new clsClaimInjuryCollection();
            //create some test data to assign to the property
            clsClaimInjury TestClaimInjuries = new clsClaimInjury();
            //set the properties of the test object
            TestClaimInjuries.ClaimID = 2;
            TestClaimInjuries.InjuryID = 1;
            //assign the data to the property
            AllClaimInjuries.ThisClaimInjury = TestClaimInjuries;
            //test to see that it exists
            Assert.AreEqual(AllClaimInjuries.ThisClaimInjury, TestClaimInjuries);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class 
            clsClaimInjuryCollection AllClaimInjuries = new clsClaimInjuryCollection();
            //create some test data to assign to the property
            List<clsClaimInjury> TestList = new List<clsClaimInjury>();
            clsClaimInjury TestClaimInjury = new clsClaimInjury();
            //set the properties of the test object
            TestClaimInjury.ClaimID = 2;
            TestClaimInjury.InjuryID = 1;
            //add the item to the test list
            TestList.Add(TestClaimInjury);
            //assign the data to the property
            AllClaimInjuries.ClaimInjuryList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllClaimInjuries.Count, TestList.Count);
        }


    }
}
