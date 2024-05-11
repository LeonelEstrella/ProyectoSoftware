using AccessData.DataBaseInfraestructure.Entities;

namespace AccessData.Interfaces
{
    public interface IProductQueries
    {
        List<Product> RetrieveProducts(string categoryName);
        Product GetProductByName(string productName);
    }
}
