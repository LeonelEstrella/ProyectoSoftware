using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;
using Application.Models;

namespace Application.Util
{
    public class RegisterSale : IRegisterSale
    {
        private IList<ProductSaledDTO> _bougthProducts;
        private readonly IPickProduct _pickProduct;
        private readonly ISalesMathematics _salesMathematics;
        private readonly IList<ProductSaledDTO> _productsList;
        private readonly IProductService _productService;
        private readonly SaleInformation _saleInformation;
        private readonly Sale _sale;
        private readonly ISaleService _saleService;
        private readonly IRegisterSaleQueries _registerSaleQueries;
        private readonly IProductQueries _productQueries;

        public RegisterSale(IList<ProductSaledDTO> bougthProducts,
            IPickProduct pickProduct, ISalesMathematics salesMathematics, IList<ProductSaledDTO> productsList, 
            SaleInformation saleInformation, Sale sale, ISaleService saleService, IRegisterSaleQueries registerSaleQueries,
            IProductService productService, IProductQueries productQueries)
        {
            _bougthProducts = bougthProducts;
            _pickProduct = pickProduct;
            _salesMathematics = salesMathematics;
            _productsList = productsList;
            _saleInformation = saleInformation;
            _sale = sale;
            _saleService = saleService;
            _registerSaleQueries = registerSaleQueries;
            _productService = productService;
            _productQueries = productQueries;
        }

        public Boolean SaleAProduct(string userInput, List<ICategoryOptions.Categories> categoryValues) 
        {

            try
            {
                var boughtProductsBefore = _bougthProducts.Count;

                int selectedCategoryIndex = int.Parse(userInput);

                if (selectedCategoryIndex >= 1 && selectedCategoryIndex <= categoryValues.Count)
                {
                    _bougthProducts = _pickProduct.AddProductToShoppingCart(_productService, categoryValues, selectedCategoryIndex, _productQueries, _productsList);

                    if (_bougthProducts.Count > boughtProductsBefore)
                    {
                        var saleCaculated = _salesMathematics.CalculateSale(_bougthProducts[_bougthProducts.Count - 1], _saleInformation);
                        _sale.Subtotal += saleCaculated.SubTotal;
                        _sale.TotalDiscount += saleCaculated.TotalDiscount;
                        _sale.TotalPay += saleCaculated.TotalPay;
                    }
                    return false;
                }

                else if (selectedCategoryIndex == 0 && _bougthProducts.Count > 0)
                {                    
                    List<Product> list = new List<Product>();
                    foreach (var product in _bougthProducts)
                    {
                        _sale.SaleProduct.Add(new SaleProduct
                        {
                            Product = product.ProductId,
                            Quantity = product.Quantity,
                            Price = product.Price,
                            Discount = product.Discount
                        });
                    }
                    _saleService.RegisterSale(_registerSaleQueries, _sale);
                    return true;
                }

                else if (selectedCategoryIndex == 0 && _bougthProducts.Count == 0)
                {
                    Console.WriteLine("Se finalizó la compra sin ningún producto en el carrito.");
                    return true;
                }

                else { Console.WriteLine("Opción no válida. Intente de nuevo."); return false; }
            }
            catch (FormatException) 
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                return false;
            }
        }
    }
}
