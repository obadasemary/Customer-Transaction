using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Transaction.Common
{
    class Product : Product_Basic_Class
    {
        public int Company_ID { get; set; }
        public byte Photo_Product { get; set; }
    }
}
