﻿using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PersonalInjuryTesting
{
    [TestClass]
    public class tstPersonalInjury
    {
        //good test data
        string TypeOfInjury = "Head";
        string Severity = "Moderate";
        string Compensation = "15000";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //test to see it exists
            Assert.IsNotNull(APersonalInjury);
        }

        [TestMethod]
        public void PersonalInjuryIDOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create some test data to assign to the property
            Int32 PersonalInjuryID = 1;
            //assign the data to the property
            APersonalInjury.PersonalInjuryID = PersonalInjuryID;
            //test to see it exists
            Assert.AreEqual(APersonalInjury.PersonalInjuryID, PersonalInjuryID);
        }

        [TestMethod]
        public void TypeOfInjuryOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create some test data to assign to the property
            string SomeTypeOfInjury = "Head";
            //assign the data to the property
            APersonalInjury.TypeOfInjury = SomeTypeOfInjury;
            //test to see it exists
            Assert.AreEqual(APersonalInjury.TypeOfInjury, SomeTypeOfInjury);
        }

        [TestMethod]
        public void SeverityOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create some test data to assign to the property
            string SomeSeverity = "Moderate";
            //assign the data to the property
            APersonalInjury.Severity = SomeSeverity;
            //test to see it exists
            Assert.AreEqual(APersonalInjury.Severity, SomeSeverity);
        }

        public void CompensationOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create some test data to assign to the property
            Decimal Compensation = 50.00M;
            //assign the data to the property
            APersonalInjury.Compensation = Compensation;
            //test to see it exists
            Assert.AreEqual(APersonalInjury.Compensation, Compensation);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an insrance of the class 
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 PersonalInjuryID = 2;
            //invoke the method
            Found = APersonalInjury.Find(PersonalInjuryID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPersonalInjuryIDFound()
        {
            //create an insrance of the class 
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PersonalInjuryID = 2;
            //invoke the method
            Found = APersonalInjury.Find(PersonalInjuryID);
            //check the personal injury ID
            if(APersonalInjury.PersonalInjuryID != 2)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTypeOfInjuryFound()
        {
            //create an insrance of the class 
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PersonalInjuryID = 2;
            //invoke the method
            Found = APersonalInjury.Find(PersonalInjuryID);
            //check the personal injury ID
            if (APersonalInjury.TypeOfInjury != ("Orthopaedic"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSeverityFound()
        {
            //create an insrance of the class 
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PersonalInjuryID = 2;
            //invoke the method
            Found = APersonalInjury.Find(PersonalInjuryID);
            //check the personal injury ID
            if (APersonalInjury.Severity != ("Serious"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompensationFound()
        {
            //create an insrance of the class 
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PersonalInjuryID = 2;
            //invoke the method
            Found = APersonalInjury.Find(PersonalInjuryID);
            //check the personal injury ID
            if (APersonalInjury.Compensation != 115000M)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of validation
            String Error = "";
            //invoke the method
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }
        

        /// <summary>
        /// Personal Injury property tests for minimums, mid and maximums
        /// </summary>

        [TestMethod]
        public void TypeOfInjuryMinLessOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //string variable to store the error message
            string Error = "";
            //create some test data to assign to the property
            string TypeOfInjury = "";
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void TypeOfInjuryMinBoundary()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string TypeOfInjury = "h";
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfInjuryMinPlusOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string TypeOfInjury = "he";
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfInjuryMaxLessOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string TypeOfInjury = "";
            //pad the string with characters
            TypeOfInjury = TypeOfInjury.PadRight(49, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfInjuryMaxBoundary()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string TypeOfInjury = "";
            //pad the string with characters
            TypeOfInjury = TypeOfInjury.PadRight(50, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfInjuryMaxPlusOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string TypeOfInjury = "";
            //pad the string with characters
            TypeOfInjury = TypeOfInjury.PadRight(51, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfInjuryMid()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string TypeOfInjury = "";
            //pad the string with characters
            TypeOfInjury = TypeOfInjury.PadRight(25, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfInjuryExtremeMax()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string TypeOfInjury = "";
            //pad the string with characters
            TypeOfInjury = TypeOfInjury.PadRight(500, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        
        ///<summary>
        ///Severity property tests for minimum, mid, maximums
        ///</summary>
        ///

        [TestMethod]
        public void SeverityMinLessOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Severity = "";
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void SeverityMinBoundary()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Severity = "h";
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SeverityMinPlusOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Severity = "he";
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SeverityMaxLessOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Severity = "";
            //pad the string with characters
            Severity = Severity.PadRight(49, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SeverityMaxBoundary()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Severity = "";
            //pad the string with characters
            Severity = Severity.PadRight(50, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation); 
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SeverityMaxPlusOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Severity = "";
            //pad the string with characters
            Severity = Severity.PadRight(51, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SeverityMid()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Severity = "";
            //pad the string with characters
            Severity = Severity.PadRight(25, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SeverityExtremeMax()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Severity = "";
            //pad the string with characters
            Severity = Severity.PadRight(500, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        ///<summary>
        ///Compensation property tests for minimums, mid and maximums
        ///</summary>
        ///

        [TestMethod]
        public void CompensationMinLessOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal TestCompensation = 0.00M;
            //convert the compensation variable to a string
            string Compensation = TestCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void CompensationMin()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal TestCompensation = 0.01M;
            //convert the compensation variable to a string
            string Compensation = TestCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CompensationMinPlusOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal TestCompensation = 0.02M;
            //convert the compensation variable to a string
            string Compensation = TestCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CompensationMid()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal SomeCompensation = 50000.00M;
            //convert the compensation variable to a string
            string Compensation = SomeCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        
        [TestMethod]
        public void CompensationMaxLessOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal SomeCompensation = 99999.00M;
            //convert the compensation variable to a string
            string Compensation = SomeCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CompensationMax()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal SomeCompensation = 100000.00M;
            //convert the compensation variable to a string
            string Compensation = SomeCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CompensationMaxPlusOne()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Decimal SomeCompensation = 100000.01M;
            //convert the compensation variable to a string
            string Compensation = SomeCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void CompensationInvalidData()
        {
            //create instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //string to store error message
            String Error = "";
            //set the compensation to non money value
            String Compensation = "Value entered is not money!";
            //invoke the method
            Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
    }
}
