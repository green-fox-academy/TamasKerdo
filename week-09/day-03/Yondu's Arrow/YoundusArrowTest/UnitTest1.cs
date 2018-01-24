using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using YoundusArrow;

namespace YoundusArrowTest
{
    public class YoundusArrowTest
    {
        private HttpClient Client;
        private TestServer Server;

        public YoundusArrowTest()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("yondu");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnWithJson()
        {
            //act
            var response = await Client.GetAsync("yondu?distance=100.0&time=10.0");

            //assert
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"distance\":100.0,\"time\":10.0,\"speed\":10.0}", json);
        }
    }
}