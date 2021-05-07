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
                mTrackingNo = Convert.ToInt32(DB.DataTable.Rows[0]["TrackingNo"]);
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
        public string Valid(string orderNo, string customerName, string customerEmail, string productNo, string quantity, string orderDate, string trackingNo, string totalPrice)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store data values
            DateTime DateTemp;
            //if the OrderNo is blank
            if (orderNo.Length == 0)
            {
                // record the error
                Error = Error + "The order no may not be blank : ";
            }
            //if the order no is greater than 6 characters
            if (orderNo.Length > 6)
            {
                //record the error
                Error = Error + "The order no must be less than 6 characters : ";
            }
            try
            {
                //copy the orderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date was not a valid date : ";
            }
            //is the customer name blank
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "the customer name may not be blank :";
            }
            //if the customer name is too long
            if (customerName.Length > 50)
            {
                //record the error 
                Error = Error + "The customer name must be less than 50 characters : ";
            }
            //is the customer email blank
            if (customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "the customer email may not be blank :";
            }
            //if the customer email is too long
            if (customerEmail.Length > 50)
            {
                //record the error 
                Error = Error + "The customer email must be less than 50 characters : ";
            }
            //if the ProductNo is blank
            if (productNo.Length == 0)
            {
                // record the error
                Error = Error + "The product no may not be blank : ";
            }
            //if the product no is greater than 6 characters
            if (productNo.Length > 6)
            {
                //record the error
                Error = Error + "The product no must be less than 6 characters : ";
            }
            //if the TrackingNo is blank
            if (trackingNo.Length == 0)
            {
                // record the error
                Error = Error + "The tracking no may not be blank : ";
            }
            //if the tracking no is greater than 6 characters
            if (trackingNo.Length > 6)
            {
                //record the error
                Error = Error + "The tracking no must be less than 6 characters : ";
            }
            //if the Quantity is blank
            if (quantity.Length == 0)
            {
                // record the error
                Error = Error + "The tracking no may not be blank : ";
            }
            //if the quantity is greater than 3 characters
            if (quantity.Length > 3)
            {
                //record the error
                Error = Error + "The quantity must be less than 3 characters : ";
            }
            //if the TotalPrice is blank
            if (totalPrice.Length == 0)
            {
                // record the error
                Error = Error + "The total price no may not be blank : ";
            }
            //if the tracking no is greater than 6 characters
            if (totalPrice.Length > 4)
            {
                //record the error
                Error = Error + "The total price must be less than 6 characters : ";
            }
            //return any error messages
            return Error; 
        }

    }
}
    

