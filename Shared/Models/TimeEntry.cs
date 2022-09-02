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
        public DateTime? Date { get; set; }
        public float Hours { get; set; }
        public virtual TaskDto Task { get; set; }
        public int? TaskID { get; set; }
        public virtual User User { get; set; }
        public int? UserID { get; set; }
    }
}
