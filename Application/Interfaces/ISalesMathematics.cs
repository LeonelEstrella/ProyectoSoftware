using AccessData.DataBaseInfraestructure.Entities;
using Application.Common;

namespace Application.Interfaces
{
    public interface ISalesMathematics
    {
        public SaleInformation CalculateSale(List<Product> products, SaleInformation saleInformation);
    }
}
