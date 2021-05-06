using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{

    [TestClass]
    public class tstSupply
    {
        //good test data 
        //create some test data to pass the method 
        string PhoneModel = "IPhone";
        string DateOrdered = DateTime.Now.Date.ToString();
        string SupplierName = "Anker";
        string Price = "14.99";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //test to see that it exists 
            Assert.IsNotNull(AnSupply);
        }

        [TestMethod]
        public void AvailableStockOK()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //create test data to assign to the Supply
            Boolean TestData = true;
            //assign the data to the Supply 
            AnSupply.AvailableStock = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupply.AvailableStock, TestData);
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
            Int32 PhoneCaseId = 1;
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
            Int32 PhoneCaseId = 1;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the Phone Case Id 
            if (AnSupply.PhoneCaseId != 1)
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
            Int32 PhoneCaseId = 1;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the supply 
            if (AnSupply.PhoneModel != "IPhoneXS")
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
            Int32 PhoneCaseId = 1;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the supply 
            if (AnSupply.DateOrdered != Convert.ToDateTime("01/03/2021"))
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
            Int32 PhoneCaseId = 1;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the supply 
            if (AnSupply.SupplierName != "Spigen")
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
            Int32 PhoneCaseId = 1;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the supply 
            if (AnSupply.Price != 15)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableStockFound()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneCaseId = 1;
            //invoke the method 
            Found = AnSupply.Find(PhoneCaseId);
            //check the supply 
            if (AnSupply.AvailableStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);

        }


        [TestMethod]
        public void PhoneModelMinLessOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string PhoneModel = ""; //this should trigger an error
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneModelMin()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string PhoneModel = "a"; //this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneModelMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string PhoneModel = "aa"; //this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneModelMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string PhoneModel = "";
            PhoneModel = PhoneModel.PadRight(24, 'a'); //this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneModelMax()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string PhoneModel = "";
            PhoneModel = PhoneModel.PadRight(25, 'a');//this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneModelMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string PhoneModel = "";
            PhoneModel = PhoneModel.PadRight(26, 'a');//this should trigger an error
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneModelExtremeMax()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string PhoneModel = "";
            PhoneModel = PhoneModel.PadRight(500, 'a');//this should trigger an error
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void DateOrderedExtremeMin()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void DateOrderedMinLessOne()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DateOrderedMin()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DateOrderedMinPlusOne()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void DateOrderedInvalidData()
        {
            //create an instnace of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string PhoneModel = "Samsung";
            string SupplierName = "Spigen";
            string Price = "19.99";
            //set the Date Ordered to a non date 
            string DateOrdered = "This is not a date!";
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string SupplierName = ""; //this should trigger an error
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierNameMin()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string SupplierName = "a"; //this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string SupplierName = "aa"; //this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(24, 'a'); //this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierNameMax()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(25, 'a');//this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(26, 'a');//this should trigger an error
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a');//this should trigger an error
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string Price = ""; //this should trigger an error
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string Price = "a"; //this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string Price = "aa"; //this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string price = "";
            price = price.PadRight(100000, 'a'); //this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceNameMax()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string price = "";
            price = price.PadRight(10000, 'a');//this should pass
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(10000, 'a');//this should trigger an error
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to the method 
            string price = "";
            price = price.PadRight(10000000, 'a');//this should trigger an error
            //invoke the method 
            Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }





    }
}
