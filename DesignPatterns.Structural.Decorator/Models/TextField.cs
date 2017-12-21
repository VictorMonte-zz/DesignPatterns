using DesignPatterns.Structural.DecoratorDemo.Interfaces;
using System;

namespace DesignPatterns.Structural.DecoratorDemo.Models
{
    internal class TextField : IWidget
    {
        private double _width;
        private double _height;

        public TextField(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Text field drawed with width:{_width} and height: {_height}");
        }
    }
}
