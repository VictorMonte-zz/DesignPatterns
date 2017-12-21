using DesignPatterns.Structural.DecoratorDemo.Interfaces;
using DesignPatterns.Structural.DecoratorDemos.Decorator;
using System;

namespace DesignPatterns.Structural.DecoratorDemos.Decorators
{
    internal class BorderDecorator : AbstractDecorator
    {
        public BorderDecorator(IWidget widget) : base(widget)
        {
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Border added.");
        }
    }
}
