using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        //good test 
        //create some test data to pass to the method
      
        string FirstName = "some first name";
        string Surname = "some surname";
        string Address = "some street";
        string DateOfBirth = DateTime.Now.Date.ToString();

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

        // find method

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            Int32 CustomerNo = 3;

            //invoke the method
            Found = AnCustomer.Find(CustomerNo);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void CustomerNoFound() {

            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerNo = 3;

            //invoke the method
            Found = AnCustomer.Find(CustomerNo);

            //check the customer no
            if (AnCustomer.CustomerNo != 3)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameFound()
        {

            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerNo = 3;

            //invoke the method
            Found = AnCustomer.Find(CustomerNo);

            //check the property
            if (AnCustomer.FirstName != "Richie")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the resukt of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerNo = 3;

            //invoke the method
            Found = AnCustomer.Find(CustomerNo);

            //check the property 
            if (AnCustomer.Surname != "Hampton")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the resukt of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerNo = 3;

            //invoke the method
            Found = AnCustomer.Find(CustomerNo);

            //check the property 
            if (AnCustomer.Address != "Walkers St")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerNo = 3;

            //invoke the method
            Found = AnCustomer.Find(CustomerNo);

            //check the property 
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("03/06/2007"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Over18Found()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (asssume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerNo = 3;

            //invoke the method
            Found = AnCustomer.Find(CustomerNo);

            //check the property
            if (AnCustomer.Over18 != false)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }

        //validation

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message 
            String Error = "";

            //invoke the method 
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any erroe message 
            String Error = "";

            //create some test data to pass to the method
            string FirstName = ""; //this should trigger an error

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string FirstName = "a"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string FirstName = "aa"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaa"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaa"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string FirstName = "aaaaaaaa"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaa"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');//this should fail

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //ste the date todays date
            TestDate = DateTime.Now.Date;

            //change the data to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();

            //invoke the method
            Error = AnCustomer.Valid(FirstName,Surname,Address,DateOfBirth);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //ste the date todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);

            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //ste the date todays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //ste the date todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);

            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //ste the date todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //convert the date variable to a string variable
            string DateOfBirth = "this is not a date!";

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any erroe message 
            String Error = "";

            //create some test data to pass to the method
            string Surname = ""; //this should trigger an error

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMin()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Surname = "b"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Surname = "bb"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Surname = "bbbbbbbbbbbbbbbbbbb"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMax()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Surname = "bbbbbbbbbbbbbbbbbbbb"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Surname = "bbbbbbbbbb"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Surname = "bbbbbbbbbbbbbbbbbbbbb"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to method
            string Surname = "";
            Surname = Surname.PadRight(500, 'b');//this should fail

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void AddresssMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any erroe message 
            String Error = "";

            //create some test data to pass to the method
            string Address = ""; //this should trigger an error

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Address = "c"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Address = "cc"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Address = "ccccccccccccccccccccccccccccccc"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Address = "cccccccccccccccccccccccccccccccc"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Address = "cccccccccccccccc"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Address = "ccccccccccccccccccccccccccccccccc"; //this should be ok

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to method
            string Address = "";
            Address = Address.PadRight(500, 'b');//this should fail

            //invoke the method
            Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

    }
}
