using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;
using Application.Util;

namespace Application.Common
{
    public class SalesMathematics : ISalesMathematics
    {
        const decimal TAXES = 1.21m;
        public SaleInformation CalculateSale(Product lastBougthProduct, SaleInformation saleInformation)
        {
            saleInformation.SubTotal = 0;
            saleInformation.TotalDiscount = 0;
            saleInformation.TotalPay = 0;

            saleInformation.SubTotal += lastBougthProduct.Price;

            if (lastBougthProduct.Discount != 0) 
            {
                decimal discount = lastBougthProduct.Discount ?? 0;
                saleInformation.TotalDiscount += lastBougthProduct.Price - (lastBougthProduct.Price * (1 - (discount / 100M))); 
            }

            saleInformation.TotalPay = (saleInformation.SubTotal - saleInformation.TotalDiscount) * TAXES;

            return saleInformation;
        }
    }
}
