using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;

namespace Application.Services
{
    public class SaleService : ISaleService
    {
        private readonly IRegisterSaleQueries _registerSaleQueries;

        public SaleService(IRegisterSaleQueries registerSaleQueries)
        {
            _registerSaleQueries = registerSaleQueries;
        }

        public Sale RegisterSale(Sale sale)
        {
            return _registerSaleQueries.RegisterSale(sale);
        }
    }
}
