using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpPmxiFiles
    {
        public ulong Id { get; set; }
        public ulong ImportId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime RegisteredOn { get; set; }
    }
}
