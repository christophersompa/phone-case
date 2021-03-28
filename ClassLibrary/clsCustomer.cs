using System;

namespace ClassLibrary
{
    public class clsCustomer
    {

        //customerNo private member varibale
        private Int32 mCustomerNo;

        //dateAdded private member variable
        private DateTime mDateAdded;

        //firstName private member variable
        private string mFirstName;

        //surname private member variable
        private string mSurname;

        //address private member variable
        private string mAddress;

        //over18 private member variable
        private bool mOver18;

        //CustomerNo public property
        public Int32 CustomerNo
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }
        }

        //FirstName public property
        public string FirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        //Surname public property
        public string Surname
        {
            get
            {
                //this line of code sends data out of the property
                return mSurname;
            }
            set
            {
                mSurname = value;
            }
        }

        //Address public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        //Over18 public property
        public bool Over18
        {
            get
            {
                //this line of code sends data out of the property
                return mOver18;
            }
            set
            {
                mOver18 = value;
            }
        }

        public bool Find(int CustomerNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerNo", CustomerNo);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");

            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //data
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18"]);
                //return that everything worked OK
                return true;
            }

            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid(string firstName, string surname, string address, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store date values
            DateTime DateTemp;

            //if the FirstName is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name cannot be blank : ";
            }

            //if the first name is greater than 16 characters
            if (firstName.Length > 16)
            {
                //record the error
                Error = Error + "The first name must be less than 17 characters :";
            }

            //if the Surname is blank
            if (surname.Length == 0)
            {
                //record the error
                Error = Error + "The surname cannot be blank : ";
            }

            //if the surname is greater than 20 characters
            if (surname.Length > 20)
            {
                //record the error
                Error = Error + "The surname must be less than 21 :";
            }

            //if the Address is blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The address cannot be blank : ";
            }

            //if the address is greater than 33 characters
            if (address.Length > 32)
            {
                //record the error
                Error = Error + "The address must be less than 33 :";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in past :";
                }
                //check to see if the dtae is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date is not valid :";
            }

            //return any error messages
            return Error;
        }



    }
}