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

        public Task<ProjectDto> AddUserToProject(int projectId, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GenerateInvitationLink(int projectId)
        {
            return await Client.GetStringAsync($"api/Projects/generate-invitation-token/{projectId}");
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
