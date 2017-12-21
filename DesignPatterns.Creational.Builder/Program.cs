using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Directors;
using System;

namespace DesignPatterns.Creational.Builder
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            CreatePizza(new HawaiianPizzaBuilder());
            CreatePizza(new SpicyPizzaBuilder());
            Console.Read();
        }

        private static void CreatePizza(PizzaBuilder builder)
        {
            Waiter waiter = new Waiter();

            waiter.SetBuilder(builder);
            waiter.Construct();

            var pizza = waiter.GetPizza();

            Console.WriteLine($"{pizza.Type.ToString()} Pizza done with {pizza.Dough} / {pizza.Sauce} / {pizza.Topping}.");
        }
    }
}
