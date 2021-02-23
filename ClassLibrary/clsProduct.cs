using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public int ProductId;
        public string SmartPhoneBrand;
        public string SmartPhoneModel;
        public string ProductName;
        public decimal Price;
        public int StockLevel;
        public int ReOrderLevel;
        public bool Active;

        public bool Find(int productId)
        {
            throw new NotImplementedException();
        }
    }
}