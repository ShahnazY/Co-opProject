using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PersonalInjuryTesting
{
    [TestClass]
    public class tstPersonalInjury
    {
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
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of validation
            String Error = "";
            //create some test data to test the method
            string SomePersonalInjury = "Head";
            string SomeSeverity = "Moderate";
            //invoke the method
            Error = APersonalInjury.Valid(SomePersonalInjury, SomeSeverity);
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
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to assign to the property
            string SomeTypeOfInjury = "";
            //invoke the method 
            Error = APersonalInjury.Valid(SomeTypeOfInjury);
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
            string SomeTypeOfInjury = "h";
            //invoke the method 
            Error = APersonalInjury.Valid(SomeTypeOfInjury);
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
            string SomeTypeOfInjury = "he";
            //invoke the method 
            Error = APersonalInjury.Valid(SomeTypeOfInjury);
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
            string SomeTypeOfInjury = "";
            //pad the string with characters
            SomeTypeOfInjury = SomeTypeOfInjury.PadRight(49, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(SomeTypeOfInjury);
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
            string SomeTypeOfInjury = "";
            //pad the string with characters
            SomeTypeOfInjury = SomeTypeOfInjury.PadRight(50, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(SomeTypeOfInjury);
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
            string SomeTypeOfInjury = "";
            //pad the string with characters
            SomeTypeOfInjury = SomeTypeOfInjury.PadRight(51, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(SomeTypeOfInjury);
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
            string SomeTypeOfInjury = "";
            //pad the string with characters
            SomeTypeOfInjury = SomeTypeOfInjury.PadRight(25, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(SomeTypeOfInjury);
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
            string SomeTypeOfInjury = "";
            //pad the string with characters
            SomeTypeOfInjury = SomeTypeOfInjury.PadRight(500, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(SomeTypeOfInjury);
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
            string SomeSeverity = "";
            //invoke the method 
            Error = APersonalInjury.Valid(SomeSeverity);
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
            string SomeSeverity = "h";
            //invoke the method 
            Error = APersonalInjury.Valid(SomeSeverity);
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
            string SomeSeverity = "he";
            //invoke the method 
            Error = APersonalInjury.Valid(SomeSeverity);
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
            string SomeSeverity = "";
            //pad the string with characters
            SomeSeverity = SomeSeverity.PadRight(49, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(SomeSeverity);
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
            string SomeSeverity = "";
            //pad the string with characters
            SomeSeverity = SomeSeverity.PadRight(50, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(SomeSeverity);
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
            string SomeSeverity = "";
            //pad the string with characters
            SomeSeverity = SomeSeverity.PadRight(51, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(SomeSeverity);
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
            string SomeSeverity = "";
            //pad the string with characters
            SomeSeverity = SomeSeverity.PadRight(25, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(SomeSeverity);
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
            string SomeSeverity = "";
            //pad the string with characters
            SomeSeverity = SomeSeverity.PadRight(500, 'a');
            //invoke the method 
            Error = APersonalInjury.Valid(SomeSeverity);
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
            Decimal SomeCompensation = 0.00M;
            //convert the compensation variable to a string
            string Compensation = SomeCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(SomeCompensation);
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
            Decimal SomeCompensation = 0.01M;
            //convert the compensation variable to a string
            string Compensation = SomeCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(SomeCompensation);
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
            Decimal SomeCompensation = 0.02M;
            //convert the compensation variable to a string
            string Compensation = SomeCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(SomeCompensation);
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
            Decimal SomeCompensation = 15000.00M;
            //convert the compensation variable to a string
            string Compensation = SomeCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(SomeCompensation);
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
            Decimal SomeCompensation = 29999.00M;
            //convert the compensation variable to a string
            string Compensation = SomeCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(SomeCompensation);
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
            Decimal SomeCompensation = 30000.00M;
            //convert the compensation variable to a string
            string Compensation = SomeCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(SomeCompensation);
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
            Decimal SomeCompensation = 30000.01M;
            //convert the compensation variable to a string
            string Compensation = SomeCompensation.ToString();
            //invoke the method 
            Error = APersonalInjury.Valid(SomeCompensation);
            //test to see that the result is not ok
            Assert.AreNotEqual(Error, "");
        }

        /*
        [TestMethod]
        public void CompensationInvalidData()
        {
            //create instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //string to store error message
            String Error = "";
            //set the compensation to non money value
            String SomeCompensation = "Value entered is not money!";
            //invoke the method
            Error = APersonalInjury.Valid(SomeCompensation);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        */
    }
}
