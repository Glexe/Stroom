using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public interface IProjectsRepository
    {
        public IEnumerable<ProjectDto> Get();
        public ProjectDto Get(int projectId);
        public ProjectDto Delete (int projectId);
        public ProjectDto Add(ProjectDto projectDto);
        public ProjectDto Modify(int projectId, ProjectDto projectDto);
        public string GenerateInvitationToken(int projectId);
        public bool SaveChanges();
    }
}
