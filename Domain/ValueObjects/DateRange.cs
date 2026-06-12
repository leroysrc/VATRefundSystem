using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class DateRange
    {
        // valid from/valid to date ranges
        public DateTime ValidFrom { get; }
        public DateTime ValidTo { get; }

        private DateRange(DateTime validFrom, DateTime validTo)
        {
            ValidFrom = validFrom;
            ValidTo = validTo;
        }

        public static DateRange Create(DateTime validFrom, DateTime validTo)
        {
            if (validFrom > validTo)
                throw new ArgumentException("ValidFrom cannot be later than ValidTo.");
            return new DateRange(validFrom, validTo);
        }

        public bool Equals(DateRange? other)
        {
            if (other is null)
                return false;
            return ValidFrom == other.ValidFrom && ValidTo == other.ValidTo;
        }

        public override bool Equals(object? obj) => Equals(obj as DateRange);
        public override int GetHashCode() => HashCode.Combine(ValidFrom, ValidTo);
        public bool Contains(DateTime date) => date >= ValidFrom && date <= ValidTo;
    }
}
