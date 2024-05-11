using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;

namespace Application.Services
{
    public class SaleService : ISaleService
    {
        private readonly IRegisterSaleQueries _registerSaleQueries;
        private readonly IProductQueries _productQueries;

        public SaleService(IRegisterSaleQueries registerSaleQueries, IProductQueries productQueries)
        {
            _registerSaleQueries = registerSaleQueries;
            _productQueries = productQueries;
        }

        public Sale RegisterSale(Sale sale)
        {
            return _registerSaleQueries.RegisterSale(sale);
        }
    }
}
