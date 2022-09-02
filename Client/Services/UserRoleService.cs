 using Stroom.Shared.Models;
using System.Net.Http.Json;

namespace Stroom.Client.Services
{
    public class UserRoleService : IUserRoleService
    {
        private readonly HttpClient Client;

        public UserRoleService(HttpClient client)
        {
            Client = client;
        }

        public async void AddAsync(UserRoleDto userRoleDto)
        {
            var result = await Client.PostAsJsonAsync<UserRoleDto>("api/UserRoles", userRoleDto);
            var test = result.Content.ReadAsStringAsync().Result;
        }

        public async void Modify(UserRoleDto userRole)
        {
            var userRoleClone = UserRoleDto.Clone(userRole);
            userRoleClone.User.Projects.Clear();
            userRoleClone.User.Comments.Clear();
            userRoleClone.User.TimeEntries.Clear();
            userRoleClone.User.UserRoles.Clear();
            userRoleClone.Project.UserRoles.Clear();
            userRoleClone.Project.UserRoles.Clear();
            await Client.PostAsJsonAsync<UserRoleDto>("api/UserRoles/modify", userRoleClone);
        }

        async Task<UserRoleDto[]> IUserRoleService.GetAsync()
        {
            return await Client.GetFromJsonAsync<UserRoleDto[]>($"api/UserRoles");
        }
    }
}
