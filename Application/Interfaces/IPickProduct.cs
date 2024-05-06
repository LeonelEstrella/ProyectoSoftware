using AccessData.DataBaseInfraestructure.Entities;
using Application.Models;

namespace Application.Interfaces
{
    public interface IPickProduct
    {
       public IList<ProductSaledDTO> AddProductToShoppingCart(List<Product> productList);
    }
}
