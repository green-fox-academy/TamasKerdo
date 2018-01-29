using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using ProjectNote;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using ProjectNote.Entities;
using ProjectNote.Repositories;
using Microsoft.EntityFrameworkCore;


namespace ProjectNoteTest
{
    public class ProjectNoteTest
    {
        private readonly HttpClient Client;
        private readonly TestServer Server;

        public ProjectNoteTest()
        {            
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

        [Fact]
        public async Task IndexShouldReturnOkJson()
        {

            var response = await Client.GetAsync("rocket");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"caliber25\":0,\"caliber30\":0,\"caliber50\":0,\"shipstatus\":\"empty\",\"ready\":false}", json);
        }

        [Fact]
        public async Task IndexShouldReturnOkJson2()
        {

            var response = await Client.GetAsync("rocket/fill?caliber=.50&amount=5000");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"recieved\":5000, \"amount\":5000, \"shipstatus\": \"40\": \"ready\": false,}", json);
        }

        [Fact]
        public async Task ReturnCreatedStatus()
        {
            var options = new DbContextOptionsBuilder<ProjectNoteContext>().UseInMemoryDatabase().Options;

            using (var context = new ProjectNoteContext(options))
            {
                var repository = new Repository(context);
                repository.AddStudent();

                var studentCount = await context.Students.CountAsync();
                Assert.Equal(1, studentCount);
            }
        }
    }
}




    
