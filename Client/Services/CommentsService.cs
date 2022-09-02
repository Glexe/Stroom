 using Stroom.Shared.Models;
using System.Net.Http.Json;

namespace Stroom.Client.Services
{
    public class CommentsService : ICommentsService
    {
        private readonly HttpClient Client;

        public CommentsService(HttpClient client)
        {
            Client = client;
        }

        public async void AddAsync(CommentDto comment)
        {
            ValidateComment(comment);

            var result = await Client.PostAsJsonAsync<CommentDto>("api/Comments", comment);
            var test = result.Content.ReadAsStringAsync().Result;
        }

        public async Task<CommentDto[]> GetAsync()
        {
            return await Client.GetFromJsonAsync<CommentDto[]>("api/Comments");
        }

        async Task<CommentDto[]> ICommentsService.GetAsync(int taskId)
        {
            return await Client.GetFromJsonAsync<CommentDto[]>($"api/Comments/{taskId}");
        }

        private void ValidateComment(CommentDto comment)
        {
            comment.User.Comments = new List<CommentDto>();
            comment.Task.Comments = new List<CommentDto>();
            comment.User.TimeEntries = new List<TimeEntry>();
            comment.Task.TimeEntries = new List<TimeEntry>();
        }
    }
}
