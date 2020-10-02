using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWcOrderProductLookup
    {
        public ulong OrderItemId { get; set; }
        public ulong OrderId { get; set; }
        public ulong ProductId { get; set; }
        public ulong VariationId { get; set; }
        public ulong? CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
        public int ProductQty { get; set; }
        public double ProductNetRevenue { get; set; }
        public double ProductGrossRevenue { get; set; }
        public double CouponAmount { get; set; }
        public double TaxAmount { get; set; }
        public double ShippingAmount { get; set; }
        public double ShippingTaxAmount { get; set; }
    }
}
