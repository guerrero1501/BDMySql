using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWcTaxRateClasses
    {
        public ulong TaxRateClassId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
