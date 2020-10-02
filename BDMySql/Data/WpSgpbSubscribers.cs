using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpSgpbSubscribers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? SubscriptionType { get; set; }
        public DateTime? CDate { get; set; }
        public string Status { get; set; }
        public int? Unsubscribed { get; set; }
        public string SubmittedData { get; set; }
    }
}
