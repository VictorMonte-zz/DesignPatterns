using DesignPatterns.Creational.SingletonDemo.Model;
using System;

namespace DesignPatterns.Creational.SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance1 = ConnectionSingleton.Instance;
            var instance2 = ConnectionSingleton.Instance;

            Console.WriteLine($"Is same instance? {instance1.Equals(instance2)}.");
            Console.Read();
        }
    }
}
