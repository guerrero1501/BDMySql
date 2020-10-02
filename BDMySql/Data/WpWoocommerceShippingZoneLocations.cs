using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommerceShippingZoneLocations
    {
        public ulong LocationId { get; set; }
        public ulong ZoneId { get; set; }
        public string LocationCode { get; set; }
        public string LocationType { get; set; }
    }
}
