using AccessData.DataBaseInfraestructure.Entities;
using Application.Models;
using Application.Util;

namespace Application.Interfaces
{
    public interface ISalesMathematics
    {
        public SaleInformation CalculateSale(ProductSaledDTO product, SaleInformation saleInformation);
    }
}
