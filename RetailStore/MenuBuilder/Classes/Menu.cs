using RetailStore.Interfaces;

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
                Console.WriteLine("1. Comprar");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción escribiendo '1' para comprar o '2' para salir del programa: ");

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
                    Console.WriteLine("Opción no válida. Intente de nuevo. Pulse cualquier tecla para continuar.");
                    Console.ReadKey();
                }
            }
        }
    }

}
