using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Models;

namespace Application.Interfaces
{
    public interface IPickProduct
    {
       public IList<ProductSaledDTO> AddProductToShoppingCart(IProductService productService, IList<ICategoryOptions.Categories> categoryValues, int selectedCategoryIndex, IProductQueries productQueries, IList<ProductSaledDTO> productList);
    }
}
