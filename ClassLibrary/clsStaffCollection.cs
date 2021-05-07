using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();

        //constructor for the class
        public clsStaffCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        //constructor for the class
        /*public clsStaffCollection()
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
        */
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
        public clsStaff ThisStaff
        {
            get
            {
                //return the privare data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Available", mThisStaff.Available);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@DoB", mThisStaff.DoB);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            //execute the query returning the primary key
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Available", mThisStaff.Available);
            DB.AddParameter("@DoB", mThisStaff.DoB);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByName(string Name)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Name parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record
                AnStaff.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.DoB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DoB"]);
                AnStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                AnStaff.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the recorsd to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }

        }
    }
}