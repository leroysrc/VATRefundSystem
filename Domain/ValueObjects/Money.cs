using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class Money : IEquatable<Money>
    {
        // 4 currency type
        // TotalExcTax, TotalTax, TotalIncTax
        public decimal Amount { get; }
        public CurrencyCode Currency { get; }

        private Money(decimal amount, CurrencyCode currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money Create(decimal amount, CurrencyCode currency)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative.");
            return new Money(amount, currency);
        }

        public bool Equals(Money? other)
        {
            if (other is null)
                return false;
            return Amount == other.Amount && Currency == other.Currency;
        }

        public override bool Equals (object? obj) => Equals(obj as Money);
        public override int GetHashCode() => HashCode.Combine(Amount, Currency);

        public static Money operator +(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new InvalidOperationException("Cannot add amounts with different currencies.");
            return new Money(a.Amount + b.Amount, a.Currency);
        }
    }
}
