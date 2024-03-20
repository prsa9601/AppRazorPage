

using Eshop.RazorPage.Models;

namespace AppRazorPage.Models.Product
{
    public class ProductFilterParams : BaseFilterParam
    {
        public long? ProductId { get; set; }
        public string? Title { get; set; }
    }
}
