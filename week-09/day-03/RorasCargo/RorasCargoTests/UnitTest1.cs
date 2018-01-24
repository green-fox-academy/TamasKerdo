using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using RorasCargo;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace RorasCargoTest
{
    public class RorasCargoTests
    {
        private HttpClient Client;
        private TestServer Server;

        public RorasCargoTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("rocket");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
