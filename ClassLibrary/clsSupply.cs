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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the PhoneCaseId to search for 
            DB.AddParameter("@PhoneCaseId", PhoneCaseId);
            //execute the store procedure 
            DB.Execute("sproc_tblSupply_FilterByPhoneCaseId");
            //if one record is found (there should either be one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members 
                mPhoneCaseId = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneCaseId"]);
                mPhoneModel = Convert.ToString(DB.DataTable.Rows[0]["PhoneModel"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOrdered"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mAvaliableStock = Convert.ToBoolean(DB.DataTable.Rows[0]["AvaliableStock"]);
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

        public string Valid(string phoneModel, string dateOrdered, string supplierName, string price)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the Phone Model is blank
            if (phoneModel.Length == 0)
            {
                //record the error 
                Error = Error + "The Phone Model may not be blank : ";
            }
            //if the Phone Model is greater than 25 charcters 
            if (phoneModel.Length > 25)
            {
                //record the error 
                Error = Error + "The Phone Model must be less than 25 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOrdered);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the past : ";
                }

                //check to see if the date is greater than today's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date was not a valid date : ";
            }
            //if the Supplier Name is blank
            if (supplierName.Length == 0)
            {
                //record the error 
                Error = Error + "The Supplier Name may not be blank : ";
            }
            //if the Supplier Name is greater than 25 charcters 
            if (supplierName.Length > 25)
            {
                //record the error 
                Error = Error + "The Supplier Name must be less than 25 characters : ";
            }

            //if the Supplier Name is blank
            if (price.Length == 0)
            {
                //record the error 
                Error = Error + "Price may not be blank : ";
            }
            //if the Supplier Name is greater than 25 charcters 
            if (price.Length > 1000000000)
            {
                //record the error 
                Error = Error + "The Price must be less than £1 Million Pounds : ";
            }






            //return any error messages 
            return Error;

            }









        }
    }
