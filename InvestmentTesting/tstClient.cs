using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InvestmentTesting
{
    [TestClass]
    public class tstClient
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
            clsClient AClient = new clsClient();
            //boolean variable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the ClientID
            if (AClient.ClientID != 1)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.Email != "sofia@gmail.com")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AccountNumberFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.AccountNumber != 10236525)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void SortCodeFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.SortCode != 235169)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void BankNameFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.BankName != "Lloyds")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void EmploymentStatusFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.EmploymentStatus != "Employed")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void AnnualIncomeFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.AnnualIncome != "21,000")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void AccontTypeFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.AccountType != "Personal Investment")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void PasswordFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.Password != "Password")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void PhoneNumberFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.PhoneNumber != "+447568730502")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void PostCodeFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.PostCode != "LE3 5QR")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void HouseNumberFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.HouseNumber != 41)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TownFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.Town != "Leicester")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void StreetNumberFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.StreetNumber != 41)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void StreetFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.Street != "Western Road")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void LastNameFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.LastName != "Kirsnerova")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void FirstNameFound()
        {
            //create instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 ClientID = 1;
            //invoke the method
            Found = AClient.Find(ClientID);

            //check the property
            if (AClient.FirstName != "Sofia")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

    }
}
