using AccessData.DataBaseInfraestructure.Entities;
using Application.Util;

namespace Application.Interfaces
{
    public interface ISalesMathematics
    {
        public SaleInformation CalculateSale(Product product, SaleInformation saleInformation);
    }
}
