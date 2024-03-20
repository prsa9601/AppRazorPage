using AppRazorPage.Infrastructure.RazorUtils;
using AppRazorPage.Services.Roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using AppRazorPage.Models.Role;
using Eshop.RazorPage.Infrastructure;
using Eshop.RazorPage.Infrastructure.Utils;

namespace AppRazorPage.Pages.Admin.Role
{
    public class AddModel : BaseRazorPage
    {
        private readonly IRoleService _roleService;

        public AddModel(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [BindProperty]
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} را وارد کنید")]
        public string Title { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost(string[] permission)
        {
            var permissionModel = new List<Permission>();
            try
            {
                foreach (var item in permission)
                {
                    permissionModel.Add(EnumUtils.ParseEnum<Permission>(item));
                }
            }
            catch 
            {
                //
            }

            var result = await _roleService.AddRole(new CreateRoleCommand()
            {
                Title = Title,
                Permissions = permissionModel
            });
            return RedirectAndShowAlert(result, RedirectToPage("roles"));
        }
    }
}
