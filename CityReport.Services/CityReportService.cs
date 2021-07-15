using CityReport.Services.Models;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace CityReport.Services
{
    public class CityReportService : ICityReportService
    {
        readonly IWeatherAPIHttpClient _weatherAPIHttpClient;
        public CityReportService(IWeatherAPIHttpClient weatherAPIHttpClient)
        {
            _weatherAPIHttpClient = weatherAPIHttpClient;
        }
        public async Task<AstronomyDTO> GetAstronomy(string name)
        {
            var response = new AstronomyDTO();

            string path = $"astronomy.json?q={name}";
            var result = await _weatherAPIHttpClient.Get(path);
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                // log from here
                response = JsonConvert.DeserializeObject<AstronomyDTO>(content);
            }
            return response;
        }

        public async Task<CurrentDTO> GetCurrent(string name)
        {
            var response = new CurrentDTO();

            string path = $"current.json?q={name}";
            var result = await _weatherAPIHttpClient.Get(path);
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<CurrentDTO>(content);
            }
            return response;
        }

        public async Task<LocationDTO> GetLocation(string name)
        {
            var response = new LocationDTO();
                
            string path = $"timezone.json?q={name}";
            var result = await _weatherAPIHttpClient.Get(path);
            if(result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<LocationDTO>(content);
            }
            return response;
        }
    }
}
