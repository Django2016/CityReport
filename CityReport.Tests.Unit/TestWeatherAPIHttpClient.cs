using CityReport.Services;
using Moq;
using NUnit.Framework;
using Shouldly;
using System.Net.Http;
using System.Threading.Tasks;

namespace CityReport.Tests.Unit
{
    [TestFixture]
    public class TestWeatherAPIHttpClient
    {
        HttpClient _client;
        [SetUp]
        public void Setup()
        {
            var mockCLient = new Mock<HttpClient>();           
            _client = mockCLient.Object;
        }

        [Test]
        public async Task TestGet()
        {
            //Arrange
            var weatherApiHttpClient = new WeatherAPIHttpClient(_client);
            //Act
            var result = await weatherApiHttpClient.Get("https://www.google.com");
            //Asset
            result.ShouldBeOfType<HttpResponseMessage>();
            result.IsSuccessStatusCode.ShouldBeTrue();
        }

    }
}
