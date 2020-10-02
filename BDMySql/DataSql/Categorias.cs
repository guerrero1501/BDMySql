using System;
using System.Collections.Generic;

namespace BDMySql.DataSql
{
    public partial class Categorias
    {
        public string Nivel { get; set; }
        public string CategId { get; set; }
        public string CategName { get; set; }
        public string CategSlug { get; set; }
        public string ParentId { get; set; }
        public string IdAttribute { get; set; }
        public string NameAttribute { get; set; }
        public string IdValue { get; set; }
        public string NameValue { get; set; }
    }
}
