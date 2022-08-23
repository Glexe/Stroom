using Stroom.Shared.Models;

namespace Stroom.Client.Services
{
    public interface IProjectsService
    {
        public Task<ProjectDto[]> GetAsync();
        public Task<ProjectDto> GetAsync(int projectId);
    }
}
