using Stroom.Shared.Models;

namespace Stroom.Client.Services
{
    public interface ICommentsService
    {
        public Task<CommentDto[]> GetAsync(int taskId);
        public Task<CommentDto[]> GetAsync();
        public void AddAsync(CommentDto comment);
    }
}
