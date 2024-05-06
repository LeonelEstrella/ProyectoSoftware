using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;
using Application.Models;

namespace Application.Util
{
    public class SaleSelectedProducts : ISaleSelectedProducts
    {
        private IList<ProductSaledDTO> _bougthProducts;
        private readonly IPickProduct _pickProduct;
        private readonly ISalesMathematics _salesMathematics;
        private Sale _sale;
        private readonly ISaleService _saleService;

        public SaleSelectedProducts(IList<ProductSaledDTO> bougthProducts, IPickProduct pickProduct, ISalesMathematics salesMathematics, Sale sale, ISaleService saleService)
        {
            _bougthProducts = bougthProducts;
            _pickProduct = pickProduct;
            _salesMathematics = salesMathematics;
            _sale = sale;
            _saleService = saleService;
        }

        public Sale SaleAProduct(int selectedCategoryIndex, List<ICategoryOptions.Categories> categoryValues, List<Product> productList) 
        {
            var boughtProductsBefore = _bougthProducts.Count;
            if (selectedCategoryIndex != 0)

            {
                _bougthProducts = _pickProduct.AddProductToShoppingCart(productList);
            }

            if (_bougthProducts.Count > boughtProductsBefore)
            {
                var saleCaculated = _salesMathematics.CalculateSale(_bougthProducts[_bougthProducts.Count - 1]);
                _sale.Subtotal += saleCaculated.SubTotal;
                _sale.TotalDiscount += saleCaculated.TotalDiscount;
                _sale.TotalPay += saleCaculated.TotalPay;
            }

            if (selectedCategoryIndex == 0 && _bougthProducts.Count > 0)
            {                    
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
                _sale = _saleService.RegisterSale(_sale); 
            }
            return _sale;
        }
    }
}
