using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Country
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string ISO2Code { get; private set; }
        public string ISO3Code { get; private set; }
        public string CurrencyCode { get; private set; } // enum to string
        public byte[]? Flag { get; private set; }
        public char Status { get; private set; }
        public DateTime DtAccess { get; private set; }
        public int UserId { get; private set; }

        private Country() { }

        public static Country Create(string name, string iso2Code, string iso3Code, string currencyCode, byte[]? flag, char status, DateTime dtAccess, int userId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");
            if (string.IsNullOrWhiteSpace(iso2Code) || iso2Code.Length != 2)
                throw new ArgumentException("ISO2Code must be 2 characters.");
            if (string.IsNullOrWhiteSpace(iso3Code) || iso3Code.Length != 3)
                throw new ArgumentException("ISO3Code must be 3 characters.");
            if (string.IsNullOrWhiteSpace(currencyCode))
                throw new ArgumentException("CurrencyCode cannot be empty.");
            return new Country
            {
                Name = name,
                ISO2Code = iso2Code,
                ISO3Code = iso3Code,
                CurrencyCode = currencyCode.ToString(),
                Flag = flag,
                Status = status,
                DtAccess = dtAccess,
                UserId = userId
            };
        }
    }
}
