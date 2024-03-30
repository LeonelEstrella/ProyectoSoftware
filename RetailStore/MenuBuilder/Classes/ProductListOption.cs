using RetailStore.Interfaces;

namespace RetailStore.Menu.Classes
{
    public class ProductListOption : IMenuOption
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Lista de Productos:");
            // Lógica para mostrar la lista de productos
            Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey();
        }
    }
}
