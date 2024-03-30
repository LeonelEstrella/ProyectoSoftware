using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;
using Application.Services;
using RetailStore.Interfaces;
using RetailStore.MenuBuilder.Interfaces;
using RetailStore.Util;

namespace RetailStore.MenuBuilder.Classes
{
    public class ShowCategoriesOption : IMenuOption 
    {
        private readonly IProductService _productService;
        private readonly IProductQueries _productQueries;
        private readonly List<Product> _productsList;
        private readonly IPickProduct _pickProduct;

        public ShowCategoriesOption(IProductService productService, IProductQueries productQueries, IPickProduct pickProduct, List<Product> productsList)
        {
            _productService = productService;
            _productQueries = productQueries;
            _productsList = productsList;
            _pickProduct = pickProduct;
        }

        public void Execute()
        {
            var categoryValues = ShowCategories.PrintCategories();

            Console.Write("Seleccione una categoría (0 para volver al menú principal): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int selectedCategoryIndex) && selectedCategoryIndex >= 1 && selectedCategoryIndex <= categoryValues.Count)
            {
                _pickProduct.AddProductToShoppingCart(_productService,categoryValues,selectedCategoryIndex,_productQueries, _productsList);              
            }
            else if (selectedCategoryIndex == 0)
            {
                // Volver al menú principal
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }

            Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey();
        }
    }
}
