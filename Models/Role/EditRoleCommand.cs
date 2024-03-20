using Eshop.RazorPage.Infrastructure;

namespace AppRazorPage.Models.Role
{
    public class EditRoleCommand 
    {
        public long RoleId  { get; set; }
        public string Title { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}
