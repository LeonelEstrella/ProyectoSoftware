
using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;
using RetailStore.Interfaces;

namespace RetailStore.Util
{
    public class SelectProductFromList : ISelectProductFromList
    {
        private readonly IProductService _productService;

        public SelectProductFromList(IProductService productService)
        {
            _productService = productService;
        }

        public Dictionary<Product, int> SelectProduct(string categoryName, int selectedCategoryIndex)
        {
            Console.Clear();

            List<Product> productList = _productService.RetrieveProduct(categoryName);
            int quantity = 0;
            Dictionary<Product, int> selectedProducts = new Dictionary<Product, int>();

            if (selectedCategoryIndex > 0)
            {
                foreach (var singleProduct in productList)
                {
                    Console.WriteLine($"ProductID: {singleProduct.ProductId}");
                    Console.WriteLine($"Name: {singleProduct.Name}");
                    Console.WriteLine($"Description: {singleProduct.Description}");
                    Console.WriteLine($"Price: {singleProduct.Price}");
                    Console.WriteLine($"Discount: {singleProduct.Discount}");
                    Console.WriteLine($"Category: {singleProduct.category.Name}");
                    Console.WriteLine(new string('-', Console.WindowWidth - 1));
                }

                Console.WriteLine("Escriba parte del nombre del producto (mínimo 8 caracteres) para agregarlo al carrito o pulse ENTER para volver atras:\n");
                var userInput = Console.ReadLine();

                if (userInput != "" && userInput.Length >= 8)
                {
                    var product = _productService.GetProductByName(userInput);
                    if (product == null)
                    {
                        Console.WriteLine("No se ha encontrado ningún producto.");
                        Thread.Sleep(700);
                    }
                    else
                    {
                        quantity = SelectProductAmount();
                        selectedProducts.Add(product, quantity);
                        Console.WriteLine("Producto agregado al carrito!");
                        Thread.Sleep(700);
                    }
                    
                }
                else { Console.WriteLine("No se ingreso el mínimo de palabras requerido. Volviendo al menu de selección de categoría..."); Thread.Sleep(2000); }
            }
            return selectedProducts;
        }
        public int SelectProductAmount()
        {
            Boolean hasValidAmount = false;
            int quantity = 0;
            while (!hasValidAmount)
            {
                Console.WriteLine("Ingrese la cantidad de productos que desea agregar:");

                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Cantidad inválida. Intente de nuevo:");
                }
                hasValidAmount = true;       
            }
            return quantity;
        }
    }
}
