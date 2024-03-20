using AppRazorPage.Models.Product;
using AppRazorPage.Models.Role;
using Eshop.RazorPage.Models;

namespace AppRazorPage.Services.Roles
{
    public class RoleService : IRoleService
    {
        private readonly HttpClient _client;
        private const string ModuleName = "Role";

        public RoleService(HttpClient client)
        {
            _client = client;
        }

        public async Task<ApiResult> AddRole(CreateRoleCommand command)
        {
            var result = await _client.PostAsJsonAsync(ModuleName, command);
            return await result.Content.ReadFromJsonAsync<ApiResult>();
        }

        public async Task<ApiResult> EditRole(EditRoleCommand command)
        {
            
            var result = await _client.PutAsJsonAsync(ModuleName, command);
            return await result.Content.ReadFromJsonAsync<ApiResult>();
        }

        public async Task<ApiResult> DeleteRole(DeleteRoleCommand command)
        {
            var result = await _client.DeleteAsync($"{ModuleName}/{command.RoleId}");
            return await result.Content.ReadFromJsonAsync<ApiResult>();
        }

        public async Task<ApiResult> AddUserRole(SetUserRoleCommand command)
        {
            var result = await _client.PostAsJsonAsync($"{ModuleName}/addUserRole" ,command );
            return await result.Content.ReadFromJsonAsync<ApiResult>();
        }

        public async Task<RoleDto> GetRoleById(long roleId)
        {
            var result = await _client.GetFromJsonAsync<ApiResult<RoleDto>>($"{ModuleName}/{roleId}");
            return result.Data;
        }
        public async Task<RoleFilterResult> GetRolesByFilter(RoleFilterParams filterParams)
        {
            var url = $"{ModuleName}/GetByFilter?pageId={filterParams.PageId}&take={filterParams.Take}";

            if (filterParams.Title != null)
                url += $"title={filterParams.Title}";

            if (filterParams.RoleId != null)
                url += $"&roleId={filterParams.RoleId}";
            var result = await _client.GetFromJsonAsync<ApiResult<RoleFilterResult>>(url);
            return result?.Data;
        }
        public async Task<List<RoleDto>> GetRoles()
        {
            var result = await _client.GetFromJsonAsync<ApiResult<List<RoleDto>>>($"{ModuleName}");
            return result.Data;
        }
    }
}
