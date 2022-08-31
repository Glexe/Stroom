using Stroom.Server.Contexts;
using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public class TasksRepository : ITasksRepository
    {
        private readonly ApplicationDbContext TaskContext;

        public TasksRepository(ApplicationDbContext taskContext)
        {
            TaskContext = taskContext;
        }
        
        public TaskDto Add(TaskDto task)
        {
            throw new NotImplementedException();
        }

        public TaskDto Delete(int taskId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskDto> Get()
        {
            return TaskContext.Tasks.ToList();
        }

        public TaskDto Get(int taskId)
        {
            return TaskContext.Tasks.Find(taskId);
        }

        public TaskDto Modify(int taskId, TaskDto task)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
