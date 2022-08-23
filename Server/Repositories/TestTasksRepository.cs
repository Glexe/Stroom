using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public class TestTasksRepository : ITasksRepository
    {
        private readonly List<TaskDto> TestTasks = new()
        {
            new TaskDto(){ Name = "Change something", TimeEntries = new List<TimeEntry>(){ new TimeEntry() { Hours = 2, Date = DateTime.Now.AddDays(-2) }, new TimeEntry() { Hours = 5, Date = DateTime.Now.AddDays(-3) } } },
            new TaskDto(){ Name = "Fix some troubles" },
            new TaskDto(){ Name = "Add new functionality" }
        };

        public TaskDto Add(TaskDto task)
        {
            throw new NotImplementedException();
        }

        public TaskDto Delete(int taskId)
        {
            throw new NotImplementedException();
        }

        public TaskDto Get(int taskId)
        {
            return new TaskDto();
        }

        public IEnumerable<TaskDto> Get()
        {
            return TestTasks;
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
