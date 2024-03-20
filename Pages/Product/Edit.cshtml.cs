using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using AppRazorPage.Infrastructure.RazorUtils;
using AppRazorPage.Services.Products;
using AppRazorPage.Models.Product;
using Eshop.RazorPage.Models;

namespace AppRazorPage.Pages.Product
{
    [BindProperties]
    public class EditModel : BaseRazorPage
    {
        private readonly IProductService _service;

        public EditModel(IProductService service)
        {
            _service = service;
        }
        [Required(ErrorMessage = "jj")]
        public string Price { get; set; }
        [Required(ErrorMessage = "jj")]
        public string Title { get; set; }
        public async Task<IActionResult> OnGet(long productId)
        {
            var product = await _service.GetProductById(productId);
            Title = product.Title;
            Price = product.Price;
            return Page();
        }
        public async Task<IActionResult> OnPost(long productId)
        {
            var result = await _service.EditProduct(new EditProductCommand()
            {
                Title = Title,
                ProductId = productId,
                Price = Price
            });
            return RedirectAndShowAlert(result, RedirectToPage("products"));
        }

    }
}
