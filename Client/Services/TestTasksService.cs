using Newtonsoft.Json;
using Stroom.Shared.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Stroom.Client.Services
{
    public class TestTasksService : ITasksService
    {
        private readonly HttpClient Client;

        public TestTasksService(HttpClient client)
        {
            Client = client;
        }

        public async void AddAsync(TaskDto task)
        {
            ValidateTaskDto(task);

            await Client.PostAsJsonAsync<TaskDto>("api/Tasks", task);
        }

        public async Task<TaskDto[]> GetAsync()
        {
            return await Client.GetFromJsonAsync<TaskDto[]>("api/Tasks");
        }

        public async Task<TaskDto> GetAsync(int taskId)
        {
            return await Client.GetFromJsonAsync<TaskDto>($"api/Tasks/{taskId}");
        }

        private void ValidateTaskDto(TaskDto task)
        {
            if (task.Description is null) task.Description = "";
            if (task.AssigneeID == 0) task.AssigneeID = task.Assignee.UserID;
            if (task.ProjectID == 0) task.ProjectID = task.Project.ProjectID;
            if (task.TimeEntries is null) task.TimeEntries = new List<TimeEntry>();
            if (task.Comments is null) task.Comments = new List<CommentDto>();
        }
    }
}
