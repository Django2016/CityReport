using CityReport.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Shouldly;

namespace CityReport.Tests.System
{
    [TestFixture]
    class TestCityReportService : BaseTest
    {
        [Test]
        public async Task TestGetLocation()
        {
            var cityReportService = provider.GetService<ICityReportService>();

            var response = await cityReportService.GetLocation("London");
            response.Location.Region.ShouldNotBeNullOrEmpty();
        }

        [Test]
        public async Task TestGetCurrent()
        {
            var cityReportService = provider.GetService<ICityReportService>();

            var response = await cityReportService.GetCurrent("London");
            response.Current.Condition.Text.ShouldNotBeNullOrEmpty();
        }

        [Test]
        public async Task TestGetAstronomy()
        {
            var cityReportService = provider.GetService<ICityReportService>();

            var response = await cityReportService.GetAstronomy("London");
            response.Astronomy.Astro.Moonphase.ShouldNotBeNullOrEmpty();
        }
    }
}
