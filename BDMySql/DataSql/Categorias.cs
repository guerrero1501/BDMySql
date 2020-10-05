using System.ComponentModel.DataAnnotations;

namespace BDMySql.DataSql
{
    public partial class Categorias
    {
        [Key]
        public int Id { get; set; }
        public string Nivel { get; set; }
        public string CategId { get; set; }
        public string CategName { get; set; }
        public string CategSlug { get; set; }
        public string ParentId { get; set; }
        public string IdAttribute { get; set; }
        public double Id_ParentCategory { get; set; }
        public string NameAttribute { get; set; }
        public string Slug_Attribute { get; set; }
        public string NameValue { get; set; }
        public double Orden { get; set; }
    }
}
