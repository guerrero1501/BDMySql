using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWflsSettings
    {
        public string Name { get; set; }
        public byte[] Value { get; set; }
        public string Autoload { get; set; }
    }
}
