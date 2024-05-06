using AccessData.DataBaseInfraestructure.Entities;
using Application.Models;

namespace RetailStore.Util
{
    public class ClearShoppingCart
    {
        public static void ClearCart(IList<ProductSaledDTO> _productsList, Sale _sale) 
        {
            _productsList.Clear();
            _sale.Subtotal = 0;
            _sale.TotalDiscount = 0;
            _sale.TotalPay = 0;
        }
    }
}
