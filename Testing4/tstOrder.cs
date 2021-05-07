using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to pass to the method
        string OrderNo = "5";
        string CustomerName = "Test Name";
        string CustomerEmail = "testemail@hotmail.com";
        string ProductNo = "8";
        string Quantity = "1";
        string OrderDate = DateTime.Now.Date.ToString();
        string TrackingNo = "24";
        string TotalPrice = "15";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exist
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void DispatchedPropertOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Dispatched = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.Dispatched, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 5;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }
        [TestMethod]
        public void TrackingNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 24;
            //assign the data to the property
            AnOrder.TrackingNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TrackingNo, TestData);
        }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Test Name";
            //assign the data to the property
            AnOrder.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerName, TestData);
        }
        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "testemail@hotmail.com";
            //assign the data to the property
            AnOrder.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerEmail, TestData);
        }
        [TestMethod]
        public void ProductNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 8;
            //assign the data to the property
            AnOrder.ProductNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ProductNo, TestData);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }
        [TestMethod]
        public void TotalPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 15;
            //assign the data to the property
            AnOrder.TotalPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no 
            if (AnOrder.OrderNo != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductNoFound()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no 
            if (AnOrder.ProductNo != 8)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no 
            if (AnOrder.Quantity != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no 
            if (AnOrder.TotalPrice != 15)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTrackingNoFound()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the tracking no 
            if (AnOrder.TrackingNo != 24)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDispatchedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.Dispatched != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance if the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo,TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo,TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "";
            OrderNo = OrderNo.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;           
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");        
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
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
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddDays(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerName = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerEmail = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "";
            ProductNo = ProductNo.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TrackingNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNo = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TrackingNoMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNo = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrackingNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNo = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrackingNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNo = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TrackingNoMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrackingNoMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNo = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TrackingNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNo = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TrackingNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNo = "";
            TrackingNo = TrackingNo.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aaaaaa"; //this should be fail
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNo = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNo = "aaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, OrderDate, TrackingNo, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }








    }
}



    

