using AccessData.DataBaseInfraestructure.DBContext;
using AccessData.Queries;
using Application.Services;
using RetailStore.Menu.Classes;
using RetailStore.MenuBuilder.Classes;
using RetailStore.MenuBuilder.Interfaces;

RetailStoreDBContext retailStoreDBContext = new RetailStoreDBContext();
ProductQueries accessDataProductService = new ProductQueries(retailStoreDBContext);
ProductService applicationProductService = new ProductService();
//applicationProductService.RetrieveProduct(accessDataProductService);

IMenuOption[] menuOptions = new IMenuOption[]
        {
            new ProductListOption(),
            new ShowCategoriesOption(applicationProductService, accessDataProductService),
            new ExitOption()
            
        };

Menu menu = new Menu(menuOptions);
menu.ShowMainMenu();

Console.ReadKey();