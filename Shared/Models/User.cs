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
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";
        public string Email { get; set; }
        public virtual List<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
        public virtual List<TaskDto> Tasks { get; set; } = new List<TaskDto>();
        public virtual List<ProjectDto> Projects { get; set; } = new List<ProjectDto>();
        public virtual List<CommentDto> Comments { get; set; } = new List<CommentDto>();
        public virtual List<UserRoleDto> UserRoles { get; set; } = new List<UserRoleDto>();


        public override bool Equals(object o)
        {
            var other = o as User;
            return other?.FullName == FullName && other?.UserID == UserID && other?.Email == Email;
        }

        public override int GetHashCode() => FullName?.GetHashCode() ?? 0;

        public override string ToString() => FullName;

        public static User Clone(User clone)
        {
            return new User()
            {
                UserID = clone.UserID,
                Name = clone.Name,
                Surname = clone.Surname,
                Email = clone.Email,
                TimeEntries = clone.TimeEntries,
                Tasks = clone.Tasks,
                Projects = clone.Projects,
                Comments = clone.Comments,
                UserRoles = clone.UserRoles
            };
        }
    }
}
