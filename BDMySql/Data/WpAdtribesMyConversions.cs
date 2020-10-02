using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpAdtribesMyConversions
    {
        public int Id { get; set; }
        public DateTime ConversionTime { get; set; }
        public string ProjectHash { get; set; }
        public string UtmSource { get; set; }
        public string UtmCampaign { get; set; }
        public string UtmMedium { get; set; }
        public string UtmTerm { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
