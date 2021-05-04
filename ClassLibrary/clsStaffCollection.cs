using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //constructor for the class
        public clsStaffCollection()
        {
            //create the items of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Available = true;
            TestItem.Address = "12 Green Street";
            TestItem.DoB = DateTime.Now.Date;
            TestItem.Name = "Joe Smith";
            TestItem.PostCode = "Joe Smith";
            TestItem.StaffId = 1;
            //add the item to the test list
            mStaffList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsStaff();
            //set its properties
            TestItem.Available = true;
            TestItem.Address = "12 Green Street";
            TestItem.DoB = DateTime.Now.Date;
            TestItem.Name = "Joe Smith";
            TestItem.PostCode = "Joe Smith";
            TestItem.StaffId = 1;
            //add the item to the test list
            mStaffList.Add(TestItem);
        }
        //public property for th address list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public int Count {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //worry about this later
            }
        }
        public clsStaff ThisStaff { get; set; }
    }
}