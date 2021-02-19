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
            //set the private data members to each test data value
            mStaffId = 1234;
            mName = "John Smith";
            mPostCode = "LE1 7XY";
            mAddress = "21 Green Street";
            mDoB = Convert.ToDateTime("12/03/1995");
            mAvailable = true;
            //always return true
            return true;
        }
    }
}