using Stroom.Shared.Models;

namespace Stroom.Client.Services
{
    public interface IUsersService
    {
        public Task<User[]> GetAsync();
        public Task<User> GetAsync(int userId);
    }
}
