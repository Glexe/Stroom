using Stroom.Server.Contexts;
using Stroom.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Stroom.Server.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationDbContext TaskContext;

        public UsersRepository(ApplicationDbContext taskContext)
        {
            TaskContext = taskContext;
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
            return TaskContext.Users.ToList();
        }

        public User Get(int userId)
        {
            return TaskContext.Users.Find(userId);
        }

        public bool SaveChanges()
        {
            return TaskContext.SaveChanges() == 1;
        }
    }
}
