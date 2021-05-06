﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Dispatched = true;
            TestItem.OrderNo = 5;
            TestItem.TrackingNo = 24;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductNo = 8;
            TestItem.Quantity = 1;
            TestItem.TotalPrice = 15;
            TestItem.CustomerName = "Test Name";
            TestItem.CustomerEmail = "testemail@hotmail.com";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the propeties of the test object
            TestOrder.Dispatched = true;
            TestOrder.OrderNo = 5;
            TestOrder.TrackingNo = 24;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.ProductNo = 8;
            TestOrder.Quantity = 1;
            TestOrder.TotalPrice = 15;
            TestOrder.CustomerName = "Test Name";
            TestOrder.CustomerEmail = "testemail@hotmail.com";
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list 
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Dispatched = true;
            TestItem.OrderNo = 5;
            TestItem.TrackingNo = 24;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductNo = 8;
            TestItem.Quantity = 1;
            TestItem.TotalPrice = 15;
            TestItem.CustomerName = "Test Name";
            TestItem.CustomerEmail = "testemail@hotmail.com";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }


    }
}