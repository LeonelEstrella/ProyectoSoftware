using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;

namespace RetailStore.Interfaces
{
    public interface IPickProduct
    {
       public IList<Product> AddProductToShoppingCart(IProductService productService, IList<ICategoryOptions.Categories> categoryValues, int selectedCategoryIndex, IProductQueries productQueries, IList<Product> productList);
    }
}
