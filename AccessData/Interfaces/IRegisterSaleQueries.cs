using AccessData.DataBaseInfraestructure.Entities;

namespace AccessData.Interfaces
{
    public interface IRegisterSaleQueries
    {
        void RegisterSale(IList<Product> productList, Sale sale);
    }
}
