namespace DesignPatterns.Creational.AbstractFactoryDemo.Models
{
    internal class Cpu
    {
        private readonly string specification;

        public string Specification => specification;

        public Cpu(string specification)
        {
            this.specification = specification;
        }
    }
}
