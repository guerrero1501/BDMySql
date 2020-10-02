using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommerceShippingZoneMethods
    {
        public ulong ZoneId { get; set; }
        public ulong InstanceId { get; set; }
        public string MethodId { get; set; }
        public ulong MethodOrder { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
