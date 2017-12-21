using DesignPatterns.Creational.BuilderDemo.Enums;
using DesignPatterns.Creational.BuilderDemo.Models;
using System;

namespace DesignPatterns.Creational.BuilderDemo.Builders
{
    internal class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void Create()
        {
            Pizza = new Pizza(PizzaType.Spicy);
        }

        public override void BuildDough()
        {
            Pizza.Dough = "pan baked";
        }

        public override void BuildSauce()
        {
            Pizza.Sauce = "hot";
        }

        public override void BuildTopping()
        {
            Pizza.Topping = "salame+pepperone";
        }
    }
}
