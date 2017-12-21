using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Directors
{
    internal class Waiter
    {
        private PizzaBuilder _builder;

        public void SetBuilder(PizzaBuilder builder)
        {
            _builder = builder;
        }
        public Pizza GetPizza()
        {
            return _builder.Get();
        }

        public void Construct()
        {
            _builder.Create();
            _builder.BuildDough();
            _builder.BuildSauce();
            _builder.BuildTopping();
        }
    }
}
