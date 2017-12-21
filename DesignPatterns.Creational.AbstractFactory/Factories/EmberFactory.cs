using DesignPatterns.Creational.AbstractFactory.Models;
using DesignPatterns.Creational.AbstractFactory.Models.Ember;

namespace DesignPatterns.Creational.AbstractFactory.Factories
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
