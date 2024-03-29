using RetailStore.MenuBuilder.Interfaces;

namespace RetailStore.MenuBuilder.Classes
{
    public class Menu
    {
        private readonly IMenuOption[] _menuOptions;

        public Menu(IMenuOption[] menuOptions)
        {
            _menuOptions = menuOptions;
        }

        public void ShowMainMenu()
        {
            bool exitMenu = false;

            while (!exitMenu)
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Ver lista de productos");
                Console.WriteLine("2. Comprar");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                string userInput = Console.ReadLine();

                int option;
                if (int.TryParse(userInput, out option) && option >= 1 && option <= _menuOptions.Length)
                {
                    _menuOptions[option - 1].Execute();
                    if (_menuOptions[option - 1] is ExitOption)
                    {
                        exitMenu = true;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                }
            }
        }
    }

}
