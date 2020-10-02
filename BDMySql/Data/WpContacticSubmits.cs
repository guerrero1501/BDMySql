using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpContacticSubmits
    {
        public decimal SubmitTime { get; set; }
        public string FormName { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public int? FieldOrder { get; set; }
        public byte[] File { get; set; }
    }
}
