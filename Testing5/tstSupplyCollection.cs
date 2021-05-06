using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]

    public class tstSupplyCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 

            clsSupplyCollection AllSupply = new clsSupplyCollection();

            //test to see that it exists 
            Assert.IsNotNull(AllSupply);
        }
        [TestMethod]
        public void SupplyOK()
        {
            //create an instance of the class we want to create

            clsSupplyCollection AllSupply = new clsSupplyCollection();

            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsSupply> TestList = new List<clsSupply>();
            //add an item to the list 
            //create the item of test data 
            clsSupply TestItem = new clsSupply
            {
                //set its properties 


                AvailableStock = true,

                PhoneCaseId = 1,
                PhoneModel = "IPhone",
                SupplierName = "Spigen",
                DateOrdered = DateTime.Now.Date,
                Price = 10
            };
            //add the item to the test list 
            TestList.Add(TestItem);
            //asign the data to the property 
            AllSupply.Supply = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllSupply.Supply, TestList);

        }


        [TestMethod]
        public void ThisSupplyOK()
        {
            //create an instance of the class we want to create 


            clsSupplyCollection AllSupply = new clsSupplyCollection();

            //create some test data to assign to the property 
            clsSupply TestSupply = new clsSupply
            {
                //set the properties of the test object 


                AvailableStock = true,

                PhoneCaseId = 1,
                PhoneModel = "IPhone",
                SupplierName = "Spigen",
                DateOrdered = DateTime.Now.Date,
                Price = 10
            };
            //Assign the data to the property 
            AllSupply.ThisSupply = TestSupply;
            //test to see that the two values are the same 
            Assert.AreEqual(AllSupply.ThisSupply, TestSupply);

        }


        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instnace of the class we want to create 


            clsSupplyCollection AllSupply = new clsSupplyCollection();

            //create some test data to assign to the supply 
            //in this case the data needs to be a list of objects 
            List<clsSupply> TestList = new List<clsSupply>();
            //add an item to the list 
            //create the item of test data 
            clsSupply TestItem = new clsSupply
            {
                //set its properties 

                AvailableStock = true,

                PhoneCaseId = 1,
                PhoneModel = "IPhone",
                SupplierName = "Spigen",
                DateOrdered = DateTime.Now.Date,
                Price = 10
            };
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllSupply.Supply = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllSupply.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 

            clsSupplyCollection AllSupply = new clsSupplyCollection();

            //create the item of test data 
            clsSupply TestItem = new clsSupply();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 

            TestItem.AvailableStock = true;
            TestItem.PhoneCaseId = 1;
            TestItem.PhoneModel = "IPhone";
            TestItem.SupplierName = "Spigen";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Price = 10;
            //set ThisSupply to the test data 
            AllSupply.ThisSupply = TestItem;
            //add the record 
            PrimaryKey = AllSupply.Add();
            //set the primary key to the test data 
            TestItem.PhoneCaseId = PrimaryKey;
            //find the record 
            AllSupply.ThisSupply.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllSupply.ThisSupply, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 

            clsSupplyCollection AllSupply = new clsSupplyCollection();

            //create the item of test data 
            clsSupply TestItem = new clsSupply();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 

            TestItem.AvailableStock = true;
            TestItem.PhoneCaseId = 1;
            TestItem.PhoneModel = "IPhone";
            TestItem.SupplierName = "Spigen";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Price = 10;
            //set ThisSupply to the test data 
            AllSupply.ThisSupply = TestItem;
            //add the record 
            PrimaryKey = AllSupply.Add();
            //set the primary key of the test data 
            TestItem.PhoneCaseId = PrimaryKey;
            //find the record 
            AllSupply.ThisSupply.Find(PrimaryKey);
            //delete the record 
            AllSupply.Delete();
            //now find the record 
            Boolean Found = AllSupply.ThisSupply.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);

        }

        [TestMethod]

        public void ReportBySupplierNameMethodOK()
        {
            //create an instance of the class containing unfiletered results

            clsSupplyCollection AllSupply = new clsSupplyCollection();
            //create an instance of filtered data 
            clsSupplyCollection FilteredSupply = new clsSupplyCollection();
            //apply a blank string (should return all records);
            FilteredSupply.ReportBySupplierName("");
            //test to see that the two value are the same 
            Assert.AreEqual(AllSupply.Count, FilteredSupply.Count);
        }

    }


}
