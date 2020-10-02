using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpPmxeGoogleCats
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public string ParentName { get; set; }
        public sbyte Level { get; set; }
    }
}
