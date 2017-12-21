using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorators.Decorator
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
