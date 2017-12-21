using DesignPatterns.Creational.BuilderDemo.Enums;
using DesignPatterns.Creational.BuilderDemo.Models;

namespace DesignPatterns.Creational.BuilderDemo.Builders
{
    internal class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void Create()
        {
            Pizza = new Pizza(PizzaType.Hawaiian);
        }

        private PizzaType _buildingType { get { return PizzaType.Hawaiian; } }

        public override void BuildDough()
        {
            Pizza.Dough = "cross";
        }

        public override void BuildSauce()
        {
            Pizza.Sauce = "mild";
        }

        public override void BuildTopping()
        {
            Pizza.Topping = "ham+pineapple";
        }

    }
}
