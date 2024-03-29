using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;

namespace Application.Common
{
    public class SalesMathematics : ISalesMathematics
    {

        public SaleInformation CalculateSale(List<Product> products, SaleInformation saleInformation)
        {
            saleInformation.SubTotal = 0;
            foreach (Product product in products)
            {
                saleInformation.SubTotal += product.Price;
            }

            return saleInformation;
        }
    }
}
