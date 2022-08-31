using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroom.Shared.Models
{
    public class CommentDto
    {
        public int CommentID { get; set; } = 1;
        public string Comment { get; set; } = "Non culpa laborum pariatur mollit anim et nisi quis sint enim consequat";
        public DateTime TimeStamp { get; set; } = new DateTime(2021, 07, 29, 14, 37, 12);
        public User User { get; set; } = new User();
        public int? UserID { get; set; } = 1;
        public TaskDto Task { get; set; } = new TaskDto();
        public int? TaskID { get; set; } = 1;
    }
}