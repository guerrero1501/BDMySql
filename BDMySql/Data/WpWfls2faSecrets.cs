using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWfls2faSecrets
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public byte[] Secret { get; set; }
        public byte[] Recovery { get; set; }
        public uint Ctime { get; set; }
        public uint Vtime { get; set; }
        public string Mode { get; set; }
    }
}
