using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Transaction.Common
{
    class Supplier : Product_Basic_Class
    {
        public string City { get; set; }
        public string Country { get; set; }
        public int Company_ID { get; set; }
    }
}
