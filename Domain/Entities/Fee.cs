using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Fee : Aggregates.Invoice.Invoice_to_Fee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public float Value { get; private set; }
        public DateTime ValidFrom { get; private set; }
        public DateTime ValidTo { get; private set; }
        public char Status { get; private set; }
        public DateTime DtAccess { get; private set; }
        public int UserId { get; private set; }
    }
}
