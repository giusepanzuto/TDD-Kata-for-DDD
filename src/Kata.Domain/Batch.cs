using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Domain
{
    public class Batch : EntityBase
    {
        private readonly HashSet<Transaction> _transactions = new HashSet<Transaction>();
        public IEnumerable<Transaction> Transactions => _transactions.ToList();

        public void AddTransaction(Transaction transaction)
        {
            if(transaction.Amount < 10)
                throw new ArgumentException("A transaction charge must be at least $10.");

            if(!_transactions.Add(transaction))
                throw new ArgumentException("You cannot add duplicate transactions.");
        }

        public bool TransactionsContainsChargeOf(decimal price) => _transactions.Any(t => t.Amount == price);
    }
}
