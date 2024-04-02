using RetailStore.Interfaces;

namespace RetailStore.MenuBuilder.Classes
{
    public class ExitOption : IMenuOption
    {
        public void Execute()
        {
            Console.WriteLine("Vuelve a presionar enter para salir.");
        }
    }
}
