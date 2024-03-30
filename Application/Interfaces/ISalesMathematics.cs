using AccessData.DataBaseInfraestructure.Entities;
using Application.Util;

namespace Application.Interfaces
{
    public interface ISalesMathematics
    {
        public SaleInformation CalculateSale(List<Product> products, SaleInformation saleInformation);
    }
}
