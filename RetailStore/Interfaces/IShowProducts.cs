using AccessData.DataBaseInfraestructure.Entities;

namespace RetailStore.Interfaces
{
    public interface IShowProducts
    {
        Dictionary<Product, int> SelectProduct(string categoryName, int selectedCategoryIndex);

        int SelectProductAmount();
    }
}
