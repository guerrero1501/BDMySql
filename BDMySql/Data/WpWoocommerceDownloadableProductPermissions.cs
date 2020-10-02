using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommerceDownloadableProductPermissions
    {
        public WpWoocommerceDownloadableProductPermissions()
        {
            WpWcDownloadLog = new HashSet<WpWcDownloadLog>();
        }

        public ulong PermissionId { get; set; }
        public string DownloadId { get; set; }
        public ulong ProductId { get; set; }
        public ulong OrderId { get; set; }
        public string OrderKey { get; set; }
        public string UserEmail { get; set; }
        public ulong? UserId { get; set; }
        public string DownloadsRemaining { get; set; }
        public DateTime AccessGranted { get; set; }
        public DateTime? AccessExpires { get; set; }
        public ulong DownloadCount { get; set; }

        public virtual ICollection<WpWcDownloadLog> WpWcDownloadLog { get; set; }
    }
}
