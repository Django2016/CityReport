using CityReport.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace CityReport.Infrastructure
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection collection, IConfiguration config)
        {
            collection.AddTransient<IWeatherAPIHttpClient, WeatherAPIHttpClient>();          
            collection.AddTransient<HttpClient>(_ => GetHttpClient(config));
            collection.AddTransient<ICityReportService, CityReportService>();
        }

        private static HttpClient GetHttpClient(IConfiguration config)
        {
            var httpclient = new HttpClient();
            httpclient.BaseAddress = new Uri(config["weatherAPIBaseaddress"]);
            httpclient.DefaultRequestHeaders.Add("x-rapidapi-key", config["weatherAPIKey"]);
            httpclient.DefaultRequestHeaders.Add("x-rapidapi-host", config["weatherAPIhost"]);
            return httpclient;
        }
    }
}
