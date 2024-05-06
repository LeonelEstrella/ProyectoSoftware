using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;
using Application.Models;
using RetailStore.Interfaces;
using RetailStore.Util;

namespace RetailStore.MenuBuilder.Classes
{
    public class ShowOptions : IMenuOption 
    {
        private readonly IList<ProductSaledDTO> _productsList;
        private Sale _sale;
        private readonly ISaleSelectedProducts _registerSale;
        private readonly IList<ICategoryOptions.Categories> _categoryValues;
        private readonly IShowProducts _showProducts;

        public ShowOptions(ISaleSelectedProducts registerSale, IList<ProductSaledDTO> productsList, Sale sale, IList<ICategoryOptions.Categories> categoryValues, IShowProducts showProducts)
        {
            _registerSale = registerSale;
            _productsList = productsList;
            _sale = sale;
            _categoryValues = categoryValues;
            _showProducts = showProducts;
        }

        public void Execute()
        {
            bool finishBuy = false;

            while (!finishBuy)

            {
                try
                {
                    var categoryValues = ShowCategories.PrintCategories();
                    string selectedCategory = "";
                    List<Product> productList;
                    UserInterfaceHandler.InitialSaleMessage();
                    int selectedCategoryIndex = int.Parse(Console.ReadLine());

                    if((selectedCategoryIndex > 0 && selectedCategoryIndex <= categoryValues.Count) || selectedCategoryIndex == 0)
                    {
                        if(selectedCategoryIndex != 0)
                        {
                            selectedCategory = _categoryValues[selectedCategoryIndex - 1].ToString().Replace("_", " ");  
                        }
                        productList = _showProducts.ShowProductList(selectedCategory, selectedCategoryIndex);
                        _sale = _registerSale.SaleAProduct(selectedCategoryIndex, categoryValues, productList);

                        if(selectedCategoryIndex == 0)
                        {
                            ShowSaleInformation.ShowFinishedSaleMessage(_sale);
                            finishBuy = true;
                        }
                        
                    }

                    else if (selectedCategoryIndex == 0 && _sale == null)
                    {
                        Console.WriteLine("Se finalizó la compra sin ningún producto en el carrito.");
                        finishBuy = true;
                    }

                    else { Console.WriteLine("Opción no válida. Intente de nuevo."); }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    finishBuy = false;
                }

            }
            ClearShoppingCart.ClearCart(_productsList, _sale);
            UserInterfaceHandler.FinishSaleMessage();
        }
    }
}
