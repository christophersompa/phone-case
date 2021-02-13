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
            AnSupply.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupply.Active, TestData);
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
    }
}
