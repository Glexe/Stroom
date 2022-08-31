using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroom.Shared.Models
{
    public class TimeEntry
    {
        public int TimeEntryID { get; set; }
        public DateTime? Date { get; set; } = DateTime.Now;
        public float Hours { get; set; } = 1;
        public TaskDto Task { get; set; } = new TaskDto();
        public int? TaskID { get; set; }
        public User User { get; set; } = new User();
        public int? UserID { get; set; }
    }
}
