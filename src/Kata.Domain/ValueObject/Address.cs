using System;

namespace Kata.Domain.ValueObject
{
    public class Address
    {
        public Address(string street, string city, string province)
        {            
            if(string.IsNullOrWhiteSpace(street)) throw new ArgumentException("You must provide a non-null address.");
            Street = street;

            if(string.IsNullOrWhiteSpace(city)) throw new ArgumentException("You must provide a non-null city.");
            City = city;
            
            if(string.IsNullOrWhiteSpace(province)) throw new ArgumentException("You must provide a non-null province.");
            Province = province;
        }

        public string Street { get; }
        public string City { get; }
        public string Province { get; }

        public override bool Equals(object obj){
            if(!(obj is Address address2)) return false;

            return
                Street.Equals(address2.Street) &&
                City.Equals(address2.City) &&
                Province.Equals(address2.Province);
        }

        public override int GetHashCode(){
            return $"{Street}{City}{Province}".GetHashCode();
        }
    }
}