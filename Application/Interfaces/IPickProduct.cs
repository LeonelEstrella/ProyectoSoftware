using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;

namespace Application.Interfaces
{
    public interface IPickProduct
    {
       public IList<Product> AddProductToShoppingCart(IProductService productService, IList<ICategoryOptions.Categories> categoryValues, int selectedCategoryIndex, IProductQueries productQueries, IList<Product> productList);
    }
}
