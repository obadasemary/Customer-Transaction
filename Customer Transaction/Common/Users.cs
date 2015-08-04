using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Transaction.Common
{
    class Users : Product_Basic_Class
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Company_ID { get; set; }
    }
}
