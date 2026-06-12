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
    }
}
