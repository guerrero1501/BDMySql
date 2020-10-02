using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpMailchimpCarts
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public int? UserId { get; set; }
        public string Cart { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
