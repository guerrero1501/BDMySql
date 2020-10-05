using System.Text.Json.Serialization;

namespace BDMySql.DTO
{
    public class WpTermDTO
    {
        [JsonPropertyName("id")]
        public ulong TermId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("parent")]
        public ulong Parent { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonIgnore]
        public int Nivel { get; set; }
    }
}
