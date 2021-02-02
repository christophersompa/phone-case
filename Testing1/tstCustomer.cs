using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instnace of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            
            //create some test data to assign to the property
            Int32 TestData = 1;
            
            //assign the data to the property
            AnCustomer.CustomerNo = TestData;
            
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerNo, TestData);
        }
  
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            
            //create some test data to assign to the property
            string TestData = "Ava";
            
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void SurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //create some test data to assign to the property
            string TestData = "Smith";

            //assign the data to the property
            AnCustomer.Surname = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Surname, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            
            //create some test data to assign to the property
            string TestData = "Court Crown Street";
            
            //assign the data to the property
            AnCustomer.Address = TestData;
            
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //create some test data to assign to property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property 
            AnCustomer.DateOfBirth = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void Over18PropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();

            //create some test data to assign to property
            Boolean TestData = true;

            //assign the data to the property
            AnCustomer.Over18 = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Over18, TestData);
        }
    }
}
