using DesignPatterns.Creational.AbstractFactoryDemo.Models;
using DesignPatterns.Creational.AbstractFactoryDemo.Models.Enginola;

namespace DesignPatterns.Creational.AbstractFactoryDemo.Factories
{
    internal class EnginolaFactory : AbstractFactory
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