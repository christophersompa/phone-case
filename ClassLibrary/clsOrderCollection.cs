using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list 
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisOrder
        clsOrder mThisOrder = new clsOrder();

        //constructor for the class
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.TrackingNo = Convert.ToInt32(DB.DataTable.Rows[Index]["TrackingNo"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.TotalPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnOrder.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

        
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data 
                mOrderList = value;
            }

        }
        //public property for count 
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }

        }

        //public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            { //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("TrackingNo", mThisOrder.TrackingNo);
            DB.AddParameter("OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("ProductNo", mThisOrder.ProductNo);
            DB.AddParameter("Quantity", mThisOrder.Quantity);
            DB.AddParameter("TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("Dispatched", mThisOrder.Dispatched);
            DB.AddParameter("CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("CustomerEmail", mThisOrder.CustomerEmail);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("TrackingNo", mThisOrder.TrackingNo);
            DB.AddParameter("OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("ProductNo", mThisOrder.ProductNo);
            DB.AddParameter("Quantity", mThisOrder.Quantity);
            DB.AddParameter("TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("Dispatched", mThisOrder.Dispatched);
            DB.AddParameter("CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("CustomerEmail", mThisOrder.CustomerEmail);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblOrder_Update");

        }
        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_Delete");
        }


    }

    
}