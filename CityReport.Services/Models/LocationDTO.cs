﻿using Newtonsoft.Json;

namespace CityReport.Services.Models
{
    public class LocationDTO
    {
        [JsonProperty("location")]
        public Location Location { get; set; }
    }
    public class Location
    {
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("lat")]
        public float Latitude { get; set; }
        [JsonProperty("lon")]
        public float Longitude { get; set; }
        [JsonProperty("localtime")]
        public string Localtime { get; set; }
    }
}



