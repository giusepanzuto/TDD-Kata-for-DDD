using System;
using Kata.Domain;
using Xunit;

namespace Kata.Tests.Unit {
    public class AddressTests {

        [Fact]
        public void Constructor_StreetNullWithCityAndProvince_ThrowsException () {
            const string street = "";
            const string city = "Winnipeg";
            const string province = "MB";

            var ex = Assert.Throws<ArgumentException> (() => new Address (street, city, province));
            Assert.Equal ("You must provide a non-null address.", ex.Message);
        }

        [Fact]
        public void Constructor_StreetWithNullCityAndProvince_ThrowsException () {
            const string street = "1234 Happy St";
            const string city = "";
            const string province = "MB";

            var ex = Assert.Throws<ArgumentException> (() => new Address (street, city, province));
            Assert.Equal ("You must provide a non-null city.", ex.Message);
        }

        [Fact]
        public void Constructor_StreetWithCityAndNullProvince_ThrowsException () {
            const string street = "1234 Happy St";
            const string city = "Winnipeg";
            const string province = "";

            var ex = Assert.Throws<ArgumentException> (() => new Address (street, city, province));
            Assert.Equal ("You must provide a non-null province.", ex.Message);
        }

        [Fact]
        public void TwoInstances_SameConstructorInputs_AreEqual () {
            const string street = "1234 Happy St";
            const string city = "Winnipeg";
            const string province = "MB";

            var sut1 = new Address (street, city, province);
            var sut2 = new Address (street, city, province);
            Assert.Equal(sut1, sut2);
        }
    }
}