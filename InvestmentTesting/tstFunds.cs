using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InvestmentTesting
{
    [TestClass]
    public class tstFunds
    {
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
    }
}
