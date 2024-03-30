using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;
using Application.Util;
using RetailStore.Interfaces;
using RetailStore.Util;

namespace RetailStore.MenuBuilder.Classes
{
    public class ShowCategoriesOption : IMenuOption 
    {
        private readonly IProductService _productService;
        private readonly IProductQueries _productQueries;
        private readonly IPickProduct _pickProduct;
        private readonly ISalesMathematics _salesMathematics;
        private readonly List<Product> _productsList;
        private readonly SaleInformation _saleInformation;
        private readonly Sale _sale;
        private readonly ISaleService _saleService;
        private readonly IRegisterSaleQueries _registerSaleQueries;

        public ShowCategoriesOption(IProductService productService, IProductQueries productQueries, IPickProduct pickProduct, ISalesMathematics salesMathematics, List<Product> productsList, SaleInformation saleInformation, Sale sale, ISaleService saleService, IRegisterSaleQueries registerSaleQueries)
        {
            _productService = productService;
            _productQueries = productQueries;
            _pickProduct = pickProduct;
            _salesMathematics = salesMathematics;
            _productsList = productsList;
            _saleInformation = saleInformation;
            _sale = sale;
            _saleService = saleService;
            _registerSaleQueries = registerSaleQueries;
        }

        public void Execute()
        {
            var categoryValues = ShowCategories.PrintCategories();

            Console.Write("Seleccione una categoría (0 para volver al menú principal): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int selectedCategoryIndex) && selectedCategoryIndex >= 1 && selectedCategoryIndex <= categoryValues.Count)
            {
                var bougthProducts = _pickProduct.AddProductToShoppingCart( _productService, categoryValues, selectedCategoryIndex, _productQueries, _productsList );
                var saleCaculated = _salesMathematics.CalculateSale(bougthProducts, _saleInformation);
                _sale.Subtotal = saleCaculated.SubTotal;
                _sale.TotalDiscount = saleCaculated.TotalDiscount;
                _sale.TotalPay = saleCaculated.TotalPay;
                _saleService.RegisterSale(_registerSaleQueries, bougthProducts, _sale);

            }
            else if (selectedCategoryIndex == 0)
            {
                // Volver al menú principal
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }

            _productsList.Clear();
            Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey();
        }
    }
}
