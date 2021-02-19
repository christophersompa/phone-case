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
            Int32 TestData = 1234;
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


        [TestMethod]
        public void FindMethodOK() 
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 1234;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1234;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.StaffId != 1234)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1234;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Name != "John Smith")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result fo the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1234;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.PostCode != "LE1 7XY")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAdressFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1234;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Address != "21 Green Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDoBFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1234;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.DoB != Convert.ToDateTime("12/03/1995"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailabeFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1234;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
