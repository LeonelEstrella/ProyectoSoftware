using AccessData.DataBaseInfraestructure.Entities;

namespace AccessData.Interfaces
{
    public interface IProductQueries
    {
        public List<Product> RetrieveProducts(string categoryName);
    }
}
