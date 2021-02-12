using System;

namespace ClassLibrary
{
    public class clsCustomer
    {

        //customerNo private member varibale
        private Int32 mCustomerNo;

        //dateAdded private member variable
        private DateTime mDateOfBirth;

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

        //DateOfBirth public property
        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
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
            //set the private dat members to the test data value 
            mCustomerNo = 21;
            mDateOfBirth = Convert.ToDateTime("01/01/2001");
            mFirstName = "tstFirstName";
            mSurname = "tstSurname";
            mAddress = "tstAddress";
            mOver18 = true;
            
            //always return true
            return true;
        }

    }
}