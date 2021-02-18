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
            Int32 TestData = 00001;
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
           

    }
}
