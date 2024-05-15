using AccessData.DataBaseInfraestructure.DBContext;
using AccessData.Interfaces;
using AccessData.Queries;
using Application.Common;
using Application.Interfaces;
using Application.Services;
using Application.Util;
using RetailStore.Interfaces;
using RetailStore.MenuBuilder.Classes;
using RetailStore.Util;

RetailStoreDBContext retailStoreDBContext = new RetailStoreDBContext();
IProductQueries productQueries = new ProductQueries(retailStoreDBContext);
IProductService productService = new ProductService(productQueries);
IProductDictionary productDictionary = new ProductsDictionary();
IRegisterSaleQueries registerSaleQueries = new RegisterSaleQueries(retailStoreDBContext);
ICategoryOptions.Categories[] allCategories = (ICategoryOptions.Categories[])Enum.GetValues(typeof(ICategoryOptions.Categories));
ISaleService saleService = new SaleService(registerSaleQueries, productQueries);
SaleInformation saleInformation = new SaleInformation();
ISalesMathematics salesMathematics = new SalesMathematics(saleInformation);
ISaleSelectedProducts registerSale = new SaleSelectedProducts(salesMathematics, saleService);
ISelectProductFromList showProducts = new SelectProductFromList(productService);

IMenuOption[] menuOptions =
        [
            new ShowOptions(registerSale, allCategories,showProducts, productDictionary),
            new ExitOption()
            
        ];

Menu menu = new Menu(menuOptions);
menu.ShowMainMenu();

Console.ReadKey();