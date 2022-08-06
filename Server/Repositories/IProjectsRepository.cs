using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public interface IProjectsRepository
    {
        public IEnumerable<ProjectDto> GetProjects();
        public ProjectDto GetProject(int projectId);
        public ProjectDto DeleteProject (int projectId);
        public ProjectDto AddProject(ProjectDto projectDto);
        public ProjectDto ModifyProject(int projectId, ProjectDto projectDto);
        public bool SaveChanges();
    }
}
