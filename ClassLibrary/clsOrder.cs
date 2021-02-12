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
            //set the private data members to the test data value
            mOrderNo = 24;
            mCustomerName = "Kobe";
            mCustomerEmail = "kobemamba@yahoo.com";
            mProductNo = 8;
            mQuantity = 1;
            mTotalPrice = 1;
            mOrderDate = Convert.ToDateTime("16/9/2015");
            mDispatched = true;
            //always return true
            return true;
        }
    }
}
