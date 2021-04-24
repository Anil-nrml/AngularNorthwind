using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindDataModel
{
    public class OrderDataModel
    {

        public int OrderID { get; set; }
        public int ProductID { get; set; }

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ShippingAddress { get; set; }

    }
}
