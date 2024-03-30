using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        public List<Product>  RetrieveProduct(IProductQueries productService, string categoryName)
        {
            return productService.RetrieveProducts(categoryName);
        }
    }
}
