using AccessData.DataBaseInfraestructure.Entities;

namespace Application.Interfaces
{
    public interface ISaleSelectedProducts
    {
        (Sale, Boolean) SaleAProduct(Dictionary<Product, int> productList);
    }
}
