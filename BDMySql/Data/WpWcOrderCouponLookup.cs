using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWcOrderCouponLookup
    {
        public ulong OrderId { get; set; }
        public ulong CouponId { get; set; }
        public DateTime DateCreated { get; set; }
        public double DiscountAmount { get; set; }
    }
}
