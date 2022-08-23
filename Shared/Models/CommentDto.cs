using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroom.Shared.Models
{
    public class CommentDto
    {
        public string Comment { get; set; } = "Non culpa laborum pariatur mollit anim et nisi quis sint enim consequat";
        public DateTime TimeStamp { get; set; } = new DateTime(2021, 07, 29, 14, 37, 12);
        public User User { get; set; } = new User();
        public TaskDto Task { get; set; } = new TaskDto();
    }
}
