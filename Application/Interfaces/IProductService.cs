using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;

namespace Application.Interfaces
{
    public interface IProductService
    {
        List<Product> RetrieveProduct(IProductQueries productService, string categoryName);
    }
}
