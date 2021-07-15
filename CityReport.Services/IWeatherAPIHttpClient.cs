using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CityReport.Services
{
    public interface IWeatherAPIHttpClient
    {
        Task<HttpResponseMessage> Get(string path);
    }
}
