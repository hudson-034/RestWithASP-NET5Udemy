using System;
using System.Text.Json.Serialization;

namespace Camadas.Data.VO
{
    public class BookVO
    { 
        [JsonPropertyName("ISBN")]
        public long Id { get; set; }
        [JsonPropertyName("Authors")]
        public string Author { get; set; }
        [JsonPropertyName("Launch Date")]
        public DateTime LaunchDate { get; set; }
        [JsonIgnore]
        public decimal Price { get; set; }
        [JsonPropertyName("Title")]
        public string Title { get; set; }
    }
}
