using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWcAdminNoteActions
    {
        public ulong ActionId { get; set; }
        public ulong NoteId { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Query { get; set; }
        public string Status { get; set; }
        public bool IsPrimary { get; set; }
    }
}
