using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stroom.Shared.Enums.TaskPropertiesEnums;

namespace Stroom.Shared.Models
{
    public class TaskDto
    {
        public int TaskID { get; set; } = 1404;
        public string Name { get; set; } = "Laborum adipisicing culpa";
        public string Description { get; set; } = "Elit nisi ad excepteur aliquip cupidatat aliquip occaecat consectetur ex. Non culpa laborum pariatur mollit anim et nisi quis sint enim consequat fugiat consequat labore. Occaecat Lorem dolore irure esse et est adipisicing deserunt.";
        public User Assignee { get; set; } = new User();
        public TaskPriority Priority { get; set; } = TaskPriority.Low;
        public Enums.TaskPropertiesEnums.TaskStatus Status { get; set; } = Enums.TaskPropertiesEnums.TaskStatus.New;
        public float EstimatedTime { get; set; } = 1;
        public float WorkedTime => TimeEntries?.Sum(timeEntry => timeEntry.Hours) ?? 0;
        public DateTime? SubmitionDate { get; set; } = DateTime.Today;
        public DateTime? DueDate { get; set; } = DateTime.Today.AddDays(1);
        public ProjectDto Project { get; set; } = new ProjectDto();
        public virtual List<CommentDto> Comments { get; set; } = new List<CommentDto>();
        public virtual List<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
    }
}
