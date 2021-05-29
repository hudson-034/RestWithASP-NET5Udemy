using Fundamentos.Hypermedia;
using Fundamentos.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Fundamentos.Data.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        [JsonPropertyName("isbn")]
        public long Id { get; set; }
        [JsonPropertyName("autor")]
        public string Author { get; set; }
        [JsonPropertyName("dataLançamento")]
        public DateTime LaunchDate { get; set; }
        [JsonPropertyName("preço")]
        public decimal Price { get; set; }
        [JsonPropertyName("título")]
        public string Title { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

        // Quando não quiser renomear o objeto utilizar [JsonIgnore]
    }
}
