using AccessData.DataBaseInfraestructure.DBContext;
using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using AccessData.Queries;
using Application.Common;
using Application.Interfaces;
using Application.Models;
using Application.Services;
using Application.Util;
using RetailStore.Interfaces;
using RetailStore.MenuBuilder.Classes;
using RetailStore.Util;

RetailStoreDBContext retailStoreDBContext = new RetailStoreDBContext();
IProductQueries productQueries = new ProductQueries(retailStoreDBContext);
IProductService productService = new ProductService(productQueries);
IList<ProductSaledDTO> productList = new List<ProductSaledDTO>();
IRegisterSaleQueries registerSaleQueries = new RegisterSaleQueries(retailStoreDBContext);
ICategoryOptions.Categories[] allCategories = (ICategoryOptions.Categories[])Enum.GetValues(typeof(ICategoryOptions.Categories));
IPickProduct pickProduct = new PickProduct(productList);
ISaleService saleService = new SaleService(registerSaleQueries);
SaleInformation saleInformation = new SaleInformation();
ISalesMathematics salesMathematics = new SalesMathematics(saleInformation);
IList<ProductSaledDTO> bougthProducts = new List<ProductSaledDTO>();
Sale sale = new Sale();
ISaleSelectedProducts registerSale = new SaleSelectedProducts(bougthProducts, pickProduct, salesMathematics, sale, saleService);
IShowProducts showProducts = new ShowProducts(productService);

IMenuOption[] menuOptions =
        [
            new ShowOptions(registerSale, productList, sale, allCategories,showProducts),
            new ExitOption()
            
        ];

Menu menu = new Menu(menuOptions);
menu.ShowMainMenu();

Console.ReadKey();