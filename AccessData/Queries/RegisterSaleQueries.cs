using AccessData.Common;
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
        public void RegisterSale(List<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}
