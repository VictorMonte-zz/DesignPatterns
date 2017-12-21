using System;
using DesignPatterns.Creational.AbstractFactory.Enums;
using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.Models;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Create(Architecture.EMBER);
            Create(Architecture.ENGINOLA);
            Console.Read();
        }

        private static void Create(Architecture architecture)
        {
            ArchitectureFactory factory = ArchitectureFactory.Get(architecture);
            Cpu cpu = factory.CreateCpu();
            Console.WriteLine($"The {cpu.Specification} has been created!!");
        }
    }
}
