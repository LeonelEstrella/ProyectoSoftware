using AccessData.DataBaseInfraestructure.Entities;

namespace Application.Interfaces
{
    public interface IProductDictionary
    {
        Dictionary<Product, int> AddProductToDictionary(Dictionary<Product, int> selectedProducts, Dictionary<Product, int> productList);
    }
}
