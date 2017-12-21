using DesignPatterns.Creational.Builder.Enums;
using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Builders
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
