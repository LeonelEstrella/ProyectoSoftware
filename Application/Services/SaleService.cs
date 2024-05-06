using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;

namespace Application.Services
{
    public class SaleService : ISaleService
    {
        public void RegisterSale(IRegisterSaleQueries registerSaleQueries, Sale sale)
        {
            registerSaleQueries.RegisterSale(sale);
        }
    }
}
