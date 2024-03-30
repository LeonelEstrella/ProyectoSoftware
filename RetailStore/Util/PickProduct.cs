using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;
using RetailStore.Interfaces;
using RetailStore.MenuBuilder.Interfaces;

namespace RetailStore.Util
{
    public class PickProduct : IPickProduct
    {
        public  void AddProductToShoppingCart(IProductService productService, List<ICategoryOptions.Categories> categoryValues, int selectedCategoryIndex, IProductQueries productQueries, List<Product> productList)
        {
            Console.Clear();
            Console.WriteLine("Escriba parte o el nombre del producto para agregar al carrito:\n");
            var selectedCategory = categoryValues[selectedCategoryIndex - 1];
            productService.RetrieveProduct(productQueries, selectedCategory.ToString());
        }
    }
}
