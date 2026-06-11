using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Aggregates.Refund
{
    public class Refund
    {
        public int FK_EntityId { get; set; }
        public int FK_InvoiceId { get; set; }
        public int FK_PaymentModeId { get; set; }
        public int FK_VoyageId { get; set; }
    }
}
