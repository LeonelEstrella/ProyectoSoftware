using Application.Interfaces;
using Application.Models;
using Application.Util;

namespace Application.Common
{
    public class SalesMathematics : ISalesMathematics
    {
        const decimal TAXES = 1.21m;
        public SaleInformation CalculateSale(ProductSaledDTO lastBougthProduct, SaleInformation saleInformation)
        {

            saleInformation.SubTotal = 0;
            saleInformation.TotalDiscount = 0;
            saleInformation.TotalPay = 0;

            saleInformation.SubTotal += lastBougthProduct.Price * lastBougthProduct.Quantity;

            if (lastBougthProduct.Discount != 0) 
            {
                decimal discount = lastBougthProduct.Discount ?? 0;
                saleInformation.TotalDiscount += (lastBougthProduct.Price - (lastBougthProduct.Price * (1 - (discount / 100M)))) * lastBougthProduct.Quantity; 
            }

            saleInformation.TotalPay = ((saleInformation.SubTotal - saleInformation.TotalDiscount) * TAXES);

            return saleInformation;
        }
    }
}
