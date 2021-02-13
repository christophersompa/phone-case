using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstSupply
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //test to see that it exists 
            Assert.IsNotNull(AnSupply);
        }

        [TestMethod]
        public void AvaliableStockOK()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //create test data to assign to the Supply
            Boolean TestData = true;
            //assign the data to the Supply 
            AnSupply.AvaliableStock = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupply.AvaliableStock, TestData);
        }

        [TestMethod]
        public void DateOrderedOK()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //create some test data to assign to the Supply 
            DateTime TestData = DateTime.Now.Date;
            //asign data to the Supply 
            AnSupply.DateOrdered = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupply.DateOrdered, TestData);
        }

        [TestMethod]
        public void PhoneCaseIdOK()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //create some test data to assign to the Supply 
            Int32 TestData = 69420;
            //assign the data to the Supply 
            AnSupply.PhoneCaseId = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupply.PhoneCaseId, TestData);
        }

        [TestMethod]
        public void PhoneModelOK()
        {
            //create an instance of the class we want to create
            clsSupply AnSupply = new clsSupply();
            //create some test data to assign to the Supply 
            string TestData = "IPhone 12 Pro Max";
            //assign the data to the Supply 
            AnSupply.PhoneModel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupply.PhoneModel, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //create some test data to assign to the Supply 
            decimal TestData = 14.99M;
            //assign the data to the Supply 
            AnSupply.Price = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupply.Price, TestData);

        }

        [TestMethod]
        public void SupplierNameOK()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //create some test data to assign to the Supply 
            string TestData = "Otterbox";
            //assign the data to the Supply
            AnSupply.SupplierName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupply.SupplierName, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 PhoneCaseId = 27;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPhoneCaseIdFound()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneCaseId = 27;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the Phone Case Id 
            if (AnSupply.PhoneCaseId != 27)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPhoneModelFound()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneCaseId = 27;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the supply 
            if (AnSupply.PhoneModel != "Samsung Galaxy Note 20")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateOrderedFound()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneCaseId = 27;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the supply 
            if (AnSupply.DateOrdered != Convert.ToDateTime("27/05/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneCaseId = 27;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the supply 
            if (AnSupply.SupplierName != "Anker")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneCaseId = 27;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the supply 
            if (AnSupply.Price != 19.99M)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvaliableStockFound()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneCaseId = 27;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the supply 
            if (AnSupply.AvaliableStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

    }
}
