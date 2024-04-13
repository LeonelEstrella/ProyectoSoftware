namespace RetailStore.Util
{
    public static class UserInterfaceHandler
    {
        public static void InitialSaleMessage() 
        {
            Console.WriteLine();
            Console.Write("Seleccione una categoría (0 para volver al menú principal finalizando compra): ");
            Console.WriteLine();
        }
        public static void FinishSaleMessage()
        {
            Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey();
        }
    }
}
