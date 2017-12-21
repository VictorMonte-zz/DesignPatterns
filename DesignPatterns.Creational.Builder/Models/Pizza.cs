using DesignPatterns.Creational.Builder.Enums;

namespace DesignPatterns.Creational.Builder.Models
{
    internal class Pizza
    {
        private PizzaType _type;
        private string _dough = string.Empty;
        private string _sauce = string.Empty;
        private string _topping = string.Empty;

        public Pizza(PizzaType spicy)
        {
            _type = spicy;
        }

        internal string Dough { get => _dough; set => _dough = value; }
        internal string Sauce { get => _sauce; set => _sauce = value; }
        internal string Topping { get => _topping; set => _topping = value; }
        internal PizzaType Type { get => _type; set => _type = value; }
    }
}
