using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpPmxiTemplates
    {
        public ulong Id { get; set; }
        public string Options { get; set; }
        public string Scheduled { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsKeepLinebreaks { get; set; }
        public bool IsLeaveHtml { get; set; }
        public bool FixCharacters { get; set; }
        public string Meta { get; set; }
    }
}
