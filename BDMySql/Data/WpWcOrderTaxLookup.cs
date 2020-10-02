using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWcOrderTaxLookup
    {
        public ulong OrderId { get; set; }
        public ulong TaxRateId { get; set; }
        public DateTime DateCreated { get; set; }
        public double ShippingTax { get; set; }
        public double OrderTax { get; set; }
        public double TotalTax { get; set; }
    }
}
