using CityReport.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityReport.Tests.System
{
    public class BaseTest
    {
        protected ServiceProvider provider;
        protected IServiceCollection collection;
        protected IConfiguration config;

        [OneTimeSetUp]
        public void SetUp()
        {
            collection = new ServiceCollection();
            config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();
            Bootstrap.Configure(collection,config);
            provider = collection.BuildServiceProvider();
        }
    }
}
