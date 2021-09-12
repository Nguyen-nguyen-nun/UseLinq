using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NWLinq
{
    class ProductModel
    {
        private int productID;
        private string productName;
        private System.Nullable<decimal> unitPrice;
        private string categoryName;
        private string companyName;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }


        public decimal? UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
    }
}
