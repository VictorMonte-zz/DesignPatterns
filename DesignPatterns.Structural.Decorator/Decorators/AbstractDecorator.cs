using DesignPatterns.Structural.DecoratorDemo.Interfaces;

namespace DesignPatterns.Structural.DecoratorDemos.Decorator
{
    internal abstract class AbstractDecorator : IWidget
    {
        private IWidget _widget;

        public AbstractDecorator(IWidget widget)
        {
            _widget = widget;
        }

        public virtual void Draw()
        {
            _widget.Draw();
        }
    }
}
