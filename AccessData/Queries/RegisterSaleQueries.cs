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

        public void RegisterSale(IList<Product> productList, Sale sale)
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

            foreach (var singleProduct in productList) 
            {
                var product = _context.Product.FirstOrDefault(p => p.ProductId == singleProduct.ProductId);

                if (product != null)
                {
                    var existingSaleProduct = newSale.SaleProduct.FirstOrDefault(sp => sp.ProductId == product.ProductId);

                    if (existingSaleProduct != null)
                    {
                        existingSaleProduct.Quantity++;
                    }

                    else
                    {
                        var saleProduct = new SaleProduct
                        {
                            ProductId = singleProduct.ProductId,
                            Quantity = 1,
                            Price = product.Price,
                            Discount = product.Discount
                        };

                        newSale.SaleProduct.Add(saleProduct);
                    }
                }
            }

            _context.Sale.Add(newSale);
            _context.SaveChanges();
        }
    }
}
