using System;

namespace Cargo.DomainModel
{
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
    }
}