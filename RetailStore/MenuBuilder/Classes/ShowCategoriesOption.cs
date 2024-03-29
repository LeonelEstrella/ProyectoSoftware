using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using AccessData.Queries;
using Application.Services;
using RetailStore.MenuBuilder.Interfaces;

namespace RetailStore.MenuBuilder.Classes
{
    public class ShowCategoriesOption : IMenuOption, ICategoryOptions
    {
        private readonly ProductService _applicationProductService;
        private readonly IProductQueries _productQueries;

        public ShowCategoriesOption(ProductService applicationProductService, IProductQueries productQueries)
        {
            _applicationProductService = applicationProductService;
            _productQueries = productQueries;
        }

        public void Execute()
        {
            var categoryValues = Enum.GetValues(typeof(ICategoryOptions.Categories)).Cast<ICategoryOptions.Categories>().ToArray();
            Console.Clear();
            Console.WriteLine("Categorías:");
            for (int i = 0; i < categoryValues.Length; i++)
            {
                var category = (ICategoryOptions.Categories)categoryValues.GetValue(i);
                Console.WriteLine(i+1 + " - " + category);
            }

            Console.Write("Seleccione una categoría (0 para volver al menú principal): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int selectedCategoryIndex) && selectedCategoryIndex >= 1 && selectedCategoryIndex <= categoryValues.Length)
            {
                Console.Clear();
                Console.WriteLine("Escriba parte o el nombre del producto para agregar al carrito:\n");
                var selectedCategory = categoryValues[selectedCategoryIndex-1];
                _applicationProductService.RetrieveProduct(_productQueries, selectedCategory.ToString());
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
