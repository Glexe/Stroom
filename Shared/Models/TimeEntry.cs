using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroom.Shared.Models
{
    public class TimeEntry
    {
        public DateTime? Date { get; set; }
        public float Hours { get; set; }
        public TaskDto Task { get; set; }
        public int? TaskID { get; set; }
        public User User { get; set; }
        public int? UserID { get; set; }
    }
}
