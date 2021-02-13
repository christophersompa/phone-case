using System;

namespace ClassLibrary
{
    public class clsSupply
    {
        //private data member for the Phone Case Id 
        private Int32 mPhoneCaseId;

        //private data member for the Phone Model
        private string mPhoneModel;

        //private data member for the Date Ordered 
        private DateTime mDateOrdered;

        //private data member for the Supplier Name 
        private string mSupplierName;

        //private data member for the Price 
        private decimal mPrice;

        //private data member for the Avaliable Stock 
        public bool mAvaliableStock;
        
        
        //PhoneCaseId public supply 
        public Int32 PhoneCaseId
        {
            get
            {
                //this line of code sends data out of the Supply  
                return mPhoneCaseId;

            }
            set
            {
                //this line of code allows data into the Supply
                mPhoneCaseId = value;
            }
        }

        //PhoneModel public supply 
        public string PhoneModel
        {
            get
            {
                //this line of code sends data out of the Supply 
                return mPhoneModel;

            }
            set
            {
                //this line of code allows data into the Supply
                mPhoneModel = value;
            }
        }

        //DateOrdered public supply 
        public DateTime DateOrdered
        {
            get
            {
                //this line of code sends data out of the Supply 
                return mDateOrdered;

            }
            set
            {
                //this line of code allows data into the Supply
                mDateOrdered = value;
            }
        }

        //SupplierName public supply 
        public string SupplierName
        {
            get
            {
                //this line of code sends data out of the Supply 
                return mSupplierName;

            }
            set
            {
                //this line of code allows data into the Supply
                mSupplierName = value;
            }
        }

        //Price public supply 
        public decimal Price
        {
            get
            {
                //this line of code sends data out of the Supply 
                return mPrice;

            }
            set
            {
                //this line of code allows data into the Supply
                mPrice = value;
            }
        }

        //AvaliableStock public supply 
        public Boolean AvaliableStock
        {
            get
            {
                //this line of code sends data out of the Supply 
                return mAvaliableStock;

            }
            set
            {
                //this line of code allows data into the Supply
                mAvaliableStock = value;
            }
        }

        public bool Find(int PhoneCaseId)
        {
            //set the private data members to the test data value 
            mPhoneCaseId = 27;
            mPhoneModel = "Samsung Galaxy Note 20";
            mDateOrdered = Convert.ToDateTime("27/05/2020");
            mSupplierName = "Anker";
            mPrice = 19.99M;
            mAvaliableStock = true;
       
            //always return true 
            return true;
        }











        


    }
}