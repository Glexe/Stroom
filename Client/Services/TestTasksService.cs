 using Stroom.Shared.Models;
using System.Net.Http.Json;

namespace Stroom.Client.Services
{
    public class TestTasksService : ITasksService
    {
        private readonly HttpClient Client;

        public TestTasksService(HttpClient client)
        {
            Client = client;
        }

        public async Task<TaskDto[]> GetAsync()
        {
            return await Client.GetFromJsonAsync<TaskDto[]>("api/Tasks");
        }

        public async Task<TaskDto> GetAsync(int taskId)
        {
            return await Client.GetFromJsonAsync<TaskDto>($"api/Tasks/{taskId}");
        }
    }
}
