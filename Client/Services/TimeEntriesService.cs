 using Stroom.Shared.Models;
using System.Net.Http.Json;

namespace Stroom.Client.Services
{
    public class TimeEntriesService : ITimeEntriesService
    {
        private readonly HttpClient Client;

        public TimeEntriesService(HttpClient client)
        {
            Client = client;
        }

        public async Task<TimeEntry[]> GetAsync()
        {
            return await Client.GetFromJsonAsync<TimeEntry[]>("api/TimeEntries");
        }
    }
}
