using AccessData.DataBaseInfraestructure.Entities;

namespace RetailStore.Util
{
    public class ShowSaleInformation
    {
        public static void ShowFinishedSaleMessage(Sale sale)
        {
            Console.WriteLine("Muchas gracias por su compra! \n");
            Console.WriteLine("Total a pagar: $" + Convert.ToDouble(sale.TotalPay));
            Console.WriteLine("Subtotal: $" + Convert.ToDouble(sale.Subtotal));
            Console.WriteLine("Descuento total: $" + Convert.ToDouble(sale.TotalDiscount));
            Console.WriteLine("Impuesto por producto: " + sale.Taxes);
            Console.WriteLine("Fecha de la compra: " + sale.Date);
            Console.WriteLine();
        }
    }
}
