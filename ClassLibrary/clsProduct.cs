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
        public DateTime DateAdded;

        public bool Find(int ProductId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", ProductId);
            DB.Execute("sproc_tblProduct_FilterByProductId");
            if (DB.Count == 1)
            {
                ProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                ProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                SmartPhoneBrand = Convert.ToString(DB.DataTable.Rows[0]["SmartPhoneBrand"]);
                SmartPhoneModel = Convert.ToString(DB.DataTable.Rows[0]["SmartPhoneModel"]);
                Price = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                StockLevel = Convert.ToInt32(DB.DataTable.Rows[0]["StockLevel"]);
                ReOrderLevel = Convert.ToInt32(DB.DataTable.Rows[0]["ReOrderLevel"]);
                DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}