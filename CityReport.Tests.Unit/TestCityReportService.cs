using CityReport.Services;
using CityReport.Services.Models;
using Moq;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CityReport.Tests.Unit
{
    [TestFixture]
    public class TestCityReportService
    {
        private CityReportService service;
        [SetUp]
        public void Setup()
        {

            var mockCLient = new Mock<IWeatherAPIHttpClient>();
            mockCLient.Setup(x => x.Get(It.IsAny<string>())).ReturnsAsync(new HttpResponseMessage());
            service = new CityReportService(mockCLient.Object);
        }

        [Test]
        public async Task TestGetLocation()
        {
            //act
            var LocationResult = await service.GetLocation("test info");

            // assert
            LocationResult.ShouldBeOfType<LocationDTO>();

        }

        [Test]
        public async Task TestGetCurrent()
        {
            //act
            var CurrentResult = await service.GetCurrent("test info");

            // assert
            CurrentResult.ShouldBeOfType<CurrentDTO>();

        }

        [Test]
        public async Task TestGetAstronomy()
        {
            //act
            var AstronomyResult = await service.GetAstronomy("test info");

            // assert
            AstronomyResult.ShouldBeOfType<AstronomyDTO>();

        }
    }
}
