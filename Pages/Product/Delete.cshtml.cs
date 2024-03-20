using AppRazorPage.Infrastructure.RazorUtils;
using AppRazorPage.Services.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppRazorPage.Pages.Product
{
    public class DeleteModel : BaseRazorPage
    {
        private readonly IProductService _service;

        public DeleteModel(IProductService service)
        {
            _service = service;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostDeleteProduct(long productId)
        {
            return await AjaxTryCatch(() => { return _service.DeleteProduct(productId); });
            //var result =  _service.DeleteProduct(productId);
            //return RedirectToPage("Products");
            //return RedirectToAction("OnGet","Products");
        }
    }
}
