using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWcDownloadLog
    {
        public ulong DownloadLogId { get; set; }
        public DateTime Timestamp { get; set; }
        public ulong PermissionId { get; set; }
        public ulong? UserId { get; set; }
        public string UserIpAddress { get; set; }

        public virtual WpWoocommerceDownloadableProductPermissions Permission { get; set; }
    }
}
