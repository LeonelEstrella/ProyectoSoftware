using AccessData.Common;
using AccessData.DataBaseInfraestructure.DBContext;
using AccessData.Interfaces;

namespace AccessData.Queries
{
    public class ProductQueries : BaseContext, IProductQueries
    {
        public ProductQueries(RetailStoreDBContext context) : base(context)
        {
        }

        public void RetrieveProducts(string categoryName)
        {       
            var producCategorytList = _context.Product
                    .Join(
                    _context.Category.Where( c => c.Name == categoryName ),
                    product => product.CategoryId,
                    category => category.CategoryId,
                    (product, category) => new
                    {
                        ProductID = product.ProductId,
                        ProductName = product.Name,
                        ProductDescription = product.Description,
                        ProductPrice = product.Price,
                        ProductDiscount = product.Discount,
                        ProductCategory = category,
                        ProductImageLink = product.ImageLink
                    }).ToList();

            foreach (var product in producCategorytList)
            {
                Console.WriteLine($"ProductID: {product.ProductID}");
                Console.WriteLine($"Name: {product.ProductName}");
                Console.WriteLine($"Description: {product.ProductDescription}");
                Console.WriteLine($"Price: {product.ProductPrice}");
                Console.WriteLine($"Discount: {product.ProductDiscount}");
                Console.WriteLine($"Category: {product.ProductCategory.Name}");
                Console.WriteLine(new string('-', Console.WindowWidth - 1));
            }

        }
    }
}
