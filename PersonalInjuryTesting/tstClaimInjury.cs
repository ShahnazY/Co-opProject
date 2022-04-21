using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PersonalInjuryTesting
{
    [TestClass]
    public class tstClaimInjury
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //see it exists
            Assert.IsNotNull(AClaimInjury);
        }

        [TestMethod]
        public void ClaimIDOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create some test data to assign to the property
            Int32 ClaimID = 1;
            //assign the data to the property
            AClaimInjury.ClaimID = ClaimID;
            //test to see it exists
            Assert.AreEqual(AClaimInjury.ClaimID, ClaimID);
        }

        [TestMethod]
        public void InjuryIDOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create some test data to assign to the property
            Int32 InjuryID = 1;
            //assign the data to the property
            AClaimInjury.InjuryID = InjuryID;
            //test to see it exists
            Assert.AreEqual(AClaimInjury.InjuryID, InjuryID);
        }

        /*[TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create a string variable to store the result of validation
            String Error = "";
            //create some test data to test the method
            string SomeClaimInjury = "TestData";
            //invoke the method
            Error = AClaimInjury.Valid(SomeClaimInjury);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }*/
    }
}
