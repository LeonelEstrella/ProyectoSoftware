using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;
using Application.Models;

namespace Application.Util
{
    public class PickProduct : IPickProduct
    {
        private  IList<ProductSaledDTO> _buyProductList;

        public PickProduct(IList<ProductSaledDTO> buyProductList)
        {
            _buyProductList = buyProductList;
        }

        public IList<ProductSaledDTO> AddProductToShoppingCart(List<Product> productList)
        {
            string inputString = Console.ReadLine();

            if (inputString != "" && inputString.Length >= 8)
            {
                Console.WriteLine("Ingrese la cantidad de productos que desea agregar:");
                int quantity;

                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Cantidad inválida. Intente de nuevo:");
                }

                _buyProductList = ChooseProduct(inputString, productList, _buyProductList, quantity);
            }

            else { Console.WriteLine("No se ingreso el mínimo de palabras requerido"); Thread.Sleep(2000); }        

            return _buyProductList;
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
