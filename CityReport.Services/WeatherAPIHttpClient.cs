using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CityReport.Services
{
    public class WeatherAPIHttpClient : IWeatherAPIHttpClient
    {
        readonly HttpClient _client;
        public WeatherAPIHttpClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<HttpResponseMessage> Get(string path)
        {
            var result = await _client.GetAsync(path);
            return result;
        }
    }
}
