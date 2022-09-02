using Stroom.Server.Contexts;
using Stroom.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Stroom.Server.Repositories
{
    public class UserRolesRepository : IUserRolesRepository
    {
        private readonly ApplicationDbContext ApplicationDbContext;

        public UserRolesRepository(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }

        public void Add(UserRoleDto userRole)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserRoleDto> Get()
        {
            throw new NotImplementedException();
        }

        public void Modify(UserRoleDto userRole)
        {
            ApplicationDbContext.UserRoles.Update(userRole);
        }

        public bool SaveChanges()
        {
            return ApplicationDbContext.SaveChanges() == 1;
        }
    }
}
