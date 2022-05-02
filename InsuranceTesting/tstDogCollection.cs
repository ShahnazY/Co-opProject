using Co_opClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassLibrary;

namespace DogTesting
{
    [TestClass]
    public class tstDogCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsDogCollection AllDogs = new clsDogCollection();
            //test to see it exists
            Assert.IsNotNull(AllDogs);
        }

        [TestMethod]
        public void InsurancesListOK()
        {
            //create an instance of the class
            clsDogCollection AllDogs = new clsDogCollection();
            //create some test data to assign to the property
            List<clsDog> TestList = new List<clsDog>();
            //create the item of test data
            clsDog TestItem = new clsDog();
            //set its properties
            TestItem.DogID = 2;
            TestItem.Age = 2;
            TestItem.Breed = "Bulldog";
            TestItem.Gender = "Male";
            TestItem.Name = "Rex";
            TestItem.Size = "Small";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllDogs.DogsList = TestList;
            //test to see it exists
            Assert.AreEqual(AllDogs.DogsList, TestList);
        }

        [TestMethod]
        public void ThisDogOK()
        {
            //create an instance of the class
            clsDogCollection AllDogs = new clsDogCollection();
            //create some test data to assign to the property
            clsDog TestDog = new clsDog();
            //set its properties
            TestDog.DogID = 2;
            TestDog.Age = 2;
            TestDog.Breed = "Bulldog";
            TestDog.Gender = "Male";
            TestDog.Name = "Rex";
            TestDog.Size = "Small";
            TestDog.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllDogs.ThisDog = TestDog;
            //test to see it exists
            Assert.AreEqual(AllDogs.ThisDog, TestDog);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsDogCollection AllDogs = new clsDogCollection();
            //create some test data to assign to the property
            List<clsDog> TestList = new List<clsDog>();
            //create the item of test data
            clsDog TestItem = new clsDog();
            //set its properties
            TestItem.DogID = 2;
            TestItem.Age = 2;
            TestItem.Breed = "Bulldog";
            TestItem.Gender = "Male";
            TestItem.Name = "Rex";
            TestItem.Size = "Small";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllDogs.DogsList = TestList;
            //test to see it exists
            Assert.AreEqual(AllDogs.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsDogCollection AllDogs = new clsDogCollection();
            //create the item of test data
            clsDog TestItem = new clsDog();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.DogID = 2;
            TestItem.Age = 2;
            TestItem.Breed = "Bulldog";
            TestItem.Gender = "Male";
            TestItem.Name = "Rex";
            TestItem.Size = "Small";
            TestItem.DateAdded = DateTime.Now.Date;
            //set Thisdog to the test data;
            AllDogs.ThisDog = TestItem;
            //add the record
            PrimaryKey = AllDogs.Add();
            //set the primary key of the test data
            TestItem.DogID = PrimaryKey;
            //find the record
            AllDogs.ThisDog.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllDogs.ThisDog, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsDogCollection AllDogs = new clsDogCollection();
            //create the item of test data
            clsDog TestItem = new clsDog();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.DogID = 2;
            TestItem.Age = 2;
            TestItem.Breed = "Bulldog";
            TestItem.Gender = "Male";
            TestItem.Name = "Rex";
            TestItem.Size = "Small";
            TestItem.DateAdded = DateTime.Now.Date;
            //set Thisdog to the test data;
            AllDogs.ThisDog = TestItem;
            //add the record
            PrimaryKey = AllDogs.Add();
            //set the primary key of the test data
            TestItem.DogID = PrimaryKey;
            //find the record
            AllDogs.ThisDog.Find(PrimaryKey);
            //delete the record
            AllDogs.Delete();
            //now find the record
            Boolean Found = AllDogs.ThisDog.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsDogCollection AllDogs = new clsDogCollection();
            //create the item of test data
            clsDog TestItem = new clsDog();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Age = 2;
            TestItem.Breed = "Bulldog";
            TestItem.Gender = "Male";
            TestItem.Name = "Rex";
            TestItem.Size = "Small";
            TestItem.DateAdded = DateTime.Now.Date;
            //set Thisdog to the test data;
            AllDogs.ThisDog = TestItem;
            //add the record
            PrimaryKey = AllDogs.Add();
            //set the primary key of the test data
            TestItem.DogID = PrimaryKey;
            //modify the record
            TestItem.Age = 7;
            TestItem.Breed = "Mixed Breed";
            TestItem.Gender = "Female";
            TestItem.Name = "Lilly";
            TestItem.Size = "Extra Large";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on new data
            AllDogs.ThisDog = TestItem;
            //update the record
            AllDogs.Update();
            //find the record
            AllDogs.ThisDog.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllDogs.ThisDog, TestItem);
        }
    }
}
