using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWfconfig
    {
        public string Name { get; set; }
        public byte[] Val { get; set; }
        public string Autoload { get; set; }
    }
}
