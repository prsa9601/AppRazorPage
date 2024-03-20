//using Common.Query;

using Eshop.RazorPage.Infrastructure;
using Eshop.RazorPage.Models;

namespace AppRazorPage.Models.Role
{
    public class RoleFilterData : BaseDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Permission> permissions { get; set; }
    }
}
