using System;

namespace ClassLibrary
{
    public class clsSupply
    {
        public bool Active { get; set; }
        public DateTime DateOrdered { get; set; }
        public int PhoneCaseId { get; set; }
        public string PhoneModel { get; set; }
        public decimal Price { get; set; }
        public string SupplierName { get; set; }
    }
}