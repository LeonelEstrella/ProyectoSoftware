using AccessData.DataBaseInfraestructure.Entities;

namespace RetailStore.Interfaces
{
    public interface IShowProducts
    {
        List<Product> ShowProductList(string categoryName, int selectedCategoryIndex);
    }
}
