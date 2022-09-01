using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stroom.Shared.Enums.TaskPropertiesEnums;

namespace Stroom.Shared.Models
{
    public class AddTaskRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskPriority Priority { get; set; }
        public Enums.TaskPropertiesEnums.TaskStatus Status { get; set; }
        public float? EstimatedTime { get; set; }
        public DateTime? SubmitionDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int AssigneeID { get; set; }
        public int ProjectID { get; set; }
    }
}
