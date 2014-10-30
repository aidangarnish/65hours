﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65hours.Domain.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public string PaidToUserID { get; set; }
        public string PaidByUSerID { get; set; }
        public DateTime Created { get; set; }
        public int Minutes { get; set; }
        public string Reason { get; set; }
        public bool Recommended { get; set; }
    }
}
