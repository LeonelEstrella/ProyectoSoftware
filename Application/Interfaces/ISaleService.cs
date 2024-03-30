using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;

namespace Application.Interfaces
{
    public interface ISaleService
    {
        void RegisterSale(IRegisterSaleQueries registerSaleQueries , IList<Product> productList, Sale sale);
    }
}
