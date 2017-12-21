using DesignPatterns.Structural.DecoratorDemo.Interfaces;
using DesignPatterns.Structural.DecoratorDemos.Decorator;
using System;

namespace DesignPatterns.Structural.DecoratorDemo.Decorators
{
    internal class ScrollDecorator : Decorator
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
