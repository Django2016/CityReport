using CityReport.Infrastructure;
using CityReport.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Shouldly;
using System;

namespace CityReport.Tests.System
{
    [TestFixture]
    public class TestInfrastructure : BaseTest
    {
       
        [Test]
        public void TestConfigure()
        {

            Bootstrap.Configure(collection, config);
            provider = collection.BuildServiceProvider();
            var weatherClient = provider.GetService(typeof(IWeatherAPIHttpClient));
            weatherClient.ShouldBeOfType<WeatherAPIHttpClient>();

        }
    }
}
