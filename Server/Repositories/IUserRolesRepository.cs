using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public interface IUserRolesRepository
    {
        public IEnumerable<UserRoleDto> Get();
        public void Add(UserRoleDto userRole);
        public void Modify(UserRoleDto userRole);
        public bool SaveChanges();
    }
}
