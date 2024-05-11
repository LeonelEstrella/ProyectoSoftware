using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;

namespace Application.Util
{
    public class SaleSelectedProducts : ISaleSelectedProducts
    {
        private const decimal TAXES = 1.21m;
        private readonly ISalesMathematics _salesMathematics;
        private readonly ISaleService _saleService;

        public SaleSelectedProducts(ISalesMathematics salesMathematics, ISaleService saleService)
        {
            _salesMathematics = salesMathematics;
            _saleService = saleService;
        }

        public (Sale, Boolean) SaleAProduct(Dictionary<Product, int> productList) 
        {      
            var saleCaculated = _salesMathematics.CalculateSale(productList);
                
            var sale = new Sale
            {
                Date = DateTime.Now,
                SaleProduct = new List<SaleProduct>()
            };
            foreach (var kvp in productList)
            {
                Product product = kvp.Key;
                int quantity = kvp.Value;
                sale.SaleProduct.Add(new SaleProduct
                {
                    Product = product.ProductId,
                    Quantity = quantity,
                    Price = product.Price,
                    Discount = product.Discount
                });
            }

            sale.Subtotal = saleCaculated.SubTotal;
            sale.TotalDiscount = saleCaculated.TotalDiscount;
            sale.Taxes = TAXES;
            sale.TotalPay = saleCaculated.TotalPay;

            sale = _saleService.RegisterSale(sale);
            return (sale, true);
        }
    }
}
