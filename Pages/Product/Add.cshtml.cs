using System.ComponentModel.DataAnnotations;
using AppRazorPage.Infrastructure.RazorUtils;
using AppRazorPage.Models.Product;
using AppRazorPage.Services.Products;
using Eshop.RazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppRazorPage.Pages.Product
{
    [BindProperties]
    public class AddModel : BaseRazorPage
    {
        private readonly IProductService _service;

        public AddModel(IProductService service)
        {
            _service = service;
        }
        [Required(ErrorMessage = "jj")]
        public string Price { get; set; }
        [Required(ErrorMessage = "jj")]
        public string Title { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            var result = await _service.AddProduct(new AddProductCommand()
            {
                Title = Title,
                Price = Price
            });
            return RedirectAndShowAlert(result, RedirectToPage("products"));
        }
    }
}
