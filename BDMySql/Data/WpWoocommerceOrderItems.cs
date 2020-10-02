using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommerceOrderItems
    {
        public ulong OrderItemId { get; set; }
        public string OrderItemName { get; set; }
        public string OrderItemType { get; set; }
        public ulong OrderId { get; set; }
    }
}
