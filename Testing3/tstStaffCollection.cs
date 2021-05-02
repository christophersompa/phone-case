using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
{
   
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the porperty
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create item test data
            clsStaff TestItem = new clsStaff();
            //set properties
            TestItem.Available = true;
            TestItem.Address = "12 Green Street";
            TestItem.DoB = DateTime.Now.Date;
            TestItem.Name = "Joe Smith";
            TestItem.PostCode = "Joe Smith";
            TestItem.StaffId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance fo the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set properties
            TestStaff.Available = true;
            TestStaff.Address = "12 Green Street";
            TestStaff.DoB = DateTime.Now.Date;
            TestStaff.Name = "Joe Smith";
            TestStaff.PostCode = "Joe Smith";
            TestStaff.StaffId = 1;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the porperty
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create item test data
            clsStaff TestItem = new clsStaff();
            //set properties
            TestItem.Available = true;
            TestItem.Address = "12 Green Street";
            TestItem.DoB = DateTime.Now.Date;
            TestItem.Name = "Joe Smith";
            TestItem.PostCode = "Joe Smith";
            TestItem.StaffId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
    }

}
