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
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }
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
            TestItem.PostCode = "LE2 7BU";
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
            TestStaff.PostCode = "LE2 7BU";
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
            TestItem.PostCode = "LE2 7BU";
            TestItem.StaffId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.Address = "12 Green Street";
            TestItem.DoB = DateTime.Now.Date;
            TestItem.Name = "Joe Smith";
            TestItem.PostCode = "LE2 7BU";
            TestItem.StaffId = 1;
            //set ThisStaff to test the data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.Address = "12 Green Street";
            TestItem.DoB = DateTime.Now.Date;
            TestItem.Name = "Joe Smith";
            TestItem.PostCode = "LE2 7BU";
            TestItem.StaffId = 1;
            //set ThisStaff to the test data
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.Address = "12 Green Street";
            TestItem.DoB = DateTime.Now.Date;
            TestItem.Name = "Joe Smith";
            TestItem.PostCode = "LE2 7BU";
            //set ThisAddress to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //modify the test data
            TestItem.Available = false;
            TestItem.Address = "12 Blue Road";
            TestItem.DoB = DateTime.Now.Date;
            TestItem.Name = "Smith Joe";
            TestItem.PostCode = "7BU LE2";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update teh record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }
        [TestMethod]
        public void ReportByNameMethodOK()
        {
            //create an instance of the class containing the unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the unfiltered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string
            FilteredStaff.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a name that doesnt exist
            FilteredStaff.ReportByName("xxx xxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that doesnt exist
            FilteredStaff.ReportByName("ggggg");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredStaff.StaffList[1].StaffId != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }

}
