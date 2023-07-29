using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    internal class productGetSet
    {
        public string productName { get; set; }

        public string productType { get; set; }

        public int price { get; set; }

        public int quantity { get; set; }

        public string description { get; set; }

        public productGetSet(string product_Name, string product_Type, int p_price, int p_quantity, string p_description)
        {
            productName = product_Name;
            productType = product_Type;
            price = p_price;
            quantity = p_quantity;
            description = p_description;
        }
    }
}
