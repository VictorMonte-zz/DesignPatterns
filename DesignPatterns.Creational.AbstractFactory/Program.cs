using System;
using DesignPatterns.Creational.AbstractFactoryDemo.Enums;
using DesignPatterns.Creational.AbstractFactoryDemo.Factories;
using DesignPatterns.Creational.AbstractFactoryDemo.Models;

namespace DesignPatterns.Creational.AbstractFactoryDemo
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
