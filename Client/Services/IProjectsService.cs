using Stroom.Shared.Models;

namespace Stroom.Client.Services
{
    public interface IProjectsService
    {
        public Task<ProjectDto[]> GetAsync();
        public Task<ProjectDto> GetAsync(int projectId);
        public Task<string> GenerateInvitationLink(int projectId);
        public Task<ProjectDto> AddUserToProject(int projectId, string token);
    }
}
