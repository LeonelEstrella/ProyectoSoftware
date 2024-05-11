using AccessData.Util;
using AccessData.DataBaseInfraestructure.DBContext;
using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;

namespace AccessData.Queries
{
    public class RegisterSaleQueries : BaseContext, IRegisterSaleQueries
    {
        public RegisterSaleQueries(RetailStoreDBContext context) : base(context)
        {
        }

        public Sale RegisterSale(Sale sale)
        {
            _context.Sale.Add(sale);
            _context.SaveChanges();

            return sale;
        }
    }
}
