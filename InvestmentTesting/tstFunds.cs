using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InvestmentTesting
{
    [TestClass]
    public class tstFunds
    {
        //test data to pass the method 
        string Symbol = "VFEM";
        string FundName = "FTSE Emerging Markets UCITS ETF";
        string Risk = "6";
        string Change = "-0.58%";
        string Stocks = "1876";
        string MarketPrice = "£47.71";
        string Objective = "The Fund employs a passive management – or indexing – investment approach, through physical acquisition of securities, and seeks to track the performance of the FTSE Emerging Index (the “Index”). The Index is comprised of large and mid - sized company stocks in emerging markets. The Fund attempts to: 1.Track the performance of the Index by investing in a representative sample of Index constituent securities. 2.Remain fully invested except in extraordinary market, political or similar conditions.";
        //these lines of code are all for FIND METHOD with all attributes
        //it starts here
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////

        //test method for find function
        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of the class we want to create
            clsFund AFund = new clsFund();
            //boolean variable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 FundNo = 1;
            //invoke the method
            Found = AFund.Find(FundNo);

            //check the ClientID
            if (AFund.FundNo != 1)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SymbolFound()
        {
            //create instance of the class we want to create
            clsFund AFund = new clsFund();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 FundNo = 1;
            //invoke the method
            Found = AFund.Find(FundNo);

            //check the property
            if (AFund.Change != "VFEM")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void FundNameFound()
        {
            //create instance of the class we want to create
            clsFund AFund = new clsFund();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 FundNo = 1;
            //invoke the method
            Found = AFund.Find(FundNo);

            //check the property
            if (AFund.FundName != "FTSE Emerging Markets UCITS ETF")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void RiskFound()
        {
            //create instance of the class we want to create
            clsFund AFund = new clsFund();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 FundNo = 1;
            //invoke the method
            Found = AFund.Find(FundNo);

            //check the property
            if (AFund.Risk != 6)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ChangeFound()
        {
            //create instance of the class we want to create
            clsFund AFund = new clsFund();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 FundNo = 1;
            //invoke the method
            Found = AFund.Find(FundNo);

            //check the property
            if (AFund.Change != "-0.58%")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void MarketPriceFound()
        {
            //create instance of the class we want to create
            clsFund AFund = new clsFund();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 FundNo = 1;
            //invoke the method
            Found = AFund.Find(FundNo);

            //check the property
            if (AFund.MarketPrice != "£47.71")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StocksFound()
        {
            //create instance of the class we want to create
            clsFund AFund = new clsFund();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 FundNo = 1;
            //invoke the method
            Found = AFund.Find(FundNo);

            //check the property
            if (AFund.Stocks != 1876)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ObjectiveFound()
        {
            //create instance of the class we want to create
            clsFund AFund = new clsFund();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 FundNo = 1;
            //invoke the method
            Found = AFund.Find(FundNo);

            //check the property
            if (AFund.Objective != "The Fund employs a passive management – or indexing – investment approach, through physical acquisition of securities, and seeks to track the performance of the FTSE Emerging Index (the “Index”). The Index is comprised of large and mid - sized company stocks in emerging markets. The Fund attempts to: 1.Track the performance of the Index by investing in a representative sample of Index constituent securities. 2.Remain fully invested except in extraordinary market, political or similar conditions.")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        //next lines of code contain tests for validation
        //starting here
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////


        [TestMethod]
        public void ValidMehodOK()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        //test method for symbol minimum less one
        [TestMethod]
        public void SymbolMinLessOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //blank string should fail
            string Symbol = "";
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for symbol minumum value
        [TestMethod]
        public void SymbolMin()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //one character should pass
            string Symbol = "a";
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for symbol minumum value plus one
        [TestMethod]
        public void SymbolMinPlusOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //2 characters should pass
            string Symbol = "aa";
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for symbol maximum value minus one
        [TestMethod]
        public void SymbolMaxLessOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string Symbol = "";
            Symbol = Symbol.PadRight(9, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for symbol maximum value
        [TestMethod]
        public void SymbolMax()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string Symbol = "";
            Symbol = Symbol.PadRight(10, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for symbol maximum value plus one
        [TestMethod]
        public void SymbolMaxPlusOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //blank string should fail
            string Symbol = "";
            Symbol = Symbol.PadRight(11, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for symbol extreme maximum value
        [TestMethod]
        public void SymbolExtremeMax()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should fail
            string Symbol = "";
            Symbol = Symbol.PadRight(50000, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for symbol middle value
        [TestMethod]
        public void SymbolMid()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string Symbol = "";
            Symbol = Symbol.PadRight(5, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        //test method for fund name minimum less one
        [TestMethod]
        public void FundNameMinLessOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //blank string should fail
            string FundName = "";
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for fund name minumum value
        [TestMethod]
        public void FundNameMin()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //one character should pass
            string FundName = "a";
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for FundName minumum value plus one
        [TestMethod]
        public void FundNameMinPlusOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //2 characters should pass
            string FundName = "aa";
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for FundName maximum value minus one
        [TestMethod]
        public void FundNameMaxLessOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string FundName = "";
            FundName = FundName.PadRight(49, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for FundName maximum value
        [TestMethod]
        public void FundNameMax()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string FundName = "";
            FundName = FundName.PadRight(50, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for FundName maximum value plus one
        [TestMethod]
        public void FundNameMaxPlusOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //blank string should fail
            string FundName = "";
            FundName = FundName.PadRight(51, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for FundName extreme maximum value
        [TestMethod]
        public void FundNameExtremeMax()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should fail
            string FundName = "";
            FundName = FundName.PadRight(50000, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for FundName middle value
        [TestMethod]
        public void FundNameMid()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string FundName = "";
            FundName = FundName.PadRight(25, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for Objective minimum less one
        [TestMethod]
        public void ObjectiveMinLessOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //blank string should fail
            string Objective = "";
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for Objective minumum value
        [TestMethod]
        public void ObjectiveMin()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //one character should pass
            string Objective = "a";
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for Objective minumum value plus one
        [TestMethod]
        public void ObjectiveMinPlusOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //2 characters should pass
            string Objective = "aa";
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for Objective maximum value minus one
        [TestMethod]
        public void ObjectiveMaxLessOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string Objective = "";
            Objective = Objective.PadRight(499, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for Objective maximum value
        [TestMethod]
        public void ObjectiveMax()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string Objective = "";
            Objective = Objective.PadRight(500, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for Objective maximum value plus one
        [TestMethod]
        public void ObjectiveMaxPlusOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //blank string should fail
            string Objective = "";
            Objective = Objective.PadRight(501, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for Objective extreme maximum value
        [TestMethod]
        public void ObjectiveExtremeMax()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should fail
            string Objective = "";
            Objective = Objective.PadRight(50000, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for Objective middle value
        [TestMethod]
        public void ObjectiveMid()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string Objective = "";
            Objective = Objective.PadRight(250, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        //test method for Change minimum less one
        [TestMethod]
        public void ChangeMinLessOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //blank string should fail
            string Change = "";
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for Change minumum value
        [TestMethod]
        public void ChangeMin()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //one character should pass
            string Change = "a";
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for Change minumum value plus one
        [TestMethod]
        public void ChangeMinPlusOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //2 characters should pass
            string Change = "aa";
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for Change maximum value minus one
        [TestMethod]
        public void ChangeMaxLessOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string Change = "";
            Objective = Change.PadRight(9, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for Change maximum value
        [TestMethod]
        public void ChangeMax()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string Change = "";
            Change = Change.PadRight(10, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for Change maximum value plus one
        [TestMethod]
        public void ChangeMaxPlusOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //blank string should fail
            string Change = "";
            Change = Change.PadRight(11, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for Change extreme maximum value
        [TestMethod]
        public void ChangeExtremeMax()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should fail
            string Change = "";
            Change = Change.PadRight(50000, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for Change middle value
        [TestMethod]
        public void ChangeMid()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            string Change = "";
            Change = Change.PadRight(5, 'a');
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for Risk data value
        [TestMethod]
        public void RiskInvalidData()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //set the date added to non date value
            String Risk = "This is not a number!";
            //invoke the method
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //test method for risk value
        [TestMethod]
        public void RiskMin()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //1 should pass
            Int32 TestValue;
            TestValue = 1;
            String Risk = TestValue.ToString();
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for minimum risk value
        [TestMethod]
        public void RiskMinLessOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //0 should fail
            Int32 TestValue;
            TestValue = 0;
            String Risk = TestValue.ToString();
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for middle risk value
        [TestMethod]
        public void RiskMid()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            Int32 TestValue;
            TestValue = 3;
            String Risk = TestValue.ToString();
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for maximum risk value
        [TestMethod]
        public void RiskMax()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should pass
            Int32 TestValue;
            TestValue = 7;
            String Risk = TestValue.ToString();
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for maximum risk value plus one
        [TestMethod]
        public void RiskMaxPlusOne()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should fail
            Int32 TestValue;
            TestValue = 8;
            String Risk = TestValue.ToString();
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for extreme maximum risk value
        [TestMethod]
        public void RiskExtremeMax()
        {
            //create instance of the class
            clsFund AFund = new clsFund();
            //string to store error message
            String Error = "";
            //this should fail
            Int32 TestValue;
            TestValue = 5000000;
            String Risk = TestValue.ToString();
            Error = AFund.Valid(Symbol, FundName, Risk, Objective, Change, Stocks, MarketPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
