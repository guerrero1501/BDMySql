using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommerceTaxRates
    {
        public ulong TaxRateId { get; set; }
        public string TaxRateCountry { get; set; }
        public string TaxRateState { get; set; }
        public string TaxRate { get; set; }
        public string TaxRateName { get; set; }
        public ulong TaxRatePriority { get; set; }
        public int TaxRateCompound { get; set; }
        public int TaxRateShipping { get; set; }
        public ulong TaxRateOrder { get; set; }
        public string TaxRateClass { get; set; }
    }
}
