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
        public string Email { get; set; } = "gl.pvn@gmail.com";
        public UserRole Role { get; set; } = UserRole.Developer;
        public virtual IEnumerable<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
    }
}
