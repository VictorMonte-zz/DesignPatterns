using DesignPatterns.Creational.AbstractFactory.Models;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    internal class EnginolaFactory : ArchitectureFactory
    {
        public override Cpu CreateCPU()
        {
            throw new System.NotImplementedException();
        }

        public override Mmu CreateMMU()
        {
            throw new System.NotImplementedException();
        }
    }
}