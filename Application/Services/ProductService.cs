using AccessData.Interfaces;

namespace Application.Services
{
    public class ProductService
    {
        public void  RetrieveProduct(IProductQueries productService, string categoryName)
        {
            productService.RetrieveProducts(categoryName);
        }
    }
}
