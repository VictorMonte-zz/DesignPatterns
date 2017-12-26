using DesignPatterns.Behavioral.MediatorDemo.Mediator;
using DesignPatterns.Behavioral.MediatorDemo.Models;

namespace DesignPatterns.Behavioral.MediatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tower tower = new Tower();

            Aircraft flight1 = new Airbus("AC159", tower);
            Aircraft flight2 = new Boeing("WS203", tower);
            Aircraft flight3 = new Fokker("AC602", tower);

            flight1.Altitude += 1000;
        }
    }
}
