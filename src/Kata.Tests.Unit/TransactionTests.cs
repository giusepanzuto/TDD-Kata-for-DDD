using Kata.Domain;
using Kata.Domain.Entity;
using Xunit;

namespace Kata.Tests.Unit
{
    public class TransactionTests
    {
        [Fact]
        public void Constructor_NoInputParams_IsInstanceOfEntityBase()
        {
            var sut = new Transaction();
            Assert.IsAssignableFrom<EntityBase>(sut);
        }
    }
}
