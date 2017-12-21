using DesignPatterns.Structural.Decorator.Decorators;
using DesignPatterns.Structural.Decorator.Interfaces;
using DesignPatterns.Structural.Decorator.Models;
using DesignPatterns.Structural.Decorators.Decorators;
using System;

namespace DesignPatterns.Structural.Decorator
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            IWidget widget = new BorderDecorator(new ScrollDecorator(new TextField(10.1, 12.1)));
            widget.Draw();
            Console.Read();
        }
    }
}
