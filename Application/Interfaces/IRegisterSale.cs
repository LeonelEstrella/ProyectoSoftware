namespace Application.Interfaces
{
    public interface IRegisterSale
    {
        Boolean SaleAProduct(string userInput, List<ICategoryOptions.Categories> categoryValues);
    }
}
