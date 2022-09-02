using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public interface ICommentsRepository
    {
        public IEnumerable<CommentDto> Get(int taskId);
        public IEnumerable<CommentDto> Get();
        public void Add(CommentDto comment);
        public bool SaveChanges();
    }
}
