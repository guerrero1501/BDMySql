using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWcCustomerLookup
    {
        public ulong CustomerId { get; set; }
        public ulong? UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? DateLastActive { get; set; }
        public DateTime? DateRegistered { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
