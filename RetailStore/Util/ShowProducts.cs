
using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;
using RetailStore.Interfaces;

namespace RetailStore.Util
{
    public class ShowProducts : IShowProducts
    {
        private readonly IProductService _productService;

        public ShowProducts(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> ShowProductList(string categoryName, int selectedCategoryIndex)
        {
            Console.Clear();

            List<Product> productList = _productService.RetrieveProduct(categoryName);

            if(selectedCategoryIndex > 0)
            {
                foreach (var product in productList)
                {
                    Console.WriteLine($"ProductID: {product.ProductId}");
                    Console.WriteLine($"Name: {product.Name}");
                    Console.WriteLine($"Description: {product.Description}");
                    Console.WriteLine($"Price: {product.Price}");
                    Console.WriteLine($"Discount: {product.Discount}");
                    Console.WriteLine($"Category: {product.category.Name}");
                    Console.WriteLine(new string('-', Console.WindowWidth - 1));
                }

                Console.WriteLine("Escriba parte del nombre del producto (mínimo 8 caracteres) para agregarlo al carrito o pulse ENTER para volver atras:\n");
            }

            return productList;
        }
    }
}
