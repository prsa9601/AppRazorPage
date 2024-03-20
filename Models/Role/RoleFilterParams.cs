

using Eshop.RazorPage.Models;

namespace AppRazorPage.Models.Role
{
    public class RoleFilterParams : BaseFilterParam
    {
        public long? RoleId { get; set; }
        public string? Title { get; set; }
    }
}
