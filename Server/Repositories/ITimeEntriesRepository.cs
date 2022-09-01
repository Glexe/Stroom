using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public interface ITimeEntriesRepository
    {
        public IEnumerable<TimeEntry> Get();
        public TimeEntry Delete (TimeEntry timeEntry);
        public TimeEntry Add(TimeEntry timeEntry);
        public bool SaveChanges();
    }
}
