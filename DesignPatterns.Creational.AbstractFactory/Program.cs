using DesignPatterns.Creational.AbstractFactory.Enums;
using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.Models;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            ArchitectureFactory factory = ArchitectureFactory.Get(Architecture.EMBER);
            Cpu cpu = factory.CreateCPU();
        }
    }
}
