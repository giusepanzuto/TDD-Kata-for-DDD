using System;
using System.Linq;
using Xunit;
using Kata.Domain;
using Kata.Domain.Aggregate;
using Kata.Domain.Entity;

namespace Kata.Tests.Unit
{
    public class GymTests
    {
        [Fact]
        public void GymIsTypeOfEntityBase()
        {
            var sut = new Gym();
            Assert.IsAssignableFrom<EntityBase>(sut);
        }

        [Fact]
        public void MonthlyPackagesProperty_Getter_HasCountOf0()
        {
            var sut = new Gym();
            Assert.Empty(sut.MonthlyPackages);
        }

        [Fact]
        public void AddMonthlyPackageMethod_MonthlyPackageInput_IncrementsMonthlyPackagesCount()
        {
            var sut = new Gym();
            Assert.Empty(sut.MonthlyPackages);
            sut.AddMonthlyPackage(new MonthlyPackage());
            Assert.Single(sut.MonthlyPackages);
        }

        [Fact]
        public void AddMonthlyPackageMethod_DuplicateInput_ThrowsException()
        {
            var sut = new Gym();
            var monthlyPackage1 = new MonthlyPackage {Id = 1535235};
            sut.AddMonthlyPackage(monthlyPackage1);
            var ex = Assert.Throws<ArgumentException>(() => sut.AddMonthlyPackage(monthlyPackage1));
            Assert.Equal("You cannot add a duplicate MonthlyPackage.", ex.Message);
        }
    }
}
