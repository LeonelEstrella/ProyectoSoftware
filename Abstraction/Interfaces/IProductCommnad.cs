using Domain.Interfaces;

namespace Abstraction.Interfaces
{
    public interface IProductCommnad
    {
        Task InsertProduct(Product product);
    }
}
