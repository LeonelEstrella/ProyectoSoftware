using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;
using RetailStore.MenuBuilder.Interfaces;

namespace RetailStore.Interfaces
{
    public interface IPickProduct
    {
       public void AddProductToShoppingCart(IProductService productService, List<ICategoryOptions.Categories> categoryValues, int selectedCategoryIndex, IProductQueries productQueries, List<Product> productList);
    }
}
