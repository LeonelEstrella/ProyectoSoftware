using RetailStore.Interfaces;

namespace RetailStore.MenuBuilder.Classes
{
    public class BuyProductsOption : IMenuOption
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Compra de Productos:");
            // Lógica para comprar productos
            Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey();
        }
    }
}
