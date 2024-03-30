using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;

namespace RetailStore.Interfaces
{
    public interface IPickProduct
    {
       public List<Product> AddProductToShoppingCart(IProductService productService, List<ICategoryOptions.Categories> categoryValues, int selectedCategoryIndex, IProductQueries productQueries, List<Product> productList);
    }
}
