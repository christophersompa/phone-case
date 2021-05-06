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

        clsOrder mThisOrder = new clsOrder();
        //public property for the order list
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

        public clsOrder ThisOrder { get; set; }
    }

    
}