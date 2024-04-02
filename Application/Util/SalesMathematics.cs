using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;
using Application.Util;

namespace Application.Common
{
    public class SalesMathematics : ISalesMathematics
    {
        const decimal TAXES = 1.21m;
        public SaleInformation CalculateSale(IList<Product> products, SaleInformation saleInformation)
        {
            saleInformation.SubTotal = 0;
            saleInformation.TotalDiscount = 0;

            foreach (Product product in products)
            {
                saleInformation.SubTotal += product.Price;

                if (product.Discount != 0) saleInformation.TotalDiscount += product.Price - (product.Price * (1 -  (product.Discount / 100M)));
            }

            saleInformation.TotalPay = (saleInformation.SubTotal - saleInformation.TotalDiscount) * TAXES;

            return saleInformation;
        }
    }
}
