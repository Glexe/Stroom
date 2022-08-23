using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroom.Shared.Enums
{
    public class TaskPropertiesEnums
    {
        public static IEnumerable<TaskPriority> TaskPriorities { get; set; } = Enum.GetValues(typeof(TaskPriority)).OfType<TaskPriority>();
        public static IEnumerable<TaskStatus> TaskStatuses { get; set; } = Enum.GetValues(typeof(TaskStatus)).OfType<TaskStatus>();
        public enum TaskPriority
        {
            Low = 0,
            Normal = 1,
            High = 2,
            Critical = 3,
            Blocking = 4
        }

        public enum TaskStatus
        {
            New = 0,
            Ongoing = 1,
            Testing = 2,
            Completed = 3,
            Quotation = 4,
            Accepted = 5,
            Declined = 6
        }
    }
}
