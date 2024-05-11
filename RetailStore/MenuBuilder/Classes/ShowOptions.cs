using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;
using RetailStore.Interfaces;
using RetailStore.Util;

namespace RetailStore.MenuBuilder.Classes
{
    public class ShowOptions : IMenuOption 
    {
        private readonly ISaleSelectedProducts _registerSale;
        private readonly IList<ICategoryOptions.Categories> _categoryValues;
        private readonly IShowProducts _showProducts;
        private readonly IProductDictionary _productDictionary;

        public ShowOptions(ISaleSelectedProducts registerSale, IList<ICategoryOptions.Categories> categoryValues, IShowProducts showProducts, IProductDictionary productDictionary)
        {
            _registerSale = registerSale;
            _categoryValues = categoryValues;
            _showProducts = showProducts;
            _productDictionary = productDictionary;
        }

        public void Execute()
        {
            bool finishBuy = false;
            Dictionary<Product, int> productList = new Dictionary<Product, int>();

            while (!finishBuy)

            {
                try
                {
                    var categoryValues = ShowCategories.PrintCategories();
                    string selectedCategory = "";
                    UserInterfaceHandler.InitialSaleMessage();
                    int selectedCategoryIndex = int.Parse(Console.ReadLine());

                    if(selectedCategoryIndex == 0)
                    {
                        if(productList.Count == 0)
                        {
                            Console.WriteLine("Se finalizó la compra sin ningún producto en el carrito.");
                        }
                        else
                        {
                            (var sale, finishBuy) = _registerSale.SaleAProduct(productList);
                            Console.Clear();
                            ShowSaleInformation.ShowFinishedSaleMessage(sale);
                            finishBuy = true;
                        }  
                    }

                    else if(selectedCategoryIndex > 0 && selectedCategoryIndex <= categoryValues.Count)
                    {
                        selectedCategory = _categoryValues[selectedCategoryIndex - 1].ToString().Replace("_", " ");  

                        var selectProducts = _showProducts.SelectProduct(selectedCategory, selectedCategoryIndex);
                        

                        if (selectProducts.Count > 0)
                        {
                            productList =  _productDictionary.AddProductToDictionary(selectProducts, productList);
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número de categoría que ha seleccionado no existe. Por favor, vuelva a intertarlo. Volviendo al menu de selcción de categorías...");
                        Thread.Sleep(3500);
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    finishBuy = false;
                }
            }         
            UserInterfaceHandler.FinishSaleMessage();
        }
    }
}
