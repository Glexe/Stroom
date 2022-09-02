using Stroom.Server.Contexts;
using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public class ProjectsRepository : IProjectsRepository
    {
        private readonly ApplicationDbContext ApplicationDbContext;

        public ProjectsRepository(ApplicationDbContext taskContext)
        {
            ApplicationDbContext = taskContext;
        }

        public ProjectDto Add(ProjectDto projectDto)
        {
            ApplicationDbContext.Add(projectDto);
            return projectDto;
        }

        public ProjectDto Delete(int projectId)
        {
            throw new NotImplementedException();
        }

        public string GenerateInvitationToken(int projectId)
        {
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            return Convert.ToBase64String(time.Concat(key).ToArray());
        }

        public ProjectDto Get(int projectId)
        {
            return ApplicationDbContext.Projects.Find(projectId);
        }

        public IEnumerable<ProjectDto> Get()
        {
            return ApplicationDbContext.Projects.ToList();
        }

        public ProjectDto Modify(int projectId, ProjectDto projectDto)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return ApplicationDbContext.SaveChanges() == 1;
        }
    }
}
