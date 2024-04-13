﻿using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;
using Application.Interfaces;

namespace Application.Util
{
    public class PickProduct : IPickProduct
    {
        public IList<Product> AddProductToShoppingCart(IProductService productService, IList<ICategoryOptions.Categories> categoryValues, int selectedCategoryIndex, IProductQueries productQueries, IList<Product> buyProductList)
        {
            Console.Clear();

            var selectedCategory = categoryValues[selectedCategoryIndex - 1];
            var productListByCategory = productService.RetrieveProduct(productQueries, selectedCategory.ToString());
            
            Console.WriteLine("Escriba parte del nombre del producto (mínimo 8 caracteres) para agregarlo al carrito o pulse ENTER para volver atras:\n");
            string inputString = Console.ReadLine();

            if (inputString != "" && inputString.Length >= 8)
            {
                buyProductList = ChooseProduct(inputString, productListByCategory, buyProductList);
            }

            else { Console.WriteLine("No se ingreso el mínimo de palabras requerido"); Thread.Sleep(2000); }

            return buyProductList;
        }

        private IList<Product> ChooseProduct(string productName, IList<Product> productList, IList<Product> buyProductList)
        {
            var currentlyBuyProductList = buyProductList.Count; 

            foreach (var product in productList)
            {
                if (product.Name.ToLower().Contains(productName.ToLower()))
                {
                    buyProductList.Add(product);
                    Console.WriteLine("Producto agregado al carrito!");
                    Thread.Sleep(700);
                }
            }

            if (currentlyBuyProductList == buyProductList.Count) 
            { 
                Console.WriteLine("No se agregó ningún producto al carrito. Intente ingresar correctament el nombre del producto.");
                Thread.Sleep(700);
            }

            return buyProductList;
        }
    }
}
