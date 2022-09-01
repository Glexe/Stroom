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
        public TaskDto Task { get; set; }
        public int TaskID { get; set; }
        public UserRole Role { get; set; }
    }
}
