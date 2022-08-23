using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroom.Shared.Enums
{
    public class UserPropertiesEnums
    {
        public static IEnumerable<UserRole> UserRoles { get; set; } = Enum.GetValues(typeof(UserRole)).OfType<UserRole>();
        public enum UserRole
        {
            Unassigned = 0,
            Tester = 1,
            Developer = 2,
            PM = 3,
            Admin = 4
        }
    }
}
