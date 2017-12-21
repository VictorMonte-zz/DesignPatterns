using DesignPatterns.Structural.Decorator.Interfaces;
using DesignPatterns.Structural.Decorators.Decorator;
using System;

namespace DesignPatterns.Structural.Decorators.Decorators
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
