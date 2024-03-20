using AppRazorPage.Infrastructure.RazorUtils;
using AppRazorPage.Models.Product;
using AppRazorPage.Models.Role;
using AppRazorPage.Services.Roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppRazorPage.Pages.Admin.Role
{
    public class RolesModel : BaseRazorFilter<RoleFilterParams>
    {
        private readonly IRoleService _service;
        public RolesModel(IRoleService service)
        {
            _service = service;
        }
        [BindProperty(SupportsGet = true)]
        public RoleFilterResult FilterResult { get; set; }

        public async Task OnGet(int pageId = 1, int take = 8)
        {
            FilterResult = await _service.GetRolesByFilter(new RoleFilterParams()
            {
                PageId = pageId,
                Take = take
            });
        }
        public void OnPost()
        {
        }
    }
}
