using AccessData.DataBaseInfraestructure.Entities;

namespace AccessData.Interfaces
{
    public interface IRegisterSaleQueries
    {
        void RegisterSale(List<Product> productList, Sale sale);
    }
}
