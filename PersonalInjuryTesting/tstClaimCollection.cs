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
 
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsClaimCollection AllClaims = new clsClaimCollection();
            //create the item of test data
            clsClaim TestItem = new clsClaim();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ClaimID = 1;
            TestItem.Location = "Leicester";
            TestItem.Status = "In Progress";
            TestItem.DateOfClaim = DateTime.Now.Date;
            TestItem.DateOfInjury = DateTime.Now.Date.AddYears(-3);
            TestItem.EvidenceProvided = true;
            //set ThisClaim to the test data;
            AllClaims.ThisClaim = TestItem;
            //add the record
            PrimaryKey = AllClaims.Add();
            //set the primary key of the test data
            TestItem.ClaimID = PrimaryKey;
            //find the record
            AllClaims.ThisClaim.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllClaims.ThisClaim, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsClaimCollection AllClaims = new clsClaimCollection();
            //create the item of test data
            clsClaim TestItem = new clsClaim();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ClaimID = 1;
            TestItem.Location = "Leicester";
            TestItem.Status = "In Progress";
            TestItem.DateOfClaim = DateTime.Now.Date;
            TestItem.DateOfInjury = DateTime.Now.Date.AddYears(-3);
            TestItem.EvidenceProvided = true;
            //set ThisClaim to the test data;
            AllClaims.ThisClaim = TestItem;
            //add the record
            PrimaryKey = AllClaims.Add();
            //set the primary key of the test data
            TestItem.ClaimID = PrimaryKey;
            //find the record
            AllClaims.ThisClaim.Find(PrimaryKey);
            //delete the record
            AllClaims.Delete();
            //now find the record
            Boolean Found = AllClaims.ThisClaim.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsClaimCollection AllClaims = new clsClaimCollection();
            //create the item of test data
            clsClaim TestItem = new clsClaim();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Location = "Leicester";
            TestItem.Status = "In Progress";
            TestItem.DateOfClaim = DateTime.Now.Date;
            TestItem.DateOfInjury = DateTime.Now.Date.AddYears(-3);
            TestItem.EvidenceProvided = true;
            //set ThisClaim to the test data;
            AllClaims.ThisClaim = TestItem;
            //add the record
            PrimaryKey = AllClaims.Add();
            //set the primary key of the test data
            TestItem.ClaimID = PrimaryKey;
            //modify the record
            TestItem.Location = "Coventry";
            TestItem.Status = "Pending";
            TestItem.DateOfClaim = DateTime.Now.Date;
            TestItem.DateOfInjury = DateTime.Now.Date.AddYears(-2);
            TestItem.EvidenceProvided = false;
            //set the record based on new data
            AllClaims.ThisClaim = TestItem;
            //update the record
            AllClaims.Update();
            //find the record
            AllClaims.ThisClaim.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllClaims.ThisClaim, TestItem);
        }




    }
}
