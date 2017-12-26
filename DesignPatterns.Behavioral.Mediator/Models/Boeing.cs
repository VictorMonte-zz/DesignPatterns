using DesignPatterns.Behavioral.MediatorDemo.Interfaces;

namespace DesignPatterns.Behavioral.MediatorDemo.Models
{
    internal class Boeing : Aircraft
    {
        public Boeing(string callSign, IAirTrafficControl mediator)
            : base(callSign, mediator)
        {

        }

        public override int Ceiling => 33000;
    }
}
