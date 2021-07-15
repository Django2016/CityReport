using Newtonsoft.Json;

namespace CityReport.Services.Models
{

    public class AstronomyDTO
    {
        [JsonProperty("astronomy")]
        public Astronomy Astronomy { get; set; }
    }

    public class Astronomy
    {
        [JsonProperty("astro")]
        public Astro Astro { get; set; }
    }

    public class Astro
    {
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }
        [JsonProperty("sunset")]
        public string Sunset { get; set; }
        [JsonProperty("moon_phase")]
        public string Moonphase { get; set; }
    }
}
