using Stroom.Server.Contexts;
using Stroom.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Stroom.Server.Repositories
{
    public class TasksRepository : ITasksRepository
    {
        private readonly ApplicationDbContext ApplicationContext;

        public TasksRepository(ApplicationDbContext applicationContext)
        {
            ApplicationContext = applicationContext;
        }
        
        public TaskDto Add(TaskDto task)
        {
            ApplicationContext.Entry(task.Project).State = EntityState.Unchanged;
            ApplicationContext.Entry(task.Assignee).State = EntityState.Unchanged;
            ApplicationContext.Add(task);
            return task;
        }

        public TaskDto Delete(int taskId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskDto> Get()
        {
            return ApplicationContext.Tasks.Include(e => e.Project).ToList();            
        }

        public TaskDto Get(int taskId)
        {
            return ApplicationContext.Tasks.Include(e => e.Project).First(e => e.TaskID == taskId);
        }

        public TaskDto Modify(int taskId, TaskDto task)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return ApplicationContext.SaveChanges() == 1;
        }
    }
}
