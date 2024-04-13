using AccessData.DataBaseInfraestructure.DBContext;
using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using AccessData.Queries;
using Application.Common;
using Application.Interfaces;
using Application.Services;
using Application.Util;
using RetailStore.Interfaces;
using RetailStore.MenuBuilder.Classes;

RetailStoreDBContext retailStoreDBContext = new RetailStoreDBContext();
IProductQueries productQueries = new ProductQueries(retailStoreDBContext);
IProductService productService = new ProductService();
IRegisterSaleQueries registerSaleQueries = new RegisterSaleQueries(retailStoreDBContext);
IPickProduct pickProduct = new PickProduct();
ISaleService saleService = new SaleService();
ISalesMathematics salesMathematics = new SalesMathematics();
SaleInformation saleInformation = new SaleInformation();
IList<Product> productList = new List<Product>();
IList<Product> bougthProducts = new List<Product>();
Sale sale = new Sale();
IRegisterSale registerSale = new RegisterSale(bougthProducts, pickProduct, salesMathematics, productList, saleInformation, sale, saleService, registerSaleQueries, productService, productQueries);

IMenuOption[] menuOptions =
        [
            new ShowCategoriesOption(registerSale, productList, sale),
            new ExitOption()
            
        ];

Menu menu = new Menu(menuOptions);
menu.ShowMainMenu();

Console.ReadKey();