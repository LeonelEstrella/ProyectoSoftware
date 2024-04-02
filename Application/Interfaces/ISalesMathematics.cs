using AccessData.DataBaseInfraestructure.Entities;
using Application.Util;

namespace Application.Interfaces
{
    public interface ISalesMathematics
    {
        public SaleInformation CalculateSale(IList<Product> products, SaleInformation saleInformation);
    }
}
