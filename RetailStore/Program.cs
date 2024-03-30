using AccessData.DataBaseInfraestructure.DBContext;
using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Queries;
using Application.Common;
using Application.Interfaces;
using Application.Services;
using Application.Util;
using RetailStore.Interfaces;
using RetailStore.Menu.Classes;
using RetailStore.MenuBuilder.Classes;
using RetailStore.MenuBuilder.Interfaces;
using RetailStore.Util;

RetailStoreDBContext retailStoreDBContext = new RetailStoreDBContext();
ProductQueries accessDataProductService = new ProductQueries(retailStoreDBContext);
ProductService applicationProductService = new ProductService();
IPickProduct pickProduct = new PickProduct();
List<Product> productList = new List<Product>();


//Testeo de maths
List<Product> productsList = new List<Product> {  new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_661063-MLU74118278062_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Lavarropas automático Drean Next 8.14 P ECO inverter blanco 8kg 220 V", Description = "Únicamente necesita que se introduzcan los productos de limpieza y se elija el programa deseado.", Price = 744292, CategoryId = 1, Discount = 39, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_944011-MLA74651986202_022024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Lavavajilla Drean Dish 12.2 Ltx 12 Cubiertos Acero", Description = "Marca líder mundial en la comercialización de electrodomésticos que orienta su trabajo en la tecnología, el diseño y la innovación para mejorar la calidad de vida.", Price = 1209224, CategoryId = 1, Discount = 47, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_973805-MLU74159511409_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Freidora Eléctrica De Aire Sin Aceite + Pinza Gratis 1400w Color Negro", Description = "Freidora de Aire Gadnic F4.0 Sin Aceite 4Lts Digital", Price = 124999, CategoryId = 1, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_862380-MLU74244415875_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Aspiradora Trapeadora Robot Atma Atar21c1dh Blanca 220v", Description = "El Robot de limpieza ATMA facilita la tarea de mantener los pisos impecables, combinando las funciones de aspirar y trapear simultáneamente.", Price = 668249, CategoryId = 2, Discount = 19, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_898750-MLU73587878148_122023-O.webp" } };

ISalesMathematics salesMathematics = new SalesMathematics();
SaleInformation saleInformation = new SaleInformation();
var test = salesMathematics.CalculateSale(productsList, saleInformation);

IMenuOption[] menuOptions = new IMenuOption[]
        {
            new ProductListOption(),
            new ShowCategoriesOption(applicationProductService, accessDataProductService, pickProduct, productList),
            new ExitOption()
            
        };

Menu menu = new Menu(menuOptions);
menu.ShowMainMenu();

Console.ReadKey();