using AccessData.DataBaseInfraestructure.Entities;
using Application.Interfaces;

namespace Application.Util
{
    public class ProductsDictionary : IProductDictionary
    {
        public Dictionary<Product, int> AddProductToDictionary(Dictionary<Product, int> selectedProducts, Dictionary<Product, int> productList) 
        {
            foreach (var kvp in selectedProducts)
            {
                Product product = kvp.Key;
                int quantity = kvp.Value;

                if (productList.ContainsKey(product))
                {
                    productList[product] += quantity;
                }
                else
                {
                    productList.Add(product, quantity);
                }
            }

            return productList;
        }
    }
}
