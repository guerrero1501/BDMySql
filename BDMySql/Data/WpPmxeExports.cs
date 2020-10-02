using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpPmxeExports
    {
        public ulong Id { get; set; }
        public long ParentId { get; set; }
        public long AttchId { get; set; }
        public string Options { get; set; }
        public string Scheduled { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string FriendlyName { get; set; }
        public long Exported { get; set; }
        public bool Canceled { get; set; }
        public DateTime CanceledOn { get; set; }
        public DateTime SettingsUpdateOn { get; set; }
        public DateTime LastActivity { get; set; }
        public bool Processing { get; set; }
        public bool Executing { get; set; }
        public bool Triggered { get; set; }
        public long Iteration { get; set; }
        public string ExportPostType { get; set; }
    }
}
