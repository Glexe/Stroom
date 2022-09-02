using Stroom.Server.Contexts;
using Stroom.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Stroom.Server.Repositories
{
    public class TasksRepository : ITasksRepository
    {
        private readonly ApplicationDbContext ApplicationDbContext;

        public TasksRepository(ApplicationDbContext applicationContext)
        {
            ApplicationDbContext = applicationContext;
        }
        
        public TaskDto Add(TaskDto task)
        {
            ApplicationDbContext.Entry(task.Project).State = EntityState.Unchanged;
            ApplicationDbContext.Entry(task.Assignee).State = EntityState.Unchanged;
            ApplicationDbContext.Add(task);
            return task;
        }

        public TaskDto Delete(int taskId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskDto> Get()
        {
            var tasks = ApplicationDbContext.Tasks.Include(e => e.Project).ToList();
            foreach (var task in tasks)
            {
                ResolveTaskReferences(task);
            }

            return tasks;
        }

        public TaskDto Get(int taskId)
        {
            var task = ApplicationDbContext.Tasks.Include(e => e.Project).First(e => e.TaskID == taskId);
            ResolveTaskReferences(task);

            return task;
        }

        private void ResolveTaskReferences(TaskDto task)
        {
            task.Assignee = ApplicationDbContext.Users.AsNoTracking().IgnoreAutoIncludes().First(e => e.UserID == task.AssigneeID);
            task.TimeEntries = ApplicationDbContext.TimeEntries.AsNoTracking().IgnoreAutoIncludes().Where(e => e.TaskID == task.TaskID).ToList();
            task.Comments = ApplicationDbContext.Comments.AsNoTracking().IgnoreAutoIncludes().Where(e => e.TaskID == task.TaskID).ToList();
            foreach (var comment in task.Comments)
            {
                comment.User = ApplicationDbContext.Users.AsNoTracking().IgnoreAutoIncludes().First(e => e.UserID == comment.UserID);
            }
        }

        public TaskDto Modify(int taskId, TaskDto task)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return ApplicationDbContext.SaveChanges() == 1;
        }

        public TaskDto Update(TaskDto task)
        {
            ApplicationDbContext.Entry(task.Project).State = EntityState.Unchanged;
            ApplicationDbContext.Entry(task.Assignee).State = EntityState.Unchanged;
            ApplicationDbContext.Update(task);
            return task;
        }
    }
}
