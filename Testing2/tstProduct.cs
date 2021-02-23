using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstProduct
    {
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
            Int32 TestData = 1111;
            AnProduct.ProductId = TestData;
            Assert.AreEqual(AnProduct.ProductId, TestData);
        }
        
        [TestMethod]
        public void SmartPhoneBrandOK()
        {
            clsProduct AnProduct = new clsProduct();
            String TestData = "Samsung";
            AnProduct.SmartPhoneBrand = TestData;
            Assert.AreEqual(AnProduct.SmartPhoneBrand, TestData);
        }

        [TestMethod]
        public void SmartPhoneModelOK()
        {
            clsProduct AnProduct = new clsProduct();
            String TestData = "Galaxy Note 10";
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
            decimal TestData = 15.35M;
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
            Int32 TestData = 20;
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
            Int32 ProductId = 1111;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.ProductId != 1111)
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
            Int32 ProductId = 1111;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.SmartPhoneBrand != "Samsung")
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
            Int32 ProductId = 1111;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.SmartPhoneModel != "Galaxy Note 10 plus")
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
            Int32 ProductId = 1111;
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
            Int32 ProductId = 1111;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.Price != 15.35M)
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
            Int32 ProductId = 1111;
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
            Int32 ProductId = 1111;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.ReOrderLevel != 20)
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
            Int32 ProductId = 1111;
            Found = AnProduct.Find(ProductId);
            if (AnProduct.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
