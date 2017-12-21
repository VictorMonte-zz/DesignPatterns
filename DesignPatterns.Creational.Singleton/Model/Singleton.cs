using System;

namespace DesignPatterns.Creational.SingletonDemo.Model
{
    internal sealed class Singleton
    {
        private static readonly Lazy<Singleton> _lazy = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance { get { return _lazy.Value; } }
        private Singleton() { }
    }
}
