using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Models;

namespace Application.Interfaces
{
    public interface ISaleService
    {
        void RegisterSale(IRegisterSaleQueries registerSaleQueries, Sale sale);
    }
}
