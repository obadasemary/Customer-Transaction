using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Transaction.Common
{
    class Offer
    {
        public int ID { get; set; }
        public int Company_ID { get; set; }
        public decimal Price { get; set; }
        public decimal Offer_Value { get; set; }
    }
}
