using DesignPatterns.Creational.AbstractFactoryDemo.Enums;
using DesignPatterns.Creational.AbstractFactoryDemo.Models;
using System;

namespace DesignPatterns.Creational.AbstractFactoryDemo.Factories
{
    /// <summary>
    /// This class represents the pattern AbstractFactory
    /// </summary>
    internal abstract class ArchitectureFactory
    {
        private static Lazy<EmberFactory> _EMBER_FACTORY = new Lazy<EmberFactory>();
        private static Lazy<EnginolaFactory> _ENGINOLA_FACTORY = new Lazy<EnginolaFactory>();

        /// <summary>
        /// Core method for the abstract factory.
        /// It should return your factory, depending on your Architecture enum.
        /// </summary>
        /// <param name="architecture">Type of architecture factory wished.</param>
        /// <returns>The factory needed.</returns>
        internal static ArchitectureFactory Get(Architecture architecture)
        {
            ArchitectureFactory factory = null;
            switch (architecture)
            {
                case Architecture.ENGINOLA:
                    factory = _ENGINOLA_FACTORY.Value;
                    break;
                case Architecture.EMBER:
                    factory = _EMBER_FACTORY.Value;
                    break;                
            }
            return factory;
        }

        public abstract Cpu CreateCpu();

        public abstract Mmu CreateMmu();
    }
}
