using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public class TestBugsRepository : IBugsRepository
    {
        private readonly List<Bug> TestBugs = new()
        {
            new Bug(){ Name = "Change something" },
            new Bug(){ Name = "Fix some troubles" },
            new Bug(){ Name = "Add new functionality" }
        };

        public Bug AddBug(Bug bug)
        {
            throw new NotImplementedException();
        }

        public Bug DeleteBug(int bugId)
        {
            throw new NotImplementedException();
        }

        public Bug GetBug(int bugId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bug> GetBugs()
        {
            return TestBugs;
        }

        public Bug ModifyBug(int bugId, Bug bug)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
