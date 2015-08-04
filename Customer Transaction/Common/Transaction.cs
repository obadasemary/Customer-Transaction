using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Transaction.Common
{
    class Transaction
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Customer_Supplir { get; set; }
        public int User_ID { get; set; }
        public DateTime Transaction_Date { get; set; }
    }
}
