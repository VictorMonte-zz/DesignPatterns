using DesignPatterns.Structural.DecoratorDemo.Interfaces;

namespace DesignPatterns.Structural.DecoratorDemos.Decorator
{
    internal abstract class Decorator : IWidget
    {
        private IWidget _widget;

        public Decorator(IWidget widget)
        {
            _widget = widget;
        }

        public virtual void Draw()
        {
            _widget.Draw();
        }
    }
}
