using System.Text.Json.Serialization;

namespace BDMySql.DTO
{
    public class WpTermDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("parent")]
        public int Parent { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonIgnore]
        public int Nivel { get; set; }
    }
}
