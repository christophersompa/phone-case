using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public bool Dispatched { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNo { get; set; }
        public int TrackingNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int ProductNo { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}