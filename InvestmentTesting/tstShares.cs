using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InvestmentTesting
{
    [TestClass]
    public class tstShares
    {

        string Symbol = "VFEM";
        string Shares = "5";
        string OrderType = "Limit";
        string ClientID = "1";
        string FundID = "1";
        string Duration = "07/07/2022";

        //test method for find function
        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of the class we want to create
            clsShare APurchase = new clsShare();
            //boolean variable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 PurchaseNo = 1;
            //invoke the method
            Found = APurchase.Find(PurchaseNo);

            //check the ClientID
            if (APurchase.PurchaseNo != 1)
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
            clsShare APurchase = new clsShare();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 PurchaseNo = 1;
            //invoke the method
            Found = APurchase.Find(PurchaseNo);

            //check the property
            if (APurchase.Symbol != "VFEM")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ClientIDFound()
        {
            //create instance of the class we want to create
            clsShare APurchase = new clsShare();
            //boolean variable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 PurchaseNo = 1;
            //invoke the method
            Found = APurchase.Find(PurchaseNo);

            //check the property
            if (APurchase.ClientID != 1)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void FundIDFound()
        {
            //create instance of the class we want to create
            clsShare APurchase = new clsShare();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 PurchaseNo = 1;
            //invoke the method
            Found = APurchase.Find(PurchaseNo);

            //check the property
            if (APurchase.FundID != 1)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void OrderTypeFound()
        {
            //create instance of the class we want to create
            clsShare APurchase = new clsShare();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 PurchaseNo = 1;
            //invoke the method
            Found = APurchase.Find(PurchaseNo);

            //check the property
            if (APurchase.OrderType != "Limit")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void SharesFound()
        {
            //create instance of the class we want to create
            clsShare APurchase = new clsShare();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 PurchaseNo = 1;
            //invoke the method
            Found = APurchase.Find(PurchaseNo);

            //check the property
            if (APurchase.Shares != 5)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void DurationFound()
        {
            //create instance of the class we want to create
            clsShare APurchase = new clsShare();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 PurchaseNo = 1;
            //invoke the method
            Found = APurchase.Find(PurchaseNo);

            //check the property
            if (APurchase.Duration != Convert.ToDateTime("07/07/2022"))
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
            clsShare APurchase = new clsShare();
            //string to store error message
            String Error = "";
            //invoke the method
            Error = APurchase.Valid(ClientID, Shares, OrderType, Duration, Symbol, FundID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
    }
}
