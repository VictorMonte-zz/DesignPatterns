using DesignPatterns.Creational.BuilderDemo.Builders;
using DesignPatterns.Creational.BuilderDemo.Directors;
using System;

namespace DesignPatterns.Creational.BuilderDemo
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
