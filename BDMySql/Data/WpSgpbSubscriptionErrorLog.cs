using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpSgpbSubscriptionErrorLog
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string PopupType { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
    }
}
