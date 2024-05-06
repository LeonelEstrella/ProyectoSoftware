using AccessData.Util;
using AccessData.DataBaseInfraestructure.DBContext;
using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;

namespace AccessData.Queries
{
    public class ProductQueries : BaseContext, IProductQueries
    {
        public ProductQueries(RetailStoreDBContext context) : base(context)
        {
        }

        public List<Product> RetrieveProducts(string categoryName)
        {       
            var producCategorytList = _context.Product
                    .Join(
                    _context.Category.Where( c => c.Name == categoryName ),
                    product => product.Category,
                    category => category.CategoryId,
                    (product, category) => new Product
                    {
                        ProductId = product.ProductId,
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        Discount = product.Discount,
                        Category = product.Category,
                        ImageUrl = product.ImageUrl
                    }).ToList();

            foreach (var product in producCategorytList)
            {
                Console.WriteLine($"ProductID: {product.ProductId}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Description: {product.Description}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine($"Discount: {product.Discount}");
                Console.WriteLine($"Category: {product.category.Name}");
                Console.WriteLine(new string('-', Console.WindowWidth - 1));
            }

            return producCategorytList;

        }
    }
}
