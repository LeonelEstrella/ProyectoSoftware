using Application.Interfaces;

namespace RetailStore.Util
{
    public class ShowCategories : ICategoryOptions
    {
        public static List<ICategoryOptions.Categories> PrintCategories()
        {
            var categoryValues = Enum.GetValues(typeof(ICategoryOptions.Categories)).Cast<ICategoryOptions.Categories>().ToList();
            
            Console.Clear();
            Console.WriteLine("Categorías:");
            Console.WriteLine();

            for (int i = 0; i < categoryValues.Count; i++)
            {
                var category = categoryValues[i];
                Console.WriteLine(i + 1 + " - " + category);
            }

            return categoryValues;
        }
    }
}
