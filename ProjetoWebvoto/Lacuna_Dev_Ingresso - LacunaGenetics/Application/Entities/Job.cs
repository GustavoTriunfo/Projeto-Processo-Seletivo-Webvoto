using System.Text.Json.Serialization;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.Entities
{
    public class Job
    {
        [JsonPropertyName("id")]
        public string id { get; set; }
        [JsonPropertyName("type")]
        public string type { get; set; }
        [JsonPropertyName("strand")]
        public string? strand { get; set; }
        [JsonPropertyName("strandEncoded")]
        public string? strandEncoded { get; set; }
        [JsonPropertyName("geneEncoded")]
        public string? geneEncoded { get; set; }
    }
}
