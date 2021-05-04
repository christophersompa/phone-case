using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        
        private bool mAvailable;
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
        private DateTime mDoB;
        public DateTime DoB
        {
            get
            {
                return mDoB;
            }
            set
            {
                mDoB = value;
            }
        }
        private Int32 mStaffId;
        public Int32 StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }
        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        private string mPostCode;
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }
        private string mName;
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value; 
            }
        }
        public bool Find(int staffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Staff Id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either one of zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDoB = Convert.ToDateTime(DB.DataTable.Rows[0]["DoB"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
            //
        }

        public string Valid(string name, string postCode, string address, string doB)
        {
            //NAME
            //create a string variable to store the error
            String Error = "";

            //create a temp variable to store date values
            DateTime DateTemp;

            //if the Name is blank
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The name may not be blank : ";
            }
            //if the name is greater than 15 characters
            if (name.Length > 15)
            {
                //record the error
                Error = Error + "The name must be 15 characters or less : ";
            }
            //POST CODE
            //is the post code blank
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (postCode.Length > 10)
            {
                //record the error
                Error = Error + "The post code must be less than 10 characters : ";
            }
            //DATE OF BIRTH
            try
            {
                //copy the dateAdded value to the DateTemp varibale
                DateTemp = Convert.ToDateTime(doB);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
                if (DateTemp == DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the present : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //ADDRESS
            //is the address blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The street may not be blank : ";
            }
            //if the address is too long
            if (address.Length > 30)
            {
                //record the error
                Error = Error + "The street must be less than 30 characters : ";
            }

            //return any error messages
            return Error;
            
        }
    }
}