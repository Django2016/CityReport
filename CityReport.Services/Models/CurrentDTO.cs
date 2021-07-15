using Newtonsoft.Json;

namespace CityReport.Services.Models
{
    public class CurrentDTO
    {
        [JsonProperty("current")]
        public Current Current { get; set; }
    }

    public class Current
    {
        [JsonProperty("temp_c")]
        public float Temperature { get; set; }
        [JsonProperty("condition")]
        public Condition Condition { get; set; }
    }

    public class Condition
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
