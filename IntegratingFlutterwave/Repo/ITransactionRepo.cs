using IntegratingFlutterwave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegratingFlutterwave.Repo
{
    public interface ITransactionRepo
    {
        Transaction Create(Transaction transaction);
    }
}
