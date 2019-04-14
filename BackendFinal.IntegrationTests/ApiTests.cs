using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using BackendFinal.Api;
using Shouldly;
using Xunit;

namespace BackendFinal.IntegrationTests
{
    public class ApiTests : IClassFixture<CustomWebApplicationFactory<Startup>>, IDisposable
    {
        private readonly HttpClient _client;

        public ApiTests(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ApiCallShouldReturnOk()
        {
            using (var response = await _client.GetAsync("api/values"))
            {
                response.StatusCode.ShouldBe(HttpStatusCode.OK);
            }
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}
