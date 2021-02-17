using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }
        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            AnStaff.Available = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.Available, TestData);
        }
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AnStaff.DoB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DoB, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Joe Smith";
            //assign the data to the property
            AnStaff.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Name, TestData);
        }
        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LE2 7BU";
            //assign the data to the property
            AnStaff.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.PostCode, TestData);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "12 Green Street";
            //assign the data to the property
            AnStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Address, TestData);
        }
    }
}
