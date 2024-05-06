using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductQueries _productQueries;

        public ProductService(IProductQueries productQueries)
        {
            _productQueries = productQueries;
        }

        public List<Product> RetrieveProduct(string categoryName)
        {
            return _productQueries.RetrieveProducts(categoryName);
        }
    }
}
