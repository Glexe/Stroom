 using Stroom.Shared.Models;
using System.Net.Http.Json;

namespace Stroom.Client.Services
{
    public class UsersService : IUsersService
    {
        private readonly HttpClient Client;

        public UsersService(HttpClient client)
        {
            Client = client;
        }

        public async Task<User[]> GetAsync()
        {
            return await Client.GetFromJsonAsync<User[]>("api/Users");
        }

        public async Task<User> GetAsync(int userId)
        {
            return await Client.GetFromJsonAsync<User>($"api/Users/{userId}");
        }
    }
}
