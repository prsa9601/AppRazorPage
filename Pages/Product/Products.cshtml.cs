using AppRazorPage.Infrastructure.RazorUtils;
using AppRazorPage.Models.Product;
using AppRazorPage.Services.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppRazorPage.Pages.Product
{
    
    public class ViewProductModel : BaseRazorFilter<ProductFilterParams> 
    {
        [BindProperty(SupportsGet = true)]
        public ProductFilterResult FilterResult { get; set; }
       
        //public string Title { get; set; }
        //public DateTime CreationDate { get; set; }
        //public string Price { get; set; }
        private readonly IProductService _service;

        public ViewProductModel(IProductService service)
        {
            _service = service;
        }

        public async Task OnGet(int pageId=1,int take=8)
        {
            FilterResult = await _service.GetProductByFilter(new ProductFilterParams()
            {
                PageId = pageId,
                Take = take
            });
        }   
      
 
        //public async Task<IActionResult> OnPostDeleteProduct(long productId)
        //{
        //     return await AjaxTryCatch(() => { return _service.DeleteProduct(productId); });
        //   //var result =  _service.DeleteProduct(productId);
        //   //return RedirectToPage("Products");
        //   //return RedirectToAction("OnGet","Products");
        //}
    }
}
