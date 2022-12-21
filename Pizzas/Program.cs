using Pizzas.Contexts;
using Pizzas.Services;

namespace Pizzas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Pizza.Add(new Models.Pizza { Name = "Margarita", Img = "png112" });
            foreach (var item in context.Pizza.GetAll())
            {
                Console.WriteLine($"{item.Name}");
            }
            context.Ingredient.Add(new Models.Ingredient { Name = "Sosiska" });
                foreach(var item in context.Ingredient.GetAll())
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
}