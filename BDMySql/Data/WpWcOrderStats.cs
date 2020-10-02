using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWcOrderStats
    {
        public ulong OrderId { get; set; }
        public ulong ParentId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateCreatedGmt { get; set; }
        public int NumItemsSold { get; set; }
        public double TotalSales { get; set; }
        public double TaxTotal { get; set; }
        public double ShippingTotal { get; set; }
        public double NetTotal { get; set; }
        public bool? ReturningCustomer { get; set; }
        public string Status { get; set; }
        public ulong CustomerId { get; set; }
    }
}
