using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_AppDev
{
    internal class Order
    {
 

        public string CustomerName { get; set; }

        public string ProductName { get; set; }

        public string Quantity { get; set; }

        public string Total { get; set;}

        public Order( string customerName, string productName, string quantity, string total)
        {
            CustomerName=customerName;
            ProductName=productName;
            Quantity=quantity;
            Total=total;
        }
    }
}
