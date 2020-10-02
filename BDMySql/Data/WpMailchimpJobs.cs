using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpMailchimpJobs
    {
        public long Id { get; set; }
        public string ObjId { get; set; }
        public string Job { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
