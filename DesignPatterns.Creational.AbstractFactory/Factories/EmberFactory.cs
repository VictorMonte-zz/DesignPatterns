using DesignPatterns.Creational.AbstractFactoryDemo.Models;
using DesignPatterns.Creational.AbstractFactoryDemo.Models.Ember;

namespace DesignPatterns.Creational.AbstractFactoryDemo.Factories
{
    internal class EmberFactory : ArchitectureFactory
    {
        public override Cpu CreateCpu()
        {
            return new EmberCpu();
        }

        public override Mmu CreateMmu()
        {
            return new EmberMmu();
        }
    }
}
