using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public interface IBugsRepository
    {
        public IEnumerable<Bug> GetBugs();
        public Bug GetBug(int bugId);
        public Bug DeleteBug(int bugId);
        public Bug AddBug(Bug bug);
        public Bug ModifyBug(int bugId, Bug bug);
        public bool SaveChanges();
    }
}
