﻿using System;

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
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18?"]);
                //return that everything worked OK
                return true;
            }

            else
            {
                //return false indicating a problem
                return false; 
            }
           
        }

    }
}