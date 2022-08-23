using Stroom.Shared.Models;
using System.Net.Http.Json;

namespace Stroom.Client.Services
{
    public class TestProjectsService : IProjectsService
    {
        private readonly HttpClient Client;

        public TestProjectsService(HttpClient client)
        {
            Client = client;
        }

        public async Task<ProjectDto[]> GetAsync()
        {
            return await Client.GetFromJsonAsync<ProjectDto[]>("api/Projects");
        }

        public async Task<ProjectDto> GetAsync(int projectId)
        {
            return await Client.GetFromJsonAsync<ProjectDto>($"api/Projects/{projectId}");
        }
    }
}
