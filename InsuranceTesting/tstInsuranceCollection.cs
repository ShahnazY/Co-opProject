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
            TestItem.DentalTreatment = true;
            TestItem.Cover = "Accidents Only";
            TestItem.VetFees = "Up to £2000";
            TestItem.Price = 5.99M;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllInsurances.InsurancesList = TestList;
            //test to see it exists
            Assert.AreEqual(AllInsurances.InsurancesList, TestList);
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
            TestItem.DentalTreatment = true;
            TestItem.Cover = "Accidents Only";
            TestItem.VetFees = "Up to £2000";
            TestItem.Price = 5.99M;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllInsurances.InsurancesList = TestList;
            //test to see it exists
            Assert.AreEqual(AllInsurances.Count, TestList.Count);
        }
    }
}
