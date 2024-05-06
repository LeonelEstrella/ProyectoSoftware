using AccessData.DataBaseInfraestructure.Entities;

namespace Application.Interfaces
{
    public interface ISaleSelectedProducts
    {
        Sale SaleAProduct(int userInput, List<ICategoryOptions.Categories> categoryValues, List<Product> productList);
    }
}
