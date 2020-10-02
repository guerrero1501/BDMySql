using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWcProductMetaLookup
    {
        public long ProductId { get; set; }
        public string Sku { get; set; }
        public bool? Virtual { get; set; }
        public bool? Downloadable { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public bool? Onsale { get; set; }
        public double? StockQuantity { get; set; }
        public string StockStatus { get; set; }
        public long? RatingCount { get; set; }
        public decimal? AverageRating { get; set; }
        public long? TotalSales { get; set; }
        public string TaxStatus { get; set; }
        public string TaxClass { get; set; }
    }
}
