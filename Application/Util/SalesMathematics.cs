using Application.Interfaces;
using Application.Models;
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

        public SaleInformation CalculateSale(ProductSaledDTO lastBougthProduct)
        {

            _saleInformation.SubTotal = 0;
            _saleInformation.TotalDiscount = 0;
            _saleInformation.TotalPay = 0;

            _saleInformation.SubTotal += lastBougthProduct.Price * lastBougthProduct.Quantity;

            if (lastBougthProduct.Discount != 0) 
            {
                decimal discount = lastBougthProduct.Discount ?? 0;
                _saleInformation.TotalDiscount += (lastBougthProduct.Price - (lastBougthProduct.Price * (1 - (discount / 100M)))) * lastBougthProduct.Quantity; 
            }

            _saleInformation.TotalPay = ((_saleInformation.SubTotal - _saleInformation.TotalDiscount) * TAXES);

            return _saleInformation;
        }
    }
}
