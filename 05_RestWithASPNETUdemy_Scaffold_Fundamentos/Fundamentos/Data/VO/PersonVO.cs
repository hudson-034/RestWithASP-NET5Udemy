using Fundamentos.Hypermedia;
using Fundamentos.Hypermedia.Abstract;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Fundamentos.Data.VO
{
    public class PersonVO : ISupportsHyperMedia  
    {
        [JsonPropertyName("código")]
        public long Id { get; set; }
        [JsonPropertyName("nome")]
        public string FirstName { get; set; }
        [JsonPropertyName("sobrenome")]
        public string LastName { get; set; }
        [JsonPropertyName("endereço")]
        public string Address { get; set; }
        [JsonPropertyName("gênero")]
        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

        // Quando não quiser renomear o objeto utilizar [JsonIgnore]
    }
}
