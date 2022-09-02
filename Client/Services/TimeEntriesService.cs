using Stroom.Server.Helpers;
using Stroom.Shared.Models;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Stroom.Client.Services
{
    public class TimeEntriesService : ITimeEntriesService
    {
        private readonly HttpClient Client;

        public TimeEntriesService(HttpClient client)
        {
            Client = client;
        }

        public async void AddAsync(TimeEntry timeEntrySource)
        {
            var timeEntry = new TimeEntry() { Hours = timeEntrySource.Hours, Date = timeEntrySource.Date, TaskID = timeEntrySource.Task.TaskID, UserID = timeEntrySource.Task.AssigneeID, Task = TaskDto.Clone(timeEntrySource.Task), User = User.Clone(timeEntrySource.User) };
            ValidateTimeEntry(timeEntry);
            var json = JsonSerializer.Serialize(timeEntry, new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.IgnoreCycles
            });
            byte[] messageBytes = System.Text.Encoding.UTF8.GetBytes(json);
            var content = new ByteArrayContent(messageBytes);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await Client.PostAsync("api/TimeEntries", content);
            var test = result.Content.ReadAsStringAsync().Result;
        }

        public async Task<TimeEntry[]> GetAsync()
        {
            return await Client.GetFromJsonAsync<TimeEntry[]>("api/TimeEntries");
        }

        private void ValidateTimeEntry(TimeEntry timeEntry)
        {
            //timeEntry.UserID = timeEntry.User.UserID;
            //timeEntry.TaskID = timeEntry.Task.TaskID;
            timeEntry.Task.TimeEntries.Clear();
            timeEntry.User.TimeEntries.Clear();
        }
    }
}
