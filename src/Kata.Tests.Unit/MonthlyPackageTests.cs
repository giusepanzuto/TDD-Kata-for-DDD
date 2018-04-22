using Kata.Domain;
using Kata.Domain.Entity;
using Xunit;

namespace Kata.Tests.Unit
{
    public class MonthlyPackageTests
    {
        [Fact]
        public void Constructor_NoInputParams_IsInstanceOfEntityBase()
        {
            var sut = new MonthlyPackage();
            Assert.IsAssignableFrom<EntityBase>(sut);
        }

        [Fact]
        public void NameAndPriceProperties_Set_MatchAssignedValues()
        {
            const string name = "Test Package";
            const decimal price = 35.00M;

            var sut = new MonthlyPackage {Id = 35, Name = name, Price = price};

            Assert.Equal(name, sut.Name);
            Assert.Equal(price, sut.Price);
        }
    }
}