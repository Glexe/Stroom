using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stroom.Shared.Enums.UserPropertiesEnums;

namespace Stroom.Shared.Models
{
    public class User
    {
        public int UserID { get; set; } = 1202;
        public string Name { get; set; } = "Hlib";
        public string Surname { get; set; } = "Pivniev";
        public string FullName => $"{Name} {Surname}";
        public string Email { get; set; } = "gl.pvn@gmail.com";
        public UserRole Role { get; set; } = UserRole.Developer;
        public virtual IEnumerable<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
        public virtual IEnumerable<TaskDto> Tasks { get; set; } = new List<TaskDto>();
        public virtual IEnumerable<ProjectDto> Projects { get; set; } = new List<ProjectDto>();
        public virtual IEnumerable<CommentDto> Comments { get; set; } = new List<CommentDto>();


        public override bool Equals(object o)
        {
            var other = o as User;
            return other?.FullName == FullName && other?.UserID == UserID && other?.Email == Email;
        }

        public override int GetHashCode() => FullName?.GetHashCode() ?? 0;

        public override string ToString() => FullName;
    }
}
