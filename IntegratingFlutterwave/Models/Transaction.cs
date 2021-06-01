using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegratingFlutterwave.Models
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string TransactionReference { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string TransactionStatus { get; set; }
    }
}
