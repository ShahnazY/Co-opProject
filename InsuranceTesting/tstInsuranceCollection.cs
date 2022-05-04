using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassLibrary;

namespace InsuranceTesting
{
    [TestClass]
    public class tstInsuranceCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsInsuranceCollection AllInsurances = new clsInsuranceCollection();
            //test to see it exists
            Assert.IsNotNull(AllInsurances);
        }

        [TestMethod]
        public void InsurancesListOK()
        {
            //create an instance of the class
            clsInsuranceCollection AllInsurances = new clsInsuranceCollection();
            //create some test data to assign to the property
            List<clsInsurance> TestList = new List<clsInsurance>();
            //create the item of test data
            clsInsurance TestItem = new clsInsurance();
            //set its properties
            TestItem.InsuranceID = 1;
            TestItem.DogID = 1;
            TestItem.DentalTreatment = true;
            TestItem.Cover = "Accidents Only";
            TestItem.VetFees = "Up to £2000";
            TestItem.Price = 5.99M;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllInsurances.InsuranceList = TestList;
            //test to see it exists
            Assert.AreEqual(AllInsurances.InsuranceList, TestList);
        }

        [TestMethod]
        public void ThisInsuranceOK()
        {
            //create an instance of the class
            clsInsuranceCollection AllInsurances = new clsInsuranceCollection();
            //create some test data to assign to the property
            clsInsurance TestInsurance = new clsInsurance();
            //set its properties
            TestInsurance.InsuranceID = 1;
            TestInsurance.DogID = 1;
            TestInsurance.DentalTreatment = true;
            TestInsurance.Cover = "Accidents Only";
            TestInsurance.VetFees = "Up to £2000";
            TestInsurance.Price = 5.99M;
            //assign the data to the property
            AllInsurances.ThisInsurance = TestInsurance;
            //test to see it exists
            Assert.AreEqual(AllInsurances.ThisInsurance, TestInsurance);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsInsuranceCollection AllInsurances = new clsInsuranceCollection();
            //create some test data to assign to the property
            List<clsInsurance> TestList = new List<clsInsurance>();
            //create the item of test data
            clsInsurance TestItem = new clsInsurance();
            //set its properties
            TestItem.InsuranceID = 1;
            TestItem.DogID = 1;
            TestItem.DentalTreatment = true;
            TestItem.Cover = "Accidents Only";
            TestItem.VetFees = "Up to £2000";
            TestItem.Price = 5.99M;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllInsurances.InsuranceList = TestList;
            //test to see it exists
            Assert.AreEqual(AllInsurances.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
           clsInsuranceCollection AllInsurances = new clsInsuranceCollection();
            //create the item of test data
           clsInsurance TestItem = new clsInsurance();
            //var to store the primary key
           Int32 PrimaryKey = 0;
           //set its properties
           TestItem.InsuranceID = 1;
           TestItem.DogID = 1;
           TestItem.DentalTreatment = true;
           TestItem.Cover = "Accidents Only";
           TestItem.VetFees = "Up to £2000";
           TestItem.Price = 5.99M;
           //set ThisInsurance to the test data;
           AllInsurances.ThisInsurance = TestItem;
           //add the record
           PrimaryKey = AllInsurances.Add();
            //set the primary key of the test data
           TestItem.InsuranceID = PrimaryKey;
            //find the record
            AllInsurances.ThisInsurance.Find(PrimaryKey);
            //test to see that the two values are the same
           Assert.AreEqual(AllInsurances.ThisInsurance, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
       {
            //create an instance of the class
            clsInsuranceCollection AllInsurances = new clsInsuranceCollection();
            //create the item of test data
            clsInsurance TestItem = new clsInsurance();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InsuranceID = 1;
            TestItem.DogID = 1;
            TestItem.DentalTreatment = true;
           TestItem.Cover = "Accidents Only";
           TestItem.VetFees = "Up to £2000";
           TestItem.Price = 5.99M;
           //set Thisinsurance to the test data;
           AllInsurances.ThisInsurance = TestItem;
            //add the record
            PrimaryKey = AllInsurances.Add();
           //set the primary key of the test data
           TestItem.InsuranceID = PrimaryKey;
           //find the record
            AllInsurances.ThisInsurance.Find(PrimaryKey);
            //delete the record
            AllInsurances.Delete();
           //now find the record
            Boolean Found = AllInsurances.ThisInsurance.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
       public void UpdateMethodOK()
       {
            //create an instance of the class
           clsInsuranceCollection AllInsurances = new clsInsuranceCollection();
           //create the item of test data
            clsInsurance TestItem = new clsInsurance();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InsuranceID = 1;
            TestItem.DogID = 1;
            TestItem.DentalTreatment = true;
            TestItem.Cover = "Accidents Only";
            TestItem.VetFees = "Up to £2000";
            TestItem.Price = 5.99M;
            //set ThisInsurance to the test data;
            AllInsurances.ThisInsurance = TestItem;
            //add the record
            PrimaryKey = AllInsurances.Add();
            //set the primary key of the test data
            TestItem.InsuranceID = PrimaryKey;
            //modify the record
            TestItem.DogID = 15;
            TestItem.DentalTreatment = false;
            TestItem.Cover = "Accidents and illnesses";
            TestItem.VetFees = "Up to £6500";
            TestItem.Price = 13.99M;
            //set the record based on new data
            AllInsurances.ThisInsurance = TestItem;
           //update the record
            AllInsurances.Update();
            //find the record
            AllInsurances.ThisInsurance.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllInsurances.ThisInsurance, TestItem);
        }
    }
}
