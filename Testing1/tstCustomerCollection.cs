using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic; 

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data  to assign to the proptery 
            // in the case the data needs to be a  list objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the item of test data
            clsCustomer TestItem = new clsCustomer(); ;
            //set its properties 
            TestItem.Over18 = true;
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "some first name";
            TestItem.Surname = "some surname";
            TestItem.Address = "some address";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties 
            TestItem.Over18 = true;
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "some first name";
            TestItem.Surname = "some surname";
            TestItem.Address = "some address";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object 
            TestCustomer.Over18 = true;
            TestCustomer.CustomerNo = 1;
            TestCustomer.FirstName = "some first name";
            TestCustomer.Surname = "some surname";
            TestCustomer.Address = "some address";
            TestCustomer.DateAdded = DateTime.Now.Date;
            //assign the data to the proprerty 
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Over18 = true;
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "some firstname";
            TestItem.Surname = "some surname";
            TestItem.Address = "some address";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOk() {

            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data 
            clsCustomer TestItem = new clsCustomer();
            //var to store primarykey 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Over18 = true;
            TestItem.FirstName = "some firstname";
            TestItem.Surname = "some surname";
            TestItem.Address = "some address";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //modify the test data
            TestItem.Over18 = false;
            TestItem.FirstName = "some first name2";
            TestItem.Surname = "another surname";
            TestItem.Address = "another addres";
            TestItem.DateAdded = DateTime.Now.Date;
            //set record based on the new test data 
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustiomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primaryy key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Over18 = true;
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "some first name";
            TestItem.Surname = "some surname";
            TestItem.Address = "some address";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;
            //add record
            PrimaryKey = AllCustomers.Add();
            // set the primary key of the test dat a
            TestItem.CustomerNo = PrimaryKey;
            //delete the record 
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportBySurnameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllSurnames = new clsCustomerCollection();
            //create an instance of the filtered data 
            clsCustomerCollection FilteredSurnames = new clsCustomerCollection();
            //apply a blank string(should return all records);
            FilteredSurnames.ReportBySurname("");
            //test to see that the two values are the same
            Assert.AreEqual(AllSurnames.Count, FilteredSurnames.Count);
        }

        [TestMethod]
        public void ReportBySurnameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredSurnames = new clsCustomerCollection();
            //apply a surname that doesnt exist 
            FilteredSurnames.ReportBySurname("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredSurnames.Count);
        }

        [TestMethod]
        public void ReportBySurnameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredSurname = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a surname that doesnt exist 
            FilteredSurname.ReportBySurname("yyy yyy");
            //check that the correct number of records are found
            if (FilteredSurname.Count == 2)
            {
                //check that the first record is ID 23
                if (FilteredSurname.CustomerList[0].CustomerNo != 1044)
                {
                    OK = false;
                }
                //check tha the first record is ID 24 
                if (FilteredSurname.CustomerList[1].CustomerNo != 1045)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
