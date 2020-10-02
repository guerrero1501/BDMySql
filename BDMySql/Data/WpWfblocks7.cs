﻿using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWfblocks7
    {
        public ulong Id { get; set; }
        public uint Type { get; set; }
        public byte[] Ip { get; set; }
        public long BlockedTime { get; set; }
        public string Reason { get; set; }
        public uint? LastAttempt { get; set; }
        public uint? BlockedHits { get; set; }
        public ulong Expiration { get; set; }
        public string Parameters { get; set; }
    }
}
