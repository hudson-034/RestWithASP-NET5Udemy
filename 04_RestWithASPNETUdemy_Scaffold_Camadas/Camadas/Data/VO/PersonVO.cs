using System.Text.Json.Serialization;

namespace Camadas.Data.VO
{
    public class PersonVO
    {
        [JsonPropertyName("Code")]
        public long Id { get; set; }
        [JsonPropertyName("Name")]
        public string FirstName { get; set; }
        [JsonPropertyName("Last Name")]
        public string LastName { get; set; }
        [JsonIgnore]
        public string Address { get; set; }
        [JsonPropertyName("Sex")]
        public string Gender { get; set; }
    }
}
