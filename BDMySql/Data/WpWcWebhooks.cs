using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWcWebhooks
    {
        public ulong WebhookId { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public ulong UserId { get; set; }
        public string DeliveryUrl { get; set; }
        public string Secret { get; set; }
        public string Topic { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateCreatedGmt { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateModifiedGmt { get; set; }
        public short ApiVersion { get; set; }
        public short FailureCount { get; set; }
        public bool PendingDelivery { get; set; }
    }
}
