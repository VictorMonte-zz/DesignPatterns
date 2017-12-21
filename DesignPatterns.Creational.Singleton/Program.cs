using DesignPatterns.Creational.SingletonDemo.Model;
using System;

namespace DesignPatterns.Creational.SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;

            Console.WriteLine($"Is same instance? {instance1.Equals(instance2)}.");
            Console.Read();
        }
    }
}
