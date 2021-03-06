using System;
using Kata.Domain.Aggregate;
using Kata.Domain.ValueObject;

namespace Kata.Domain.Entity
{
    public class Customer : EntityBase
    {
        public Address Address { get; set; }
        public MonthlyPackage MonthlyPackage { get; set; }

        public Batch BillForMonthlyCharge(DateTime today)
        {
            if(Address?.Province == "Ontario")
                throw new Exception("A manual charge cannot be run for Ontario customers.");

            var batch = new Batch();
            batch.AddTransaction(new Transaction {Amount = MonthlyPackage.Price});
            return batch;
        }
    }
}