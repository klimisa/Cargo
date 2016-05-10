using System;

namespace Cargo.DomainModel
{
    //TODO: This class should be implemented with specification pattern.
    public class DeliverySpecification
    {
        private DateTime _arrivalTime;
        public DateTime ArrivalTime
        {
            get { return _arrivalTime; }
            set { _arrivalTime = value; }
        }

        private Location _destination;
        public Location Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        //Should take an expresion as arguments
        public bool IsSatisfied()
        {
            throw new NotImplementedException();
        }
    }
}