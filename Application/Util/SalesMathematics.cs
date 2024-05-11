using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;
using Application.Util;

namespace Application.Common
{
    public class SalesMathematics : ISalesMathematics
    {
        private readonly SaleInformation _saleInformation;
        const decimal TAXES = 1.21m;

        public SalesMathematics(SaleInformation saleInformation)
        {
            _saleInformation = saleInformation;
        }

        public SaleInformation CalculateSale(Dictionary<Product, int> productList)
        {
            _saleInformation.SubTotal = 0;
            _saleInformation.TotalDiscount = 0;
            _saleInformation.TotalPay = 0;

            foreach (var kvp in productList)
            {
                Product product = kvp.Key;
                int quantity = kvp.Value;

                decimal productPrice = product.Price * quantity;
                _saleInformation.SubTotal += productPrice;

                if (product.Discount != 0)
                {
                    decimal discount = product.Discount ?? 0;
                    decimal discountedPrice = product.Price - (product.Price * (discount / 100M));
                    decimal totalDiscountForProduct = (product.Price - discountedPrice) * quantity;
                    _saleInformation.TotalDiscount += totalDiscountForProduct;
                }
            }

            _saleInformation.TotalPay = (_saleInformation.SubTotal - _saleInformation.TotalDiscount) * TAXES;

            return _saleInformation;
        }
    }
}
