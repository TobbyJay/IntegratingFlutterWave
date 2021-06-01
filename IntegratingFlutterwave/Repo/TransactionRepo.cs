using IntegratingFlutterwave.Data;
using IntegratingFlutterwave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegratingFlutterwave.Repo
{
    public class TransactionRepo : ITransactionRepo
    {
        private readonly AppDbContext _context;

        public TransactionRepo(AppDbContext context)
        {
            _context = context;
        }

        public Transaction Create(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
            return transaction;
        }
    }
}
