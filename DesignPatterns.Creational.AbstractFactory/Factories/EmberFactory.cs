using DesignPatterns.Creational.AbstractFactory.Models;
using System;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    internal class EmberFactory : ArchitectureFactory
    {
        public override Cpu CreateCPU()
        {
            throw new NotImplementedException();
        }

        public override Mmu CreateMMU()
        {
            throw new NotImplementedException();
        }
    }
}
