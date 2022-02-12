using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PersonalInjuryTesting
{
    [TestClass]
    public class tstClaimCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsClaimCollection AllClaims = new clsClaimCollection();
            //test to see it exists
            Assert.IsNotNull(AllClaims);
        }

        [TestMethod]
        public void CountOK()
        {
            //create an instance of the class
            clsClaimCollection AllClaims = new clsClaimCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllClaims.Count = SomeCount;
            //test to see it exists
            Assert.AreEqual(AllClaims.Count, SomeCount);
        }

        [TestMethod]
        public void AllClaimsOK()
        {
            //create an instance of the class
            clsClaimCollection Claims = new clsClaimCollection();
            //create some test data to assign to the property
            List<clsClaim> TestList = new List<clsClaim>();
            //create the item of test data
            clsClaim TestItem = new clsClaim();
            //set its properties
            TestItem.ClaimID = 1;
            TestItem.Location = "Leicester";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Claims.AllClaims = TestList;
            //test to see it exists
            Assert.AreEqual(Claims.AllClaims, TestList);
        }

        [TestMethod]
        public void ClaimsListOK()
        {
            //create an instance of the class
            clsClaimCollection Claims = new clsClaimCollection();
            //create some test data to assign to the property
            List<clsClaim> TestList = new List<clsClaim>();
            //create the item of test data
            clsClaim TestItem = new clsClaim();
            //set its properties
            TestItem.ClaimID = 1;
            TestItem.Location = "Leicester";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Claims.AllClaims = TestList;
            //test to see it exists
            Assert.AreEqual(Claims.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoClaimsPresent()
        {
            clsClaimCollection Claims = new clsClaimCollection();
            //test to see that the two values are the same
            Assert.AreEqual(Claims.Count, 2);
        }
    }
}
