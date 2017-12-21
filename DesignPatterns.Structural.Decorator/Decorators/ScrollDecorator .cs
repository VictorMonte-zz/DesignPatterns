using DesignPatterns.Structural.Decorator.Interfaces;
using DesignPatterns.Structural.Decorators.Decorator;
using System;

namespace DesignPatterns.Structural.Decorator.Decorators
{
    internal class ScrollDecorator : AbstractDecorator
    {
        public ScrollDecorator(IWidget widget) : base(widget)
        {
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Scroll added.");
        }
    }
}
