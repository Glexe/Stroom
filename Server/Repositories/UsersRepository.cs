using Stroom.Server.Contexts;
using Stroom.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Stroom.Server.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationDbContext ApplicationDbContext;

        public UsersRepository(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }

        public User Add(User user)
        {
            throw new NotImplementedException();
        }

        public User Delete(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get()
        {
            var users = ApplicationDbContext.Users.ToList();
            foreach (var user in users)
            {
                user.UserRoles = ApplicationDbContext.UserRoles.AsNoTracking().IgnoreAutoIncludes().Where(e => e.UserID == user.UserID).ToList();
            }
            return users;
        }

        public User Get(int userId)
        {
            var user = ApplicationDbContext.Users.Find(userId);
            user.UserRoles = ApplicationDbContext.UserRoles.AsNoTracking().IgnoreAutoIncludes().Where(e => e.UserID == user.UserID).ToList();
            return user;
        }

        public bool SaveChanges()
        {
            return ApplicationDbContext.SaveChanges() == 1;
        }
    }
}
