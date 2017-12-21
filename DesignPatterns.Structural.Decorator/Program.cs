using DesignPatterns.Structural.DecoratorDemo.Decorators;
using DesignPatterns.Structural.DecoratorDemo.Interfaces;
using DesignPatterns.Structural.DecoratorDemo.Models;
using DesignPatterns.Structural.DecoratorDemos.Decorators;
using System;

namespace DesignPatterns.Structural.DecoratorDemo
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
