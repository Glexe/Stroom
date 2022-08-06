using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroom.Shared.Enums
{
    public class BugPropertiesEnums
    {
        public static IEnumerable<BugPriority> BugPriorities { get; set; } = Enum.GetValues(typeof(BugPriority)).OfType<BugPriority>();
        public static IEnumerable<BugStatus> BugStatuses { get; set; } = Enum.GetValues(typeof(BugStatus)).OfType<BugStatus>();
        public enum BugPriority
        {
            Low = 0,
            Normal = 1,
            High = 2,
            Critical = 3,
            Blocking = 4
        }

        public enum BugStatus
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
