using AppRazorPage.Models.Product;
using Eshop.RazorPage.Models;

namespace AppRazorPage.Services.Products
{
    public interface IProductService
    {
        Task<ApiResult> AddProduct(AddProductCommand command);
        Task<ApiResult> EditProduct(EditProductCommand command);
        Task<ProductDto?> GetProductById (long productId);
        Task<ProductFilterResult> GetProductByFilter(ProductFilterParams filterParams);
       //Task<ProductShopResult> GetProductForShop(ProductShopFilterParams filterParams);
        Task<ApiResult> DeleteProduct(long productId);
    }
}
