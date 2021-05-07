using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;



namespace Testing5
{
    public class clsSupplyCollection
    {
        //private data member for the list 
        List<clsSupply> mSupplyList = new List<clsSupply>();
        //private data member thisSupply 
        clsSupply mThisSupply = new clsSupply();

        //private data member for the list 
        List<clsSupply> mSupply = new List<clsSupply>();

        //public property for the supply 
        public List<clsSupply> Supply
        {
            get
            {
                //return the private data
                return mSupply;
            }
            set
            {
                //set the private data 
                mSupply = value;
            }
        }

        public clsSupply ThisSupply
        {
            get
            {
                //return the private data 
                return mThisSupply;
            }
            set
            {
                //set the private data 
                mThisSupply = value;
            }
        }


        //public property for count 
        public int Count
        {
            get
            {
                //return the count of the list 
                return mSupply.Count;

            }
            set
            {

                //worry about it later 
            }


        }

        public object SupplierList { get; set; }




        //constructor for the class
        public clsSupplyCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblSupply_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisAddress
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@PhoneModel", mThisSupply.PhoneModel);
            DB.AddParameter("@SupplierName", mThisSupply.SupplierName);
            DB.AddParameter("@DateOrdered", mThisSupply.DateOrdered);
            DB.AddParameter("@Price", mThisSupply.Price);
            DB.AddParameter("@AvailableStock", mThisSupply.AvailableStock);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblSupply_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisSupply 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@PhoneCaseId", mThisSupply.PhoneCaseId);
            //execute the stored procedure 
            DB.Execute("sproc_tblSupply_Delete");
        }

        public void ReportBySupplierName(string SupplierName)
        {
            //filters the record based on a full or partial supplier name 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Supplier Name to the databse 
            DB.AddParameter("@SupplierName", SupplierName);
            //execute the stored procedure 
            DB.Execute("sproc_tblSupply_FilterBySupplierName");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the paramter DB
            //var for the index 
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount;
            //get the count of records 
            RecordCount = DB.Count;
            //clear the private array list 
            mSupplyList = new List<clsSupply>();
            //while there are records to process 
            while (Index < RecordCount)
            {
                //create a blank supply 
                clsSupply AnSupply = new clsSupply
                {
                    //read in the fields from the current record 
                    AvailableStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["AvailableStock"]),
                    PhoneCaseId = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneCaseID"]),
                    PhoneModel = Convert.ToString(DB.DataTable.Rows[Index]["PhoneModel"]),
                    SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]),
                    DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOrdered"]),
                    Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"])
                };
                //add the record to the private data member 
                mSupplyList.Add(AnSupply);
                //point at the next record 
                Index++;
            }
        }
    
        [TestMethod]
        public void ReportBySupplierNameTestDataFound()
        {
            //create an instance of the filtered data 
            clsSupplyCollection FilteredSupply = new clsSupplyCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply a supplier name that doesn't exist 
            FilteredSupply.ReportBySupplierName("yyyyyy");
            //check that the correct number of records are found 
            if (FilteredSupply.Count == 2)
            {
                //check that the first record is ID 36 
                if (FilteredSupply.mSupplyList[0].PhoneCaseId != 36)
                {
                    OK = false;
                }
                //check that the first record is ID 37 
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