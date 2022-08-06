using Stroom.Shared.Models;

namespace Stroom.Client.Services
{
    public interface IProjectsService
    {
        public Task<ProjectDto[]> GetAsync();
    }
}
