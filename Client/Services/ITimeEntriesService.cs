using Stroom.Shared.Models;

namespace Stroom.Client.Services
{
    public interface ITimeEntriesService
    {
        public Task<TimeEntry[]> GetAsync();
    }
}
