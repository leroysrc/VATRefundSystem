using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class Address : IEquatable<Address>
    {
        public string AddressLine1 { get; }
        public string AddressLine2 { get; }
        public string City { get; }

        private Address(string addressLine1, string addressLine2, string city)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
        }

        public static Address Create(string addressLine1, string addressLine2, string city)
        {
            if (string.IsNullOrWhiteSpace(addressLine1))
                throw new ArgumentException("AddressLine1 cannot be empty.");
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City cannot be empty.");
            return new Address(addressLine1, addressLine2 ?? string.Empty, city);
        }

        public bool Equals(Address? other)
        {
            if (other is null)
                return false;
            return AddressLine1 == other.AddressLine1 && AddressLine2 == other.AddressLine2 && City == other.City;
        }

        public override bool Equals(object? obj) => Equals(obj as Address);
        public override int GetHashCode() => HashCode.Combine(AddressLine1, AddressLine2, City);
    }
}
