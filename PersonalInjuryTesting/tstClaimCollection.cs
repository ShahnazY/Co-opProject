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
        public void ClaimsListOK()
        {
            //create an instance of the class
            clsClaimCollection AllClaims = new clsClaimCollection();
            //create some test data to assign to the property
            List<clsClaim> TestList = new List<clsClaim>();
            //create the item of test data
            clsClaim TestItem = new clsClaim();
            //set its properties
            TestItem.ClaimID = 1;
            TestItem.Location = "Leicester";
            TestItem.Status = "In Progress";
            TestItem.DateOfClaim = DateTime.Now.Date;
            TestItem.DateOfInjury = DateTime.Now.Date.AddDays(-1);
            TestItem.EvidenceProvided = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllClaims.ClaimsList = TestList;
            //test to see it exists
            Assert.AreEqual(AllClaims.ClaimsList, TestList);
        }

        

        [TestMethod]
        public void ThisClaimOK()
        {
            //create an instance of the class
            clsClaimCollection AllClaims = new clsClaimCollection();
            //create some test data to assign to the property
            clsClaim TestClaim = new clsClaim();
            //set its properties
            TestClaim.ClaimID = 1;
            TestClaim.Location = "Leicester";
            TestClaim.Status = "In Progress";
            TestClaim.DateOfClaim = DateTime.Now.Date;
            TestClaim.DateOfInjury = DateTime.Now.Date.AddDays(-1);
            TestClaim.EvidenceProvided = true;
            //assign the data to the property
            AllClaims.ThisClaim = TestClaim;
            //test to see it exists
            Assert.AreEqual(AllClaims.ThisClaim, TestClaim);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsClaimCollection AllClaims = new clsClaimCollection();
            //create some test data to assign to the property
            List<clsClaim> TestList = new List<clsClaim>();
            //create the item of test data
            clsClaim TestItem = new clsClaim();
            //set its properties
            TestItem.ClaimID = 1;
            TestItem.Location = "Leicester";
            TestItem.Status = "In Progress";
            TestItem.DateOfClaim = DateTime.Now.Date;
            TestItem.DateOfInjury = DateTime.Now.Date.AddDays(-1);
            TestItem.EvidenceProvided = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllClaims.ClaimsList = TestList;
            //test to see it exists
            Assert.AreEqual(AllClaims.Count, TestList.Count);
        }

        /*
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

        */
        

      

    }
}
