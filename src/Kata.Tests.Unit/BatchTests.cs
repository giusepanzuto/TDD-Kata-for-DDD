using System;
using Kata.Domain;
using Xunit;

namespace Kata.Tests.Unit
{
    public class BatchTests
    {
        [Fact]
        public void Constructor_NoInputParams_IsInstanceOfEntityBase()
        {
            var sut = new Batch();
            Assert.IsAssignableFrom<EntityBase>(sut);
        }

        [Fact]
        public void TransactionProperty_Getter_HasCountOf0()
        {
            var sut = new Batch();
            Assert.Empty(sut.Transactions);
        }

        [Fact]
        public void AddTransactionMethod_TransactionInput_IncrementsCount()
        {
            var sut = new Batch();
            Assert.Empty(sut.Transactions);
            sut.AddTransaction(new Transaction {Id = 91352, Amount = 10.01M});
            Assert.Single(sut.Transactions);
        }

        [Fact]
        public void AddTransactionMethod_DuplicateInput_ThrowsException()
        {
            var transaction = new Transaction { Id = 91325125, Amount = 10.01M };

            var sut = new Batch();
            sut.AddTransaction(transaction);

            var ex = Assert.Throws<ArgumentException>(() => sut.AddTransaction(transaction));
            Assert.Equal("You cannot add duplicate transactions.", ex.Message);
        }

        [Fact]
        public void AddTransactionMethod_AmountLessThanTenDollars_ThrowsException()
        {
            var transaction = new Transaction { Id = 91325125, Amount = 9.99M };

            var sut = new Batch();
            var ex = Assert.Throws<ArgumentException>(() => sut.AddTransaction(transaction));
            Assert.Equal("A transaction charge must be at least $10.", ex.Message);
        }
    }
}
