using System;
using System.Linq;
using Xunit;
using Kata.Domain;

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
    }
}
