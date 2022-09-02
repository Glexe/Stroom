using Stroom.Server.Contexts;
using Stroom.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Stroom.Server.Repositories
{
    public class CommentsRepository : ICommentsRepository
    {
        private readonly ApplicationDbContext ApplicationDbContext;

        public CommentsRepository(ApplicationDbContext applicationContext)
        {
            ApplicationDbContext = applicationContext;
        }

        public void Add(CommentDto comment)
        {
            ApplicationDbContext.Entry(comment.Task).State = EntityState.Unchanged;
            ApplicationDbContext.Entry(comment.User).State = EntityState.Unchanged;
            ApplicationDbContext.Add(comment);
        }

        public IEnumerable<CommentDto> Get(int taskId)
        {
            return ApplicationDbContext.Comments.Where(e => e.TaskID == taskId).ToList();
        }

        public IEnumerable<CommentDto> Get()
        {
            return ApplicationDbContext.Comments.ToList();
        }

        public bool SaveChanges()
        {
            return ApplicationDbContext.SaveChanges() == 1;
        }
    }
}
