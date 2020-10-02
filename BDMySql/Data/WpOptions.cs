using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpOptions
    {
        public ulong OptionId { get; set; }
        public string OptionName { get; set; }
        public string OptionValue { get; set; }
        public string Autoload { get; set; }
    }
}
