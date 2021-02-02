using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerNo { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Town { get; set; }
        public string Title { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}