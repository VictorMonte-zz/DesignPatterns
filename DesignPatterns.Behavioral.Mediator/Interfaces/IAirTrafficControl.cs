using DesignPatterns.Behavioral.MediatorDemo.Models;

namespace DesignPatterns.Behavioral.MediatorDemo.Interfaces
{
    /// <summary>
    /// Mediator interface
    /// </summary>
    internal interface IAirTrafficControl
    {
        void ReceiveAircraftLocation(Aircraft reportingAircraft);
        void RegisterAircraftUnderGuidance(Aircraft aircraft);
    }
}
