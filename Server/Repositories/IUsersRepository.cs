using Stroom.Shared.Models;

namespace Stroom.Server.Repositories
{
    public interface IUsersRepository
    {
        public IEnumerable<User> Get();
        public User Get(int userId);
        public User Delete(int userId);
        public User Add(User user);
        public bool SaveChanges();
    }
}
