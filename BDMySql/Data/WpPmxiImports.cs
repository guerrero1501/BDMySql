using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpPmxiImports
    {
        public ulong Id { get; set; }
        public long ParentImportId { get; set; }
        public string Name { get; set; }
        public string FriendlyName { get; set; }
        public string Type { get; set; }
        public string FeedType { get; set; }
        public string Path { get; set; }
        public string Xpath { get; set; }
        public string Options { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string RootElement { get; set; }
        public bool Processing { get; set; }
        public bool Executing { get; set; }
        public bool Triggered { get; set; }
        public long QueueChunkNumber { get; set; }
        public DateTime FirstImport { get; set; }
        public long Count { get; set; }
        public long Imported { get; set; }
        public long Created { get; set; }
        public long Updated { get; set; }
        public long Skipped { get; set; }
        public long Deleted { get; set; }
        public bool Canceled { get; set; }
        public DateTime CanceledOn { get; set; }
        public bool Failed { get; set; }
        public DateTime FailedOn { get; set; }
        public DateTime SettingsUpdateOn { get; set; }
        public DateTime LastActivity { get; set; }
        public long Iteration { get; set; }
    }
}
