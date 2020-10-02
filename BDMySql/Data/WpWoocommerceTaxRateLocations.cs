using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommerceTaxRateLocations
    {
        public ulong LocationId { get; set; }
        public string LocationCode { get; set; }
        public ulong TaxRateId { get; set; }
        public string LocationType { get; set; }
    }
}
