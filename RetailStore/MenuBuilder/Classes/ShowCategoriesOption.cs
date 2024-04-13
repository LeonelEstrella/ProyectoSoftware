using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;
using RetailStore.Interfaces;
using RetailStore.Util;

namespace RetailStore.MenuBuilder.Classes
{
    public class ShowCategoriesOption : IMenuOption 
    {
        private readonly IList<Product> _productsList;
        private readonly Sale _sale;
        private readonly IRegisterSale _registerSale;
        public ShowCategoriesOption(IRegisterSale registerSale, IList<Product> productsList, Sale sale)
        {
            _registerSale = registerSale;
            _productsList = productsList;
            _sale = sale;
        }

        public void Execute()
        {
            bool finishBuy = false;

            while (!finishBuy)

            {
                var categoryValues = ShowCategories.PrintCategories();

                UserInterfaceHandler.InitialSaleMessage();
                string userInput = Console.ReadLine();

                finishBuy = _registerSale.SaleAProduct(userInput, categoryValues);
            }

            ClearShoppingCart.ClearCart(_productsList, _sale);
            UserInterfaceHandler.FinishSaleMessage();
        }
    }
}
