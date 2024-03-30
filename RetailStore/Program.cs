using AccessData.DataBaseInfraestructure.DBContext;
using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using AccessData.Queries;
using Application.Common;
using Application.Interfaces;
using Application.Services;
using Application.Util;
using RetailStore.Interfaces;
using RetailStore.Menu.Classes;
using RetailStore.MenuBuilder.Classes;
using RetailStore.Util;

RetailStoreDBContext retailStoreDBContext = new RetailStoreDBContext();
IProductQueries productQueries = new ProductQueries(retailStoreDBContext);
IProductService productService = new ProductService();
IRegisterSaleQueries registerSaleQueries = new RegisterSaleQueries(retailStoreDBContext);
IPickProduct pickProduct = new PickProduct();
ISaleService saleService = new SaleService();
ISalesMathematics salesMathematics = new SalesMathematics();
SaleInformation saleInformation = new SaleInformation();
IList<Product> productList = new List<Product>();
Sale sale = new Sale();

IMenuOption[] menuOptions = new IMenuOption[]
        {
            new ProductListOption(),
            new ShowCategoriesOption(productService, productQueries, pickProduct, salesMathematics ,productList, saleInformation, sale, saleService, registerSaleQueries),
            new ExitOption()
            
        };

Menu menu = new Menu(menuOptions);
menu.ShowMainMenu();

Console.ReadKey();