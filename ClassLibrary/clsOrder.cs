using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsOrder
    {

        //private data member for dispatched
        private Boolean mDispatched;
        //public property for dispatched
        public bool Dispatched
        {
            get
            {
                //return the private data
                return mDispatched;
            }
            set
            {
                //set the private data
                mDispatched = value;
            }
        }

        //private date added data member
        private DateTime mOrderDate;
        //public property for date added
        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mOrderDate;
            }
            set
            {
                //set the private data
                mOrderDate = value;
            }
        }

        //private data member for the OrderNo property
        private Int32 mOrderNo;
        //public property for the order number
        public int OrderNo
        {
            get
            {
                //return the private data
                return mOrderNo;
            }
            set
            {
                //set the value of the private data member
                mOrderNo = value;
            }
        }

        //private data member for tracking no
        private Int32 mTrackingNo;
        //public property for tracking no
        public int TrackingNo
        {
            get
            {
                //return the private data
                return mTrackingNo;
            }
            set
            {
                //set the private data
                mTrackingNo = value;
            }
        }

        //private data member for CustomerName
        private string mCustomerName;
        //public property for custmomer name
        public string CustomerName
        {
            get
            {
                //return private data
                return mCustomerName;
            }
            set
            {
                //set the private data
                mCustomerName = value;
            }
        }

        //private data member for customer email
        private string mCustomerEmail;
        //public property for customer email
        public string CustomerEmail
        {
            get
            {
                //return the private data
                return mCustomerEmail;
            }
            set
            {
                //set the private data
                mCustomerEmail = value;
            }
        }

        //private data member for product number
        private Int32 mProductNo;
        //public data member for product number
        public int ProductNo
        {
            get
            {
                //return the private data
                return mProductNo;
            }
            set
            {
                //set the private data
                mProductNo = value;
            }
        }

        //private data member for quantity
        private Int32 mQuantity;
        //public data member for Quantity
        public int Quantity
        {
            get
            {
                //return the private data
                return mQuantity;
            }
            set
            {
                //set the private data
                mQuantity = value;
            }
        }
        //private data member for TotalPrice
        private Int32 mTotalPrice;
        //public data member for total price
        public int TotalPrice
        {
            get
            {
                //return the private data
                return mTotalPrice;
            }
            set
            {
                //set the private data
                mTotalPrice = value;
            }
        }



        public bool Find(int OrderNo)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mTotalPrice = Convert.ToInt32(DB.DataTable.Rows[0]["TotalPrice"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                //return that everything worked OK                      
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
} 
    

