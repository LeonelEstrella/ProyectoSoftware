using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;
using RetailStore.Interfaces;

namespace RetailStore.Util
{
    public class PickProduct : IPickProduct
    {
        public List<Product> AddProductToShoppingCart(IProductService productService, List<ICategoryOptions.Categories> categoryValues, int selectedCategoryIndex, IProductQueries productQueries, List<Product> buyProductList)
        {
            bool finishBuy = false;

            while (!finishBuy) 
            {
                Console.Clear();
                Console.WriteLine("Escriba parte del nombre del producto para agregarlo al carrito o pulse ENTER para volver atras:\n");
                var selectedCategory = categoryValues[selectedCategoryIndex - 1];
                string inputString = Console.ReadLine();
                if (inputString != "")
                {
                    buyProductList = ChooseProduct(inputString, productService.RetrieveProduct(productQueries, selectedCategory.ToString()), buyProductList);
                }
                else {finishBuy = true;}              
            }

            return buyProductList;

        }

        private List<Product> ChooseProduct(string productName, List<Product> productList, List<Product> buyProductList)
        {
            foreach (var product in productList)
            {
                if (product.Name == productName) buyProductList.Add(product);
            }

            return buyProductList;
        }
    }
}
