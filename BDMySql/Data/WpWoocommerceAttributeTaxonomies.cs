using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommerceAttributeTaxonomies
    {
        public ulong AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeLabel { get; set; }
        public string AttributeType { get; set; }
        public string AttributeOrderby { get; set; }
        public int AttributePublic { get; set; }
    }
}
