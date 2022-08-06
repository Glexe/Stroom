using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public class TestProjectsRepository : IProjectsRepository
    {
        private readonly List<ProjectDto> TestProjects = new()
        {
            new ProjectDto(){ Name = "Moon colony" },
            new ProjectDto(){ Name = "Venus expedition" },
            new ProjectDto(){ Name = "Mars terraforming" }
        };

        public ProjectDto AddProject(ProjectDto projectDto)
        {
            throw new NotImplementedException();
        }

        public ProjectDto DeleteProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public ProjectDto GetProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectDto> GetProjects()
        {
            return TestProjects;
        }

        public ProjectDto ModifyProject(int projectId, ProjectDto projectDto)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
