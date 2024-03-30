using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;

namespace Application.Interfaces
{
    public interface ISaleService
    {
        void RegisterSale(IRegisterSaleQueries registerSaleQueries ,List<Product> productList, Sale sale);
    }
}
