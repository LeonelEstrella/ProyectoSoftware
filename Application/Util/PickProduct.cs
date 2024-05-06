using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;
using Application.Models;

namespace Application.Util
{
    public class PickProduct : IPickProduct
    {
        public IList<ProductSaledDTO> AddProductToShoppingCart(IProductService productService, IList<ICategoryOptions.Categories> categoryValues, int selectedCategoryIndex, IProductQueries productQueries, IList<ProductSaledDTO> buyProductList)
        {
            Console.Clear();

            var selectedCategory = categoryValues[selectedCategoryIndex - 1].ToString().Replace("_", " ");
            var productListByCategory = productService.RetrieveProduct(productQueries, selectedCategory.ToString());
            
            Console.WriteLine("Escriba parte del nombre del producto (mínimo 8 caracteres) para agregarlo al carrito o pulse ENTER para volver atras:\n");
            string inputString = Console.ReadLine();

            if (inputString != "" && inputString.Length >= 8)
            {
                Console.WriteLine("Ingrese la cantidad de productos que desea agregar:");
                int quantity;

                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Cantidad inválida. Intente de nuevo:");
                }

                buyProductList = ChooseProduct(inputString, productListByCategory, buyProductList, quantity);
            }

            else { Console.WriteLine("No se ingreso el mínimo de palabras requerido"); Thread.Sleep(2000); }        

            return buyProductList;
        }

        private IList<ProductSaledDTO> ChooseProduct(string productName, IList<Product> productList, IList<ProductSaledDTO> buyProductList, int quantity)
        {
            var currentlyBuyProductList = buyProductList.Count; 

            foreach (var product in productList)
            {
                if (product.Name.ToLower().Contains(productName.ToLower()))
                {
                    buyProductList.Add(new ProductSaledDTO
                    {
                        ProductId = product.ProductId,
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        Discount = product.Discount,
                        Category = product.Category,
                        ImageUrl = product.ImageUrl,
                        Quantity = quantity
                    });

                    Console.WriteLine("Producto agregado al carrito!");
                    Thread.Sleep(700);
                }
            }

            if (currentlyBuyProductList == buyProductList.Count) 
            { 
                Console.WriteLine("No se agregó ningún producto al carrito. Intente ingresar correctament el nombre del producto.");
                Thread.Sleep(700);
            }

            return buyProductList;
        }
    }
}
