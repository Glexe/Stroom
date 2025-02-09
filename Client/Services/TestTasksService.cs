﻿using Newtonsoft.Json;
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

            var res = await Client.PostAsJsonAsync<TaskDto>("api/Tasks", task);
            var test = res.Content.ReadAsStringAsync().Result;
        }

        public async Task<TaskDto[]> GetAsync()
        {
            return await Client.GetFromJsonAsync<TaskDto[]>("api/Tasks");
        }

        public async Task<TaskDto> GetAsync(int taskId)
        {
            return await Client.GetFromJsonAsync<TaskDto>($"api/Tasks/{taskId}");
        }

        public async void Update(TaskDto task)
        {
            var taskClone = TaskDto.Clone(task);
            ValidateTaskDto(taskClone);

            var result = await Client.PostAsJsonAsync<TaskDto>("api/Tasks/update", taskClone);
            var test = result.Content.ReadAsStringAsync().Result;
        }

        private void ValidateTaskDto(TaskDto task)
        {
            if (task.Description is null) task.Description = "";
            if (task.AssigneeID == 0) task.AssigneeID = task.Assignee.UserID;
            if (task.ProjectID == 0) task.ProjectID = task.Project.ProjectID;
            task.TimeEntries = new List<TimeEntry>();
            task.Comments = new List<CommentDto>();
            task.Assignee.UserRoles = new List<UserRoleDto>();
        }
    }
}
