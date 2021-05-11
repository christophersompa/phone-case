using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstProduct
    {
        //good test data
        //create some tests to pass to the method
        string ProductName = "Black Case";
        string SmartPhoneBrand = "Apple";
        string SmartPhoneModel = "iPhone 12 Pro";
        string Price = "16";
        string StockLevel = "128";
        string ReOrderLevel = "12";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AnProduct = new clsProduct();
            Assert.IsNotNull(AnProduct);
        }

        [TestMethod]
        public void ProductIdOK()
        {
            clsProduct AnProduct = new clsProduct();
            Int32 TestData = 1;
            AnProduct.ProductId = TestData;
            Assert.AreEqual(AnProduct.ProductId, TestData);
        }
        
        [TestMethod]
        public void SmartPhoneBrandOK()
        {
            clsProduct AnProduct = new clsProduct();
            String TestData = "Apple";
            AnProduct.SmartPhoneBrand = TestData;
            Assert.AreEqual(AnProduct.SmartPhoneBrand, TestData);
        }

        [TestMethod]
        public void SmartPhoneModelOK()
        {
            clsProduct AnProduct = new clsProduct();
            String TestData = "iPhone 12 Pro";
            AnProduct.SmartPhoneModel = TestData;
            Assert.AreEqual(AnProduct.SmartPhoneBrand, TestData);
        }

        [TestMethod]
        public void ProductNameOK()
        {
            clsProduct AnProduct = new clsProduct();
            String TestData = "Black Case";
            AnProduct.ProductName = TestData;
            Assert.AreEqual(AnProduct.ProductName, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsProduct AnProduct = new clsProduct();
            decimal TestData = 16M;
            AnProduct.Price = TestData;
            Assert.AreEqual(AnProduct.Price, TestData);
        }

        [TestMethod]
        public void StockLevelOK()
        {
            clsProduct AnProduct = new clsProduct();
            Int32 TestData = 128;
            AnProduct.StockLevel = TestData;
            Assert.AreEqual(AnProduct.StockLevel, TestData);
        }

        [TestMethod]
        public void ReOrderLevelOK()
        {
            clsProduct AnProduct = new clsProduct();
            Int32 TestData = 12;
            AnProduct.ReOrderLevel = TestData;
            Assert.AreEqual(AnProduct.ReOrderLevel, TestData);
        }

        [TestMethod]
        public void ActiveOK()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean TestData = true;
            AnProduct.Active = TestData;
            Assert.AreEqual(AnProduct.Active, TestData);
        }

        [TestMethod]
        public void DateAddedOK()
        {
            clsProduct AnProduct = new clsProduct();
            DateTime TestData = 01 / 01 / 2021;
            AnProduct.DateAdded = TestData;
            Assert.AreEqual(AnProduct.DateAdded, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Int32 ProductId = 1111;
            Found = AnProduct.Find(ProductId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.ProductId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSmartPhoneBrandFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.SmartPhoneBrand != "Apple")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSmartPhoneModelFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.SmartPhoneModel != "iPhone 12 Pro")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.ProductName != "Black Case")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.Price != 16M)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockLevelFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.StockLevel != 128)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReOrderLevelFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.ReOrderLevel != 12)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateaddedFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.DateAdded != true);
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string ProductName = ""; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMIn()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string ProductName = "Blue Case"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string ProductName = "Black Case"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string ProductName = "Black Case"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string ProductName = "Black Case a"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneBrandExtremeMIn()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneBrand = "Apple"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneBrandMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneBrand = "Appl"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneBrandMin()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneBrand = "Apple"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneBrandMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneBrand = "Applea"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneBrandMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneBrand = "Applea"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneBrandMax()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneBrand = "Samsung"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneBrandMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneBrand = "Samsunga"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneModelMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneModel = "Galaxy S"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneModelMin()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneModel = "iPhone 12"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneModelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneModel = "Galaxy s10e"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneModelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneModel = "iPhone 12 Pro"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneModelMax()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneModel = "Galaxy S10 Plus"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SmartPhoneModelMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string SmartPhoneModel = "Galaxy S21 Plus m"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string Price = "1"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Price = "16"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Price = "16"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string Price = "166"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockLevelMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string StockLevel = "11"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockLevelMin()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StockLevel = "12"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockLevelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StockLevel = "13"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockLevelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StockLevel = "127"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockLevelMax()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StockLevel = "128"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockLevelMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string StockLevel = "129"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReOrderLevelMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string ReOrderLevel = "11"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReorderLevelMin()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string ReOrderLevel = "12"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReOrderLevelMax()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string ReOrderLevel = "12"; //this should be ok

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReOrderLevelMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method
            string ReOrderLevel = "13"; //this should trigger an error

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message 
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);

            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);

            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidTestData()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();

            //string variable to store any error message
            String Error = "";

            //convert the date variable to a string variable
            string DateAdded = "this is not a date!;

            //invoke the method
            Error = AnProduct.Valid(ProductName, SmartPhoneBrand, SmartPhoneModel, Price, StockLevel, ReOrderLevel, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }

    
 
}