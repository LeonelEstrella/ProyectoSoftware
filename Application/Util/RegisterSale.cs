using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;
using Application.Models;

namespace Application.Util
{
    public class RegisterSale
    {
        private readonly ISaleService _saleService;

        public RegisterSale(ISaleService saleService)
        {
            _saleService = saleService;
        }

        public Sale RegsiterASale(Sale sale ,List<ProductSaledDTO> bougthProducts)
        {
            foreach (var product in bougthProducts)
            {
                sale.SaleProduct.Add(new SaleProduct
                {
                    Product = product.ProductId,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    Discount = product.Discount
                });
            }
            return _saleService.RegisterSale(sale);
        }
    }
}
