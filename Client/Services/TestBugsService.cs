using Stroom.Shared.Models;
using System.Net.Http.Json;

namespace Stroom.Client.Services
{
    public class TestBugsService : IBugsService
    {
        private readonly HttpClient Client;

        public TestBugsService(HttpClient client)
        {
            Client = client;
        }

        public async Task<Bug[]> GetAsync()
        {
            return await Client.GetFromJsonAsync<Bug[]>("api/Bugs");
        }
    }
}
