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
                        category = category,
                        ImageUrl = product.ImageUrl
                    }).ToList();

            return producCategorytList;

        }
    }
}
