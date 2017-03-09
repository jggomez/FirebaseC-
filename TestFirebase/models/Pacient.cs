

using Newtonsoft.Json;

namespace TestFirebase
{
    public class Pacient
    {

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "cellPhoneNumber")]
        public string CellPhoneNumber { get; set; }

        [JsonProperty(PropertyName = "identification")]
        public string Identification { get; set; }

        public Pacient()
        {
        }
    }
}