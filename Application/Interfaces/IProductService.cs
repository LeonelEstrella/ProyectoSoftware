using AccessData.DataBaseInfraestructure.Entities;

namespace Application.Interfaces
{
    public interface IProductService
    {
        List<Product> RetrieveProduct(string categoryName);
        Product GetProductByName(string productName);
    }
}
