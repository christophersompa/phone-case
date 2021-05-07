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
        string ProductName = " ";
        string SmartPhoneBrand = " ";
        string SmartPhoneModel = " ";
        string Price = " ";
        string StockLevel = " ";
        string ReOrderLevel = " ";
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
        }

        [TestMethod]
        public void ValidMethodOK()
        {

        }
        
    }
}