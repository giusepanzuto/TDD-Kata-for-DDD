using System;
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
    }
}
