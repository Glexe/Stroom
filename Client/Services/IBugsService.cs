using Stroom.Shared.Models;

namespace Stroom.Client.Services
{
    public interface IBugsService
    {
        public Task<Bug[]> GetAsync();
    }
}
