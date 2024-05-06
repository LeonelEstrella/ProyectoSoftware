using AccessData.Util;
using AccessData.DataBaseInfraestructure.DBContext;
using AccessData.DataBaseInfraestructure.Entities;
using AccessData.Interfaces;

namespace AccessData.Queries
{
    public class RegisterSaleQueries : BaseContext, IRegisterSaleQueries
    {
        const decimal TAXES = 1.21m;

        public RegisterSaleQueries(RetailStoreDBContext context) : base(context)
        {
        }

        public Sale RegisterSale(Sale sale)
        {
            var newSale = new Sale
            {
                TotalPay = sale.TotalPay,
                Subtotal = sale.Subtotal,
                TotalDiscount = sale.TotalDiscount,
                Taxes = TAXES,
                DateTime = DateTime.Now,
            };
            
            newSale.SaleProduct = new List<SaleProduct>();

            foreach (var singleProduct in sale.SaleProduct) 
            {
                var product = _context.Product.FirstOrDefault(p => p.ProductId == singleProduct.Product);

                if (product != null)
                {
                    var saleProduct = new SaleProduct
                    {
                        Product = singleProduct.Product,
                        Quantity = singleProduct.Quantity,
                        Price = product.Price,
                        Discount = product.Discount
                    };

                    newSale.SaleProduct.Add(saleProduct);
                }
            }

            _context.Sale.Add(newSale);
            _context.SaveChanges();
            return newSale;
        }
    }
}
