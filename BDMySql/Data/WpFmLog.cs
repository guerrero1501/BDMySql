using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpFmLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string OperationId { get; set; }
        public string FilePath { get; set; }
        public DateTime Time { get; set; }
    }
}
