using System;
using DesignPatterns.Creational.BuilderDemo.Models;

namespace DesignPatterns.Creational.BuilderDemo.Builders
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
