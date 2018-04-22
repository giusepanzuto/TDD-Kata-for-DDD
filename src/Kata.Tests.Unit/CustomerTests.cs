using System;
using Kata.Domain;
using Kata.Domain.Entity;
using Kata.Domain.ValueObject;
using Xunit;

namespace Kata.Tests.Unit {
    public class CustomerTests {
        [Fact]
        public void Constructor_NoInputParams_IsInstanceOfEntityBase () {
            var sut = new Customer ();
            Assert.IsAssignableFrom<EntityBase> (sut);
        }

        [Fact]
        public void AddressProperty_Set_AddressEqualsCustomerAddress () {
            const string street = "1234 Happy St";
            const string city = "Winnipeg";
            const string province = "MB";

            var address = new Address (street, city, province);

            var sut = new Customer { Address = address };

            Assert.Equal(address, sut.Address);
        }

        [Fact]
        public void MonthlyPackageProperty_Set_PackageEqualsCustomerMonthlyPackage()
        {
            var monthlyPackage = new MonthlyPackage { Id = 91351 };

            var sut = new Customer {MonthlyPackage = monthlyPackage};

            Assert.Equal(monthlyPackage, sut.MonthlyPackage);
        }

        [Fact]
        public void BillForMonthlyChargeMethod_CustomerPackageInput_GeneratesBatchWithTransaction()
        {
            const decimal price = 12.20M;
            var monthlyPackage = new MonthlyPackage { Id = 1235, Name = "Top Fit", Price = price };
            var sut = new Customer { Id = 91352, MonthlyPackage = monthlyPackage };
            var batch = sut.BillForMonthlyCharge(DateTime.Today);
            Assert.True(batch.TransactionsContainsChargeOf(price));
        }

        [Fact]
        public void BillForMonthlyChargeMethod_CustomerIsFromOntario_ThrowsException()
        {
            var monthlyPackage = new MonthlyPackage { Id = 1235, Name = "Top Fit", Price = 9.20M };
            var address = new Address("1234 Happy St", "Toronto", "Ontario");
            var sut = new Customer { Id = 91352, MonthlyPackage = monthlyPackage, Address = address };
            var ex = Assert.Throws<Exception>(() => sut.BillForMonthlyCharge(DateTime.Today));
            Assert.Equal("A manual charge cannot be run for Ontario customers.", ex.Message);
        }
    }
}