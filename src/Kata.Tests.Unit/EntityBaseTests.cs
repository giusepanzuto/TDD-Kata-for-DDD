using Kata.Domain;
using Xunit;

namespace Kata.Tests.Unit
{
    public class EntityBaseTests
    {
        [Fact]
        public void TwoInstances_SameIdProperty_AreEqual(){
            const int id = 2547;
            var sut1 = new EntityBase{ Id = id };
            var sut2 = new EntityBase{ Id = id };
            Assert.Equal(sut1, sut2); 
        }

        [Fact]
        public void TwoInstances_DifferentIdProperty_AreNotEqual()
        {
            var sut1 = new EntityBase { Id = 3819025 };
            var sut2 = new EntityBase { Id = 82934 };
            Assert.NotEqual(sut1, sut2);
        }

        [Fact]
        public void TwoInstances_ZeroIdProperty_AreNotEqual()
        {
            const int idToAdd = 0;
            var sut1 = new EntityBase { Id = idToAdd };
            var sut2 = new EntityBase { Id = idToAdd };
            Assert.NotEqual(sut1, sut2);
        }
    }
}