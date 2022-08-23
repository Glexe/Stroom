using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public interface ITasksRepository
    {
        public IEnumerable<TaskDto> Get();
        public TaskDto Get(int taskId);
        public TaskDto Delete(int taskId);
        public TaskDto Add(TaskDto task);
        public TaskDto Modify(int taskId, TaskDto task);
        public bool SaveChanges();
    }
}
