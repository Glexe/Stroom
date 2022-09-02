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
        public int TaskID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskPriority Priority { get; set; }
        public Enums.TaskPropertiesEnums.TaskStatus Status { get; set; }
        public float? EstimatedTime { get; set; }
        public float WorkedTime => TimeEntries?.Sum(timeEntry => timeEntry?.Hours) ?? 0;
        public DateTime? SubmitionDate { get; set; }
        public DateTime? DueDate { get; set; }
        public User Assignee { get; set; }
        public int AssigneeID { get; set; }
        public ProjectDto Project { get; set; }
        public int ProjectID { get; set; }
        public virtual List<CommentDto> Comments { get; set; } = new List<CommentDto>();
        public virtual ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
    }
}
