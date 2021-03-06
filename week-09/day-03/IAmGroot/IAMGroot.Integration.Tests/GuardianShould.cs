using IAmGroot;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IAMGroot.Integration.Tests
{
    public class GuardianTests
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("groot");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            response = await Client.GetAsync("groot?message=laiweufhluasd");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"received\":\"laiweufhluasd\",\"translated\":\"I am Groot!\"}", json);
        }

        [Fact]
        public async Task IndexShouldReturnJsonOk()
        {
            //act
            var response = await Client.GetAsync("groot");

            //assert
            response = await Client.GetAsync("groot?message=laiweufhluasd");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"received\":\"laiweufhluasd\",\"translated\":\"I am Groot!\"}", json);
        }

        [Fact]
        public async Task IndexShouldReturnJsonNotOk()
        {
            //act
            var response = await Client.GetAsync("groot");

            //assert

            response = await Client.GetAsync("groot");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"error\":\"I am Groot!\"}", json);
        }
    }
}
