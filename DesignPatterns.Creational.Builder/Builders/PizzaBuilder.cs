using System;
using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Builders
{
    internal abstract class PizzaBuilder
    {
        protected Pizza Pizza;

        public abstract void Create();
        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();        

        internal Pizza Get()
        {
            return Pizza;
        }
    }
}
