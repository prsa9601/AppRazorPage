using Eshop.RazorPage.Infrastructure;

namespace AppRazorPage.Models.Role
{
    public class CreateRoleCommand
    {
        public string Title  { get; set; }
        public List<Permission> Permissions  { get; set; }
    }
}
