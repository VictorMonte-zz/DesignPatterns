using System;

namespace DesignPatterns.Creational.Singleton.Model
{
    internal sealed class ConnectionSingleton
    {
        private static readonly Lazy<ConnectionSingleton> _lazy = new Lazy<ConnectionSingleton>(() => new ConnectionSingleton());
        public static ConnectionSingleton Instance { get { return _lazy.Value; } }
        private ConnectionSingleton() { }
    }
}
