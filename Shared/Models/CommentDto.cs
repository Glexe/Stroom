using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroom.Shared.Models
{
    public class CommentDto
    {
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
        public virtual User User { get; set; }
        public int? UserID { get; set; }
        public virtual TaskDto Task { get; set; }
        public int? TaskID { get; set; }
    }
}