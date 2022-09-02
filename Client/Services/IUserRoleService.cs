using Stroom.Shared.Models;

namespace Stroom.Client.Services
{
    public interface IUserRoleService
    {
        public Task<UserRoleDto[]> GetAsync();
        public void AddAsync(UserRoleDto userRole);
        public void Modify(UserRoleDto userRole);
    }
}
