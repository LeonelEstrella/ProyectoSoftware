using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;
using RetailStore.Interfaces;

namespace RetailStore.Util
{
    public class PickProduct : IPickProduct
    {
        public IList<Product> AddProductToShoppingCart(IProductService productService, IList<ICategoryOptions.Categories> categoryValues, int selectedCategoryIndex, IProductQueries productQueries, IList<Product> buyProductList)
        {
            //bool finishBuy = false;

            //while (!finishBuy) 
            //{
                Console.Clear();
                var selectedCategory = categoryValues[selectedCategoryIndex - 1];
                var productListByCategory = productService.RetrieveProduct(productQueries, selectedCategory.ToString());
                Console.WriteLine("Escriba parte del nombre del producto para agregarlo al carrito o pulse ENTER para volver atras:\n");
                string inputString = Console.ReadLine();
                if (inputString != "")
                {
                    buyProductList = ChooseProduct(inputString, productListByCategory, buyProductList);
                }
                //else {finishBuy = true;}              
            //}

            return buyProductList;

        }

        private IList<Product> ChooseProduct(string productName, IList<Product> productList, IList<Product> buyProductList)
        {
            foreach (var product in productList)
            {
                if (product.Name.ToLower().Contains(productName.ToLower())) buyProductList.Add(product);
            }

            return buyProductList;
        }
    }
}
