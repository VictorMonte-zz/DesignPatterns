using DesignPatterns.Creational.BuilderDemo.Builders;
using DesignPatterns.Creational.BuilderDemo.Models;

namespace DesignPatterns.Creational.BuilderDemo.Directors
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
