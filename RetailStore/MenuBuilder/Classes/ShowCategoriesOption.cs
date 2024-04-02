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
        private readonly IList<Product> _productsList;
        private readonly SaleInformation _saleInformation;
        private readonly Sale _sale;
        private readonly ISaleService _saleService;
        private readonly IRegisterSaleQueries _registerSaleQueries;
        private IList<Product> _bougthProducts;

        public ShowCategoriesOption(IProductService productService, IProductQueries productQueries, IPickProduct pickProduct, ISalesMathematics salesMathematics, IList<Product> productsList, IList<Product> bougthProducts, SaleInformation saleInformation, Sale sale, ISaleService saleService, IRegisterSaleQueries registerSaleQueries)
        {
            _productService = productService;
            _productQueries = productQueries;
            _pickProduct = pickProduct;
            _salesMathematics = salesMathematics;
            _productsList = productsList;
            _bougthProducts = bougthProducts;
            _saleInformation = saleInformation;
            _sale = sale;
            _saleService = saleService;
            _registerSaleQueries = registerSaleQueries;
        }

        public void Execute()
        {
            bool finishBuy = false;

            while (!finishBuy) 
            
            {
                var boughtProductsBefore = _bougthProducts.Count;
                var categoryValues = ShowCategories.PrintCategories();

                Console.WriteLine();
                Console.Write("Seleccione una categoría (0 para volver al menú principal finalizando compra): ");
                Console.WriteLine();
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int selectedCategoryIndex) && selectedCategoryIndex >= 1 && selectedCategoryIndex <= categoryValues.Count)
                {
                    _bougthProducts = _pickProduct.AddProductToShoppingCart(_productService, categoryValues, selectedCategoryIndex, _productQueries, _productsList);

                    if (_bougthProducts.Count > boughtProductsBefore) 
                    {
                        var saleCaculated = _salesMathematics.CalculateSale(_bougthProducts[_bougthProducts.Count-1], _saleInformation);
                        _sale.Subtotal += saleCaculated.SubTotal;
                        _sale.TotalDiscount += saleCaculated.TotalDiscount;
                        _sale.TotalPay += saleCaculated.TotalPay;
                    }
                    
                }

                else if (selectedCategoryIndex == 0) { _saleService.RegisterSale(_registerSaleQueries, _bougthProducts, _sale); finishBuy = true; }

                else { Console.WriteLine("Opción no válida. Intente de nuevo."); }
            }

            _productsList.Clear();
            Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey();
        }
    }
}
