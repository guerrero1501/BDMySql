using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpPostmarkLog
    {
        public int Id { get; set; }
        public DateTime LogEntryDate { get; set; }
        public string Fromaddress { get; set; }
        public string Toaddress { get; set; }
        public string Subject { get; set; }
        public string Response { get; set; }
    }
}
