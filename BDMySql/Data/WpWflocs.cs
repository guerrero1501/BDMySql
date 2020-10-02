using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWflocs
    {
        public byte[] Ip { get; set; }
        public uint Ctime { get; set; }
        public byte Failed { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public float? Lat { get; set; }
        public float? Lon { get; set; }
    }
}
