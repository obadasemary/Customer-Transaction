using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Transaction.Common
{
    class Company : Product_Basic_Class
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public byte Logo { get; set; }
    }
}
