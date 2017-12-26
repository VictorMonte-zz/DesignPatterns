using DesignPatterns.Behavioral.MediatorDemo.Interfaces;
using DesignPatterns.Behavioral.MediatorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.MediatorDemo.Mediator
{
    internal class Tower : IAirTrafficControl
    {
        private IList<Aircraft> _aircraftUnderGuidance = new List<Aircraft>();

        public void ReceiveAircraftLocation(Aircraft reportedAirfract)
        {
            foreach (var currentAircraft in _aircraftUnderGuidance.Where(a => a != reportedAirfract))
            {
                if(Math.Abs(currentAircraft.Altitude - reportedAirfract.Altitude) < 1000)
                {
                    reportedAirfract.Climb(1000);
                    currentAircraft.WarnOfAirspaceIntrusionBy(reportedAirfract);
                }
            }
        }

        public void RegisterAircraftUnderGuidance(Aircraft aircraft)
        {
            if (!_aircraftUnderGuidance.Contains(aircraft))
            {
                _aircraftUnderGuidance.Add(aircraft);
            }
        }
    }
}
