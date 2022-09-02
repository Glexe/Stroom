using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stroom.Shared.Enums.UserPropertiesEnums;

namespace Stroom.Shared.Models
{
    public class UserRoleDto
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public ProjectDto Project { get; set; }
        public int ProjectID { get; set; }
        public UserRole Role { get; set; }

        public static UserRoleDto Clone(UserRoleDto clone)
        {
            return new UserRoleDto()
            {
                UserID = clone.UserID,
                ProjectID = clone.ProjectID,
                Project = clone.Project,
                Role = clone.Role,
                User = clone.User
            };
        }
    }
}
