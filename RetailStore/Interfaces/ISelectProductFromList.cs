using AccessData.DataBaseInfraestructure.Entities;

namespace RetailStore.Interfaces
{
    public interface ISelectProductFromList
    {
        Dictionary<Product, int> SelectProduct(string categoryName, int selectedCategoryIndex);

        int SelectProductAmount();
    }
}
