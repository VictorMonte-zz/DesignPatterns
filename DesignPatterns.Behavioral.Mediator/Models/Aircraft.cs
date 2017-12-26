using DesignPatterns.Behavioral.MediatorDemo.Interfaces;

namespace DesignPatterns.Behavioral.MediatorDemo.Models
{
    internal abstract class Aircraft
    {
        public string Callsign { get; }

        public abstract int Ceiling { get; }

        public int Altitude
        {
            get { return _currentAltitude; }
            set
            {
                _currentAltitude = value;
                _mediator.ReceiveAircraftLocation(this);
            }
        }

        private readonly IAirTrafficControl _mediator;

        private int _currentAltitude;

        protected Aircraft(string callSign, IAirTrafficControl mediator)
        {
            Callsign = callSign;

            _mediator = mediator;
            _mediator.RegisterAircraftUnderGuidance(this);            
        }

        internal void WarnOfAirspaceIntrusionBy(Aircraft reportedAirfract)
        {
            
        }

        internal void Climb(int heightToClimb)
        {
            Altitude += heightToClimb;
        }
    }
}
