using Stroom.Shared.Models;

namespace Stroom.Client.Services
{
    public interface ITimeEntriesService
    {
        public Task<TimeEntry[]> GetAsync();
        public void AddAsync(TimeEntry timeEntry);
    }
}
