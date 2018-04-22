using System;

namespace Kata.Domain
{
    public class Address
    {
        private string street;
        private string city;
        private string province;

        public Address(string street, string city, string province)
        {            
            if(string.IsNullOrWhiteSpace(street)) throw new ArgumentException("You must provide a non-null address.");
            this.street = street;

            if(string.IsNullOrWhiteSpace(city)) throw new ArgumentException("You must provide a non-null city.");
            this.city = city;
            
            if(string.IsNullOrWhiteSpace(province)) throw new ArgumentException("You must provide a non-null province.");
            this.province = province;
        }

        public string Street { get => street; }
        public string City { get => city; }
        public string Province { get => province; }

        public override bool Equals(object obj){
            var address2 = obj as Address;
            if(address2 == null) return false;

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