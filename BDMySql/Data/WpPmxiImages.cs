using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpPmxiImages
    {
        public ulong Id { get; set; }
        public ulong AttachmentId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageFilename { get; set; }
    }
}
