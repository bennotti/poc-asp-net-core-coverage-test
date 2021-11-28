using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using SampleProject.Core.BusinessRules.Interfaces;
using SampleProjectLib;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace SampleProjectxUnitTest
{
    public class WeatherForecastControllerTest
    {
        private readonly HttpClient _client;
        public WeatherForecastControllerTest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<SampleProject.Api.Startup>());
            _client = server.CreateClient();
        }
        [Fact(DisplayName = "should be pass and Ok status code")]
        [Trait("WeatherForecastControllerTest", "Defined")]
        public async Task ServiceTest_with_service_defined()
        {
            var request = new HttpRequestMessage(new HttpMethod("GET"), "/WeatherForecast/");

            // Act
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}