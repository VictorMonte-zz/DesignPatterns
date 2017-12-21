using DesignPatterns.Creational.AbstractFactory.Models;
using DesignPatterns.Creational.AbstractFactory.Models.Enginola;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    internal class EnginolaFactory : ArchitectureFactory
    {
        public override Cpu CreateCpu()
        {
            return new EnginolaCpu();
        }

        public override Mmu CreateMmu()
        {
            return new EnginolaMmu();
        }
    }
}