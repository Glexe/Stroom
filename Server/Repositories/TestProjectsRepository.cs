using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public class TestProjectsRepository : IProjectsRepository
    {
        private readonly List<ProjectDto> TestProjects = new()
        {
            new ProjectDto(){ ProjectID = 1, Name = "Moon colony" },
            new ProjectDto(){ ProjectID = 2, Name = "Venus expedition" },
            new ProjectDto(){ ProjectID = 3, Name = "Mars terraforming" }
        };

        public ProjectDto Add(ProjectDto projectDto)
        {
            throw new NotImplementedException();
        }

        public ProjectDto Delete(int projectId)
        {
            throw new NotImplementedException();
        }

        public ProjectDto Get(int projectId)
        {
            return TestProjects.FirstOrDefault(project => project.ProjectID == projectId);
        }

        public IEnumerable<ProjectDto> Get()
        {
            return TestProjects;
        }

        public ProjectDto Modify(int projectId, ProjectDto projectDto)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
