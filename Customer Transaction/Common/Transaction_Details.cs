using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Transaction.Common
{
    class Transaction_Details
    {
        public int ID { get; set; }
        public int Type_ID { get; set; }
        public int Quantity { get; set; }
        public int Price_ID { get; set; }
        public int Transaction_ID { get; set; }
        public decimal Total { get; set; }
    }
}
